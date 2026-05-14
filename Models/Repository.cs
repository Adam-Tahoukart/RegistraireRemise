// Classe qui lit et modifie les fichiers json
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace PFI.Models
{
    public class Repository<T> where T : Record
    {
        private string FilePath => HttpContext.Current.Server.MapPath("~/App_Data/" + _fileName + ".json");
        private string _fileName;

        // Garde le nom du fichier
        public Repository(string fileName)
        {
            _fileName = fileName;
        }

        // Lit le fichier json
        public List<T> ToList()
        {
            if (!File.Exists(FilePath)) return new List<T>();
            string json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
        }

        // Donne un element avec son id
        public T Get(int id)
        {
            return ToList().FirstOrDefault(r => r.Id == id);
        }

        // Ajoute un element
        public void Add(T record)
        {
            List<T> list = ToList();
            record.Id = list.Count > 0 ? list.Max(r => r.Id) + 1 : 1;
            list.Add(record);
            Save(list);
        }

        // Met a jour un element
        public void Update(T record)
        {
            List<T> list = ToList();
            int index = list.FindIndex(r => r.Id == record.Id);
            if (index >= 0)
            {
                list[index] = record;
                Save(list);
            }
        }

        // Supprime un element
        public void Delete(int id)
        {
            List<T> list = ToList();
            list.RemoveAll(r => r.Id == id);
            Save(list);
        }

        // Sauvegarde le fichier json
        private void Save(List<T> list)
        {
            string json = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }
    }
}