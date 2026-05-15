using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Hosting;

namespace DAL
{
    public class Repository<T>
    {
        static bool TransactionOnGoing = false;
        static int NestedTransactionsCount = 0;
        static private readonly Mutex mutex = new Mutex();
        private List<T> dataList;
        private string FilePath;
        private string _SerialNumber;
        private readonly ImageAsset<T> ImageAsset = new ImageAsset<T>();

        private object GetAttributeValue(T data, string attributeName)
        {
            return data.GetType().GetProperty(attributeName).GetValue(data, null);
        }

        private void SetAttributeValue(T data, string attributeName, object value)
        {
            data.GetType().GetProperty(attributeName).SetValue(data, value, null);
        }

        private bool AttributeNameExist(string attributeName)
        {
            var instance = Activator.CreateInstance(typeof(T));
            return instance.GetType().GetProperty(attributeName) != null;
        }

        private int Id(T data)
        {
            return (int)GetAttributeValue(data, "Id");
        }

        private void ReadFile()
        {
            MarkHasChanged();
            dataList.Clear();
            using (var sr = new StreamReader(FilePath))
                dataList = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());

            if (dataList == null)
                dataList = new List<T>();
        }

        private void UpdateFile()
        {
            using (var sw = new StreamWriter(FilePath))
                sw.WriteLine(JsonConvert.SerializeObject(dataList, Formatting.Indented));
            ReadFile();
        }

        private int NextId()
        {
            int maxId = 0;
            foreach (var data in dataList)
            {
                int Id = this.Id(data);
                if (Id > maxId) maxId = Id;
            }
            return maxId + 1;
        }

        public Repository()
        {
            dataList = new List<T>();

            var idExist = AttributeNameExist("Id");
            if (!idExist)
                throw new Exception("The class Repository cannot work with types that do not contain an attribute named Id of type int.");

            string serverPath = HostingEnvironment.MapPath(@"~/App_Data/");
            FilePath = Path.Combine(serverPath, typeof(T).Name + "s.json");
            Init(FilePath);
        }

        public bool HasChanged
        {
            get
            {
                if (IsMarkedChanged)
                {
                    HttpContext.Current.Session[this.GetType().Name] = _SerialNumber;
                    return true;
                }
                return false;
            }
        }

        public bool IsMarkedChanged
        {
            get { return ((string)HttpContext.Current.Session[this.GetType().Name] != _SerialNumber); }
        }

        public void BeginTransaction()
        {
            if (!TransactionOnGoing)
            {
                mutex.WaitOne();
                TransactionOnGoing = true;
            }
            else
            {
                NestedTransactionsCount++;
            }
        }

        public void EndTransaction()
        {
            if (NestedTransactionsCount <= 0)
            {
                TransactionOnGoing = false;
                mutex.ReleaseMutex();
            }
            else
            {
                NestedTransactionsCount--;
            }
        }

        public virtual void Init(string filePath)
        {
            if (!TransactionOnGoing) mutex.WaitOne();
            try
            {
                FilePath = filePath;
                if (string.IsNullOrEmpty(FilePath))
                    throw new Exception("FilePath not set exception");

                if (!File.Exists(FilePath))
                {
                    using (StreamWriter sw = File.CreateText(FilePath)) { }
                }
                ReadFile();
            }
            finally
            {
                if (!TransactionOnGoing) mutex.ReleaseMutex();
            }
        }

        public virtual void MarkHasChanged()
        {
            _SerialNumber = Guid.NewGuid().ToString();
        }

        public List<T> ToList() => dataList;
        public T Get(int Id) => dataList.Where(d => this.Id(d) == Id).FirstOrDefault();

        public virtual int Add(T data)
        {
            int newId = 0;
            if (!TransactionOnGoing) mutex.WaitOne();
            try
            {
                newId = NextId();
                SetAttributeValue(data, "Id", newId);
                ImageAsset.Update(data);
                dataList.Add(data);
                UpdateFile();
            }
            finally
            {
                if (!TransactionOnGoing) mutex.ReleaseMutex();
            }
            return newId;
        }

        public virtual bool Update(T data)
        {
            if (!TransactionOnGoing) mutex.WaitOne();
            try
            {
                T dataToUpdate = Get(Id(data));
                if (dataToUpdate != null)
                {
                    ImageAsset.Update(data);
                    dataList[dataList.IndexOf(dataToUpdate)] = data;
                    UpdateFile();
                    return true;
                }
            }
            finally
            {
                if (!TransactionOnGoing) mutex.ReleaseMutex();
            }
            return false;
        }

        public virtual bool Delete(int Id)
        {
            if (!TransactionOnGoing) mutex.WaitOne();
            try
            {
                T dataToDelete = Get(Id);
                if (dataToDelete != null)
                {
                    ImageAsset.Delete(dataToDelete);
                    dataList.RemoveAt(dataList.IndexOf(dataToDelete));
                    UpdateFile();
                    return true;
                }
            }
            finally
            {
                if (!TransactionOnGoing) mutex.ReleaseMutex();
            }
            return false;
        }
    }
}
