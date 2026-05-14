<!-- Document de remise du projet -->
**420-KBD-LG Travail final ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.001.png)**

**Equipe de deux - 35% de la note finale Enseignant: Nicolas Chourot Evaluation en classe :** 

- **Jeudi 14 mai a partir de 12:35, groupe 03** 
- **Vendredi 15 mai a partir de 09:50, groupe 01** 
- **Vendredi 15 mai a partir de 14:25, groupe 02** 

**Depot : Fichier html comportant les hyperliens vers les sources sur GitHub et le site heberge sur Azure ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.002.png)Competences** 

- Exploitation appropriee de l’architecture MVC 
- Utilisation de requetes AJAX (envoi/reponse) 
- Gestion de connexion et de session 
- Acces aux pages protegees (lecture seule, lecture/ecriture)
- Gestion des usagers 
  - Creation de compte autonome avec verification de courriel
  - Droits d’acces 
  - Profil utilisateur 
- Assurance qualite des donnees : 
  - Validation syntaxique 
  - Validation semantique 
  - Integrite 
- Securite contre les actions illegitimes
- Interface utilisateur : 
  - En francais 
  - Apparence propre et conviviale 
  - Reactive 
  - Navigation sans cul-de-sac 
  - Pages rafraichies periodiquement (aux 5 secondes)
- Hebergement du site sur Azure 

**Enonce**  

Le departement d’informatique du college Lionel-Groulx vous mandate pour construire un site web transactionnel qui aura pour mission de gerer : 

- Les inscriptions/modification/retrait d’etudiants au programme 420
- Inscription/retrait des etudiants aux cours/session/annee du programme 420
- Ajout/modification/retrait de cours au programme 420 
- Inscription/retrait d’etudiants a un cours specifique du programme 420
- Inscription/modification/retrait d’enseignants au departement
- Attribution/retrait des cours/session/annee du programme 420 aux enseignants du departement 

**Structure des donnees** 

![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.003.jpeg)

Note :  

- Le code de l’etudiant devra etre generer comme suit : [Annee courante][nombre aleatoire de 6 chiffres] p.ex. 2026123456 
- Le code du prof devra etre generer comme suit : CLG-420-[nombre aleatoire de 5 chiffres] p.ex. CLG-420-11412 
- Les codes devront etre tous uniques
- Les usagers sont des employes du registraire, veuillez inclure ces comptes dans vos donnees : 
- admin@app.net/password : droits d’ecriture et administration
- [super@app.net/](mailto:super@app.net)password : droits d’ecriture 
- [user@app.net/](mailto:user@app.net)password : droits de lecture uniquement

**Vue liste des etudiants** 

Liste des etudiants inscrits au programme 420 regroupes par ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.004.jpeg)annees decroissantes. Si l’usager connecte a les droits en ecriture, il a acces a la commande d’ajout. ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.005.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.006.png)

Rafraichie  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.007.png)

periodiquement  La commande         donne/retire l’acces a la barre de recherche 

permettant de filtrer les etudiants par une chaine de recherche et aussi par une annee specifique : 

Un clic sur un etudiant  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.008.png)![ref1]commande l’acces a ses details 

Il faudra mettre en surbrillance ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.010.png)![ref1]les occurrences de la chaine de 

caracteres recherchee

![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.011.png)

La session courante est determinee par la date ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.012.png)actuelle et peut etre change en cliquant dessus.

**Vue details d’un etudiant** 

Rafraichie ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.013.jpeg)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.014.png)periodiquement 

Rafraichie ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.015.png)periodiquement 

Un clic sur un cours commande ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.016.png)l’acces a ses details 

Cette vue presente a la fois les details de l’etudiants et ses inscriptions regroupees par annees decroissantes. 

Les cours devront etre affiches selon le format suivant : 

[session] Sigle Titre![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.017.png)

L’icone ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.018.png)        commande l’acces a la vue de modification de l’etudiants. 

L’icone ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.019.png)       commande le retrait de l’etudiant ainsi que toutes ses inscriptions si l’utilisateur confirme :  

![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.020.png)

L’icone ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.021.png)        commande le retour a vue liste d’etudiants. 

Un clic sur un cours commandera la vue details de ce dernier.

**Vue modification d’un etudiant** 

Presente le formulaire pour modifier les informations de l’etudiants ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.022.jpeg)(sauf le code) et permet aussi d’ajouter ou enlever des inscriptions de cours de la session courante.

Ci-dessous une variante de la vue avec la section Informations fermee et le viewport retreci imposant ainsi une disposition verticale de la gestion des inscriptions. 

![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.023.jpeg)

**Vue liste des cours** 

Presente la liste des cours du programme 420 regroupes par numeros de sessions croissants. Un clic sur le titre d’un cours commande de voir ses details. 

Rafraichie  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.024.jpeg)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.025.jpeg)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.026.png)periodiquement  

Il faudra mettre en  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.027.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.028.png)Un clic sur un cours commande  surbrillance les  

l’acces a ses details  occurrences de la chaine  de caracteres recherchee 

**Vue details d’un cours** 

Cette vue presente les informations de base du cours ainsi que les inscriptions regroupees par annees decroissantes. Si un enseignant est assigne a une cohorte son nom est indique. C’est aussi un hyperlien vers les details de ce dernier. Un clic sur un etudiant commande de voir ses details.

Rafraichie ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.029.jpeg)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.030.png)periodiquement 

Un clic sur un etudiant ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.031.png)commande l’acces a ses details

Un clic sur un prof commande ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.032.png)l’acces a ses details 

Ci-dessous, la vue permettant de modifier les informations de base du cours ainsi que ses inscriptions de la session courante : 

![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.033.jpeg)

**Vue liste des enseignants en ordre alphabetique de nom** 

Rafraichie  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.034.jpeg)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.035.jpeg)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.036.png)periodiquement  

Un clic sur un prof commande  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.037.png)l’acces a ses details  

Il faudra mettre en       ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.038.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.039.png)surbrillance les  \
occurrences de la chaine  de caracteres recherchee 

**Vue details d’un enseignant** 

Cette vue presente les informations de l’enseignant ainsi que ses allocations regroupees par annees decroissantes. Un clic sur le titre d’un cours commande de voir les details de ce dernier.

Rafraichie  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.040.jpeg)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.041.jpeg)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.042.jpeg)![ref2]periodiquement  

Rafraichie  ![ref2]periodiquement  

Un clic sur un cours commande  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.044.png)l’acces a ses details  

**ANNEXE** 

**Fonctionnement du controle de formulaire permettant de gerer une selection** ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.045.png)

Ce controle offre l’interface pour ajouter/enlever des elements d’une liste d’elements non selectionnes a une liste d’elements selectionnes.

Elements selectionnes  Elements non selectionnes![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.046.png)

Deselectionner un element![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.047.png)

Un ctrl-clic permet de faire ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.048.png)une selection multiple 

Ajouter des elements 

**Production et recuperation d’une liste ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.049.png)**

![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.050.png)[ UserAccess ( Access .Admin)] ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.051.png)![ref3]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.053.png)![ref4]![ref5]![ref6]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.057.png)![ref7]![ref8]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.060.png)![ref9]

public  ActionResult  Edit () ![ref10]![ref5]

{  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.063.png)![ref11]![ref12]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.066.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.067.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.068.png)![ref13]![ref14]

int  id  = ( int )Session[ "id" ];  ![ref12]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.071.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.072.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.073.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.074.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.075.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.076.png)![ref11]![ref15]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.078.png)

Student  student  =  DB.Students. Get ( id ); ![ref16]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.080.png)![ref8]![ref12]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.081.png)![ref17]![ref18]

if  ( student  !=  null ) ![ref10]![ref12]

{  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.084.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.085.png)![ref19]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.087.png)

ViewBag.Registrations =  student .NextSessionCoursesToSelectList; ViewBag.Courses![ref19]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.088.png)![ref20]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.090.png) =  DB.Courses.NextSessionToSelectList;![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.091.png)![ref8]![ref19]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.092.png)![ref21]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.094.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.095.png)![ref20]![ref8]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.096.png)

return  View ( DB.Students. Get ( id )); ![ref22]![ref12]

}  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.098.png)![ref12]![ref21]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.099.png)![ref15]![ref8]

return  RedirectToAction ( "Index" ); ![ref22]![ref5]

} 

[ HttpPost ] ![ref5]![ref8]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.100.png)![ref7]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.101.png)![ref9]![ref9]![ref5]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.102.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.103.png)

[ UserAccess ( Access .Admin)] ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.104.png)![ref14]![ref8]![ref5]![ref6]![ref3]![ref23]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.106.png)![ref4]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.107.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.108.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.109.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.110.png)![ref18]

public  ActionResult  Edit ( Student  student ,  List <int >  selectedCoursesId ) ![ref5]![ref10]{  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.111.png)![ref16]![ref8]![ref12]![ref18]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.112.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.113.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.114.png)

if  ( s tudent .IsValid () ) ![ref12]![ref10]

{  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.115.png)![ref13]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.116.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.117.png)![ref19]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.118.png)![ref17]

student .Id = ( int )Session[ "id" ]; ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.119.png)![ref19]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.120.png)![ref17]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.121.png)![ref13]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.122.png)

student .Code = ( string )Session[ "code" ];  ![ref23]![ref8]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.123.png)![ref17]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.124.png)![ref20]![ref19]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.125.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.126.png)

DB.Students. Update ( student ,  selectedCoursesId ); ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.127.png)![ref19]![ref21]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.128.png)![ref23]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.129.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.130.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.131.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.132.png)![ref8]

return  RedirectToAction ( "Details" ,  new  { id =  student .Id });![ref22]![ref12]

}  ![ref12]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.133.png)![ref24]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.135.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.136.png)![ref25]

return  Redirect ( "/Accounts/Login?message=Acces illegal! &success=false" );![ref22]![ref5]

} 

**Utilitaires pour produire une liste de selection![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.138.png)**

public  class  SelectListUtilities <T> ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.139.png)![ref26]![ref27]![ref28]![ref29]![ref27]![ref30]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.145.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.146.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.147.png)

{  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.148.png)![ref31]![ref32]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.151.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.152.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.153.png)![ref24]![ref30]![ref33]![ref34]![ref35]![ref32]![ref36]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.158.png)![ref37]![ref38]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.161.png)![ref39]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.163.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.164.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.165.png)![ref40]

public  static  SelectList  Convert ( IEnumerable <T>  collection ,  string  targetField  =  "Name" ,  string  defaultText  =  "" ) ![ref26]![ref35]{  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.167.png)![ref30]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.168.png)![ref33]![ref41]![ref42]![ref43]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.172.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.173.png)![ref44]![ref32]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.175.png)

List <SelectListItem >  items  =  new  List <SelectListItem >(); ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.176.png)![ref42]![ref45]![ref31]![ref46]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.179.png)![ref37]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.180.png)![ref24]

if  ( typeof ( T).Name ==  "String" ) ![ref26]![ref42]

{  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.181.png)![ref47]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.183.png)![ref48]

int  index  = 0;  ![ref48]![ref24]![ref49]![ref31]![ref50]![ref51]![ref37]![ref52]

foreach  ( T  item  in  collection ) ![ref26]![ref48]

{  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.189.png)![ref53]![ref24]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.191.png)![ref54]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.193.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.194.png)![ref55]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.196.png)![ref56]![ref54]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.198.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.199.png)![ref57]![ref58]![ref59]

items . Add( new  SelectListItem () { Value =  index . ToString (), Text =  item . ToString () });![ref47]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.203.png)![ref57]

index ++; ![ref60]![ref48]

} ![ref60]![ref42]

} ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.205.png)![ref42]

else ![ref42]![ref26]

{  ![ref37]![ref52]![ref50]![ref51]![ref31]![ref24]![ref49]![ref48]

foreach  ( T  item  in  collection ) ![ref26]![ref48]

{  ![ref57]![ref55]![ref24]![ref56]![ref54]

items . Add(  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.206.png)![ref44]![ref61]![ref62]

new  SelectListItem () ![ref26]![ref62]

{  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.209.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.210.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.211.png)![ref29]![ref63]![ref24]![ref24]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.213.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.214.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.215.png)![ref46]![ref64]![ref65]![ref66]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.219.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.220.png)![ref67]![ref40]

Value =  typeof ( T). GetProperty ( "Id" ). GetValue ( item ,  null ). ToString (),  ![ref67]![ref46]![ref63]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.222.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.223.png)![ref29]![ref67]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.224.png)![ref46]![ref68]![ref46]![ref51]![ref39]![ref66]![ref58]![ref69]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.227.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.228.png)

Text =  typeof ( T). GetProperty ( targetField ). GetValue ( item ,  null ). ToString () ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.229.png)![ref62]

}); ![ref60]![ref48]

} ![ref60]![ref42]

}  ![ref37]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.230.png)![ref70]![ref38]![ref24]![ref45]![ref42]

if  ( defaultText  !=  "" )  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.232.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.233.png)![ref48]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.234.png)![ref41]![ref61]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.235.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.236.png)![ref59]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.237.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.238.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.239.png)

items . Insert (0,  new  SelectListItem  { Value =  "0" , Text =  defaultText  }); ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.240.png)![ref42]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.241.png)![ref43]![ref71]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.243.png)![ref46]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.244.png)![ref39]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.245.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.246.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.247.png)![ref39]

return  new  SelectList ( items ,  "Value" ,  "Text" , 0,  new[] { 0 });![ref60]![ref35]

} ![ref60]![ref27]

} 

**Methodes a ajouter dans la classe Student  (il faudra appliquer une logique similaire pour les classes Course et Teacher)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.248.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.249.png)**

[ JsonIgnore ]  public  string  FullName => LastName +  " "  + FirstName; ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.250.png)![ref72]![ref73]![ref74]![ref75]![ref76]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.256.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.257.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.258.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.259.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.260.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.261.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.262.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.263.png)![ref75]![ref74]![ref72]![ref76]![ref73]

[ JsonIgnore ]  public  string  Caption => Code +  " "  + LastName +  " "  + FirstName;![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.264.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.265.png)![ref73]![ref76]![ref72]![ref74]![ref77]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.267.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.268.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.269.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.270.png)![ref78]

[ JsonIgnore ]  public  int  Year =>  int . Parse (Code. Substring (0, 4)); ![ref79]![ref80]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.274.png)![ref73]![ref76]![ref72]![ref74]![ref81]![ref82]![ref83]![ref84]![ref85]![ref86]![ref84]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.281.png)![ref87]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.283.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.284.png)![ref88]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.286.png)

[ JsonIgnore ]  public  List <Registration > Registrations =>  DB.Registrations. ToList (). Where( r  =>  r .StudentId == Id). ToList ();    ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.287.png)![ref82]![ref81]![ref79]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.288.png)![ref76]![ref73]![ref72]![ref74]![ref87]![ref83]![ref89]![ref90]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.291.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.292.png)![ref91]![ref87]![ref88]![ref85]![ref84]![ref80]![ref89]

[ JsonIgnore ]  public  List <Registration > NextSessionRegistrations =>  DB.Registrations. ToList (). Where( r  =>  r .StudentId == Id &&  r .IsNextSession). ToList (); ![ref92]![ref76]![ref73][ JsonIgnore ] ![ref93]![ref82]![ref94]![ref74]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.297.png)

public  List <Course > Courses![ref95]

{  ![ref96]![ref97]

get ![ref95]![ref96]

{  ![ref82]![ref94]![ref98]![ref93]![ref99]![ref100]![ref101]![ref102]![ref103]

var  courses  =  new  List <Course >();  ![ref104]![ref102]![ref85]![ref85]![ref105]![ref101]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.309.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.310.png)![ref84]![ref84]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.311.png)![ref86]![ref106]

foreach  ( var  registration  in  Registrations. OrderBy ( r  =>  r .Course.Code))![ref107]![ref102]

{  ![ref108]![ref109]![ref110]![ref100]![ref77]![ref85]![ref111]

courses . Add( registration .Course);![ref112]![ref102]

}  ![ref113]![ref114]![ref102]![ref115]

return  courses ; ![ref96]![ref116]

} ![ref116]

}  ![ref92]![ref76]![ref73]

[ JsonIgnore ]  ![ref74]![ref82]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.323.png)![ref93]![ref94]

public  List <Course > NextSessionCourses![ref95]

{  ![ref97]![ref96]

get ![ref95]![ref96]

{  ![ref94]![ref98]![ref101]![ref102]![ref100]![ref82]![ref103]![ref93]![ref99]

var  courses  =  new  List <Course >();  ![ref85]![ref102]![ref104]![ref85]![ref101]![ref105]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.324.png)![ref84]![ref90]![ref84]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.325.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.326.png)![ref106]

foreach  ( var  registration  in  NextSessionRegistrations. OrderBy ( r  =>  r .Course.Code))![ref107]![ref102]

{  ![ref77]![ref100]![ref108]![ref110]![ref109]![ref111]![ref85]

courses . Add( registration .Course);![ref112]![ref102]

}  ![ref117]![ref113]![ref115]![ref102]

return  courses ;![ref116]![ref96]

} ![ref116]

}  ![ref72]![ref73]![ref76]![ref74]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.328.png)![ref118]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.330.png)![ref119]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.332.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.333.png)![ref82]![ref120]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.335.png)![ref121]

[ JsonIgnore ]  public  SelectList  CoursesSelectList =>  SelectListUtilities <Course >. Convert (Courses,  "Caption" ); ![ref122]

[ JsonIgnore ]  ![ref74]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.338.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.339.png)![ref118]![ref82]![ref121]![ref120]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.340.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.341.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.342.png)![ref119]![ref92]![ref76]![ref73]

public  SelectList  NextSessionCoursesToSelectList =>  SelectListUtilities <Course >. Convert (NextSessionCourses,  "Caption" ); ![ref122]

public  void  DeleteAllRegistrations () ![ref95]![ref123]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.344.png)![ref124]![ref74]

{  ![ref125]![ref96]![ref85]![ref126]![ref106]![ref104]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.348.png)

foreach  ( Registration  registration  in  Registrations)![ref127]![ref79]![ref128]![ref129]![ref85]![ref125]![ref102]

DB.Registrations. Delete ( registration .Id);![ref116]

}  ![ref123]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.352.png)![ref124]![ref74]

public  void  DeleteNextSessionRegistrations () ![ref95]

{  ![ref104]![ref85]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.353.png)![ref96]![ref106]![ref126]![ref125]

foreach  ( Registration  registration  in  NextSessionRegistrations)![ref127]![ref125]![ref85]![ref129]![ref128]![ref79]![ref102]

DB.Registrations. Delete ( registration .Id);![ref116]

}  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.354.png)![ref82]![ref85]![ref74]![ref124]![ref130]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.356.png)![ref94]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.357.png)![ref78]

public  void  UpdateRegistrations ( List <int >  selectedCoursesId ) ![ref95]

{  ![ref91]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.358.png)![ref96]

DeleteNextSessionRegistrations (); ![ref130]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.359.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.360.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.361.png)![ref85]![ref96]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.362.png)

if  ( selectedCoursesId  !=  null )  ![ref104]![ref102]![ref78]![ref106]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.363.png)![ref85]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.364.png)![ref130]

foreach  ( int  courseId  in  selectedCoursesId ) ![ref107]![ref102]

{  ![ref85]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.365.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.366.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.367.png)![ref103]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.368.png)![ref79]![ref110]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.369.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.370.png)

DB.Registrations. Add( new  Registration  { StudentId = Id, CourseId =  courseId  }); ![ref102]![ref112]

} ![ref116]

} 

Portion de c ode dans  StudentForm.cshtml  pour la selection de cours![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.371.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.372.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.373.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.374.png)

if  (! creating ) ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.375.png)![ref131]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.377.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.378.png)![ref132]![ref37]

{  ![ref133]![ref27]![ref134]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.382.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.383.png)

<details  open >  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.384.png)![ref35]![ref133]![ref135]![ref136]![ref137]![ref134]![ref138]![ref139]

<summary >@session </ summary >  ![ref35]![ref138]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.390.png)![ref59]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.391.png)![ref46]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.392.png)![ref71]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.393.png)![ref34]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.394.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.395.png)

@Helper . SelectionLists ( "selectedCoursesId" , ( SelectList )ViewBag.Registrations, ( SelectList )ViewBag.Courses)![ref134]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.396.png)![ref140]![ref27]

</ details > ![ref141]

} 

Code du helper ( App\_Code/Helper.cshtml ) ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.399.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.400.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.401.png)

@helper  SelectionLists ( string  controlId , System.Web.Mvc. SelectList  selectedItems , System.Web.Mvc. SelectList  items ,  int  size  = 10) ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.402.png)![ref131]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.403.png)![ref138]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.404.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.405.png)![ref46]![ref36]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.406.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.407.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.408.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.409.png)![ref71]![ref55]![ref40]![ref142]![ref143]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.412.png){  ![ref133]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.413.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.414.png)![ref138]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.415.png)![ref144]![ref145]![ref27]

<div  class ="select\_ @controlId  selectionsGrid"> ![ref146]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.419.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.420.png)![ref138]![ref35]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.421.png)![ref147]![ref133]![ref148]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.424.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.425.png)![ref144]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.426.png)![ref149]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.428.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.429.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.430.png)![ref150]![ref151]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.433.png)![ref54]

<select  name=' @controlId '  size =' @size . ToString () '  multiple  class ='SelectedItems form - control'>![ref42]![ref138]![ref46]![ref152]![ref70]![ref153]![ref37]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.436.png)

@if  ( selectedItems  !=  null ) ![ref26]![ref42]

{  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.437.png)![ref37]![ref24]![ref48]![ref154]![ref49]![ref50]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.439.png)

foreach  ( var  si  in  selectedItems ) ![ref26]![ref48]

{  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.440.png)![ref155]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.442.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.443.png)![ref151]![ref146]![ref57]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.444.png)![ref151]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.445.png)![ref156]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.447.png)![ref134]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.448.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.449.png)

<option  value =' @si .Value '> @si .Text </ option > ![ref48]![ref60]

} ![ref60]![ref42]

}  ![ref134]![ref157]![ref136]![ref35]

</ select >  ![ref133]![ref158]![ref35]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.452.png)![ref159]

<div  class ="HorSelectionsCMD"> ![ref160]![ref145]![ref42]![ref161]![ref133]![ref150]![ref145]![ref162]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.457.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.458.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.459.png)![ref134]![ref163]

<div  class ="AddSelection icon fa fa - circle - left"  title ="Ajouter"></ div > ![ref158]![ref164]![ref134]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.462.png)![ref165]![ref162]![ref166]![ref150]![ref160]![ref133]![ref145]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.465.png)![ref42]

<div  class ="RemoveSelection icon fa fa - circle - right"  title ="Retirer"></ div >  ![ref167]![ref145]![ref160]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.467.png)![ref168]![ref162]![ref169]![ref170]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.471.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.472.png)![ref170]![ref167]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.473.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.474.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.475.png)![ref171]![ref134]![ref42]![ref133]

<div  class ="UnselectAll icon fa fa - times"  data - toggle ="tooltip"  data - placement ="bottom"  title ="Deselectionner"></ div > ![ref35]![ref136]![ref134]![ref171]</ div >  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.477.png)![ref159]![ref158]![ref133]![ref35]

<div  class ="VerSelectionsCMD"> ![ref42]![ref165]![ref172]![ref133]![ref161]![ref145]![ref160]![ref134]![ref163]![ref162]![ref150]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.479.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.480.png)

<div  class ="AddSelection icon fa fa - circle - up"  title ="Ajouter"></ div >  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.481.png)![ref42]![ref133]![ref145]![ref134]![ref160]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.482.png)![ref150]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.483.png)![ref172]![ref166]![ref164]![ref162]

<div  class ="RemoveSelection icon fa fa - circle - down"  title ="Retirer"></ div > ![ref145]![ref42]![ref160]![ref162]![ref165]![ref168]![ref169]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.484.png)![ref134]![ref145]![ref133]

<div  class ="UnselectAll icon fa fa - times"  title ="Deselectionner"></ div > ![ref134]![ref171]![ref136]![ref35]

</ div >  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.485.png)![ref59]![ref143]![ref35]![ref133]![ref147]![ref148]![ref138]![ref69]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.486.png)![ref159]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.487.png)![ref162]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.488.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.489.png)![ref149]

<select  size =' @size . ToString () '  multiple  class ='UnselectedItems form - control'>![ref46]![ref42]![ref138]![ref152]![ref153]![ref37]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.490.png)![ref70]

@if  ( items  !=  null ) ![ref26]![ref42]

{  ![ref49]![ref24]![ref154]![ref48]![ref50]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.491.png)![ref173]![ref37]

foreach  ( var  ui  in  items ) ![ref26]![ref48]

{  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.493.png)![ref46]![ref57]![ref70]![ref174]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.495.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.496.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.497.png)![ref68]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.498.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.499.png)![ref174]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.500.png)![ref37]![ref65]![ref24]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.501.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.502.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.503.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.504.png)![ref59]

if  ( selectedItems  !=  null  && selectedItems . Where( s  =>  s .Value ==  ui .Value). FirstOrDefault () ==  null ) ![ref26]![ref57]

{  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.505.png)![ref138]![ref138]![ref62]![ref155]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.506.png)![ref173]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.507.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.508.png)![ref140]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.509.png)![ref139]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.510.png)![ref173]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.511.png)

<option  value =' @ui .Value '> @ui .Text </ option > ![ref60]![ref57]

} ![ref60]![ref48]

} ![ref42]![ref60]

}  ![ref134]![ref157]![ref136]![ref35]

</ select > ![ref134]![ref158]![ref140]![ref27]

</ div > ![ref141]

}

Selection.js  Selection.css ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.512.png)![ref107]![ref175]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.514.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.515.png)

.selectionsGrid  { ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.516.png)![ref114]![ref176]![ref177]![ref178]![ref96]

// script pour l'interface de gestion de selection avec deux <select...> display :  flex ; ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.520.png)![ref114]![ref96]![ref179]![ref180]![ref177]![ref181]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.524.png)

// auteur : Nicolas Chourot flex - flow :  row;  ![ref96]![ref182]![ref180]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.526.png)![ref177]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.527.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.528.png)![ref114]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.529.png)

font - family :  Courrier , monospace ; ![ref182]![ref96]![ref180]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.530.png)![ref114]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.531.png)![ref177]font - size :  smaller ; ![ref183]![ref184]![ref114]![ref180]![ref185]![ref96]![ref177]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.535.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.536.png)![ref186]![ref187]![ref188]![ref189]![ref190]![ref187]

$( document ). ready ( initUI );  padding - top  :  8px ; ![ref191]![ref192]![ref96]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.544.png)![ref114]

gap : 0px ;  ![ref192]![ref193]![ref191]![ref114]![ref96]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.546.png)![ref194]![ref195]

function  initUI () { margin : 0px ;  ![ref196]![ref197]![ref198]![ref185]![ref199]![ref192]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.553.png)![ref114]![ref180]![ref96]

sortAllSelect ();  padding - bottom : 3px ; ![ref188]![ref200]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.555.png)![ref201]![ref187]![ref187]![ref196]![ref116]

deSelectAll ( $( 'body' ));  }  ![ref107]![ref202]

.HorSelectionsCMD  { ![ref114]![ref191]![ref192]![ref193]![ref96]

$( '.UnselectedItems' ). change ( function  ( e) {  margin : 0px ;  ![ref203]![ref198]![ref204]![ref205]![ref206]![ref188]![ref207]![ref208]![ref189]![ref209]![ref96]![ref178]![ref177]![ref114]![ref176]![ref189]![ref210]![ref187]![ref194]![ref211]![ref196]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.567.png)![ref188]![ref187]![ref212]![ref187]

display :  flex ;  ![ref177]![ref180]![ref96]![ref213]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.570.png)![ref117]![ref181]

let  parent  =  $( this ). parent ();  flex - direction :  column ; ![ref180]![ref214]![ref96]![ref177]![ref215]![ref216]![ref114]![ref217]![ref206]![ref204]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.575.png)![ref187]![ref218]![ref189]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.577.png)![ref187]![ref219]![ref220]

parent . find ( '.UnselectedItems option:selected' ). each ( function  () { min - width :  40px ;  ![ref221]![ref177]![ref222]![ref96]![ref223]![ref180]![ref114]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.583.png)![ref187]![ref224]![ref225]![ref226]![ref227]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.588.png)![ref228]![ref204]![ref189]![ref229]![ref187]![ref217]

parent . find ( ".SelectedItems option:selected" ). prop ( "selected" ,  false );  align - items :  center ;  ![ref117]![ref230]![ref177]![ref231]![ref180]![ref96]![ref232]![ref204]![ref233]![ref189]![ref234]![ref187]![ref229]![ref217]![ref228]![ref235]

parent . find ( '.AddSelection' ). show();  justify - content :  center ; ![ref204]![ref217]![ref229]![ref228]![ref236]![ref189]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.598.png)![ref237]![ref187]![ref238]![ref183]![ref192]![ref185]![ref180]![ref96]![ref114]

parent . find ( '.RemoveSelection' ). hide ();  padding - right : 8px ; ![ref204]![ref228]![ref187]![ref233]![ref189]![ref239]![ref229]![ref217]![ref240]![ref116]

parent . find ( '.UnselectAll' ). show();  }  ![ref241]![ref206]![ref107]![ref242]

});  .VerSelectionsCMD  { ![ref243]![ref206]![ref210]![ref217]![ref237]![ref178]![ref96]![ref114]![ref177]![ref244]

e. preventDefault ();  display :  none ;  ![ref245]![ref196]![ref177]![ref213]![ref180]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.608.png)![ref96]![ref181]![ref114]

flex - direction :  row; ![ref114]![ref177]![ref216]![ref180]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.609.png)![ref215]![ref96]

});  min - height :  40px ;  ![ref221]![ref180]![ref96]![ref177]![ref114]![ref223]![ref222]

align - items :  center ;  ![ref117]![ref177]![ref232]![ref231]![ref180]![ref96]![ref230]![ref187]![ref187]![ref211]![ref246]![ref210]![ref187]![ref247]![ref188]![ref196]![ref248]![ref194]

$( '.SelectedItems' ). change ( function  ( e) {  justify - content :  center ; ![ref116]![ref203]![ref208]![ref207]![ref188]![ref209]![ref204]![ref205]![ref206]![ref198]![ref189]

let  parent  =  $( this ). parent ();  }  ![ref206]![ref204]![ref217]![ref219]![ref187]![ref218]![ref189]![ref187]![ref249]![ref195]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.614.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.615.png)![ref107]

parent . find ( 'option:selected' ). each ( function  () { .AddSelectionx  {  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.616.png)![ref189]![ref227]![ref228]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.617.png)![ref187]![ref217]![ref204]![ref224]![ref187]![ref225]![ref226]![ref229]![ref192]![ref180]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.618.png)![ref96]![ref193]![ref114]![ref191]

parent . find ( ".UnselectedItems option:selected" ). prop ( "selected" ,  false );  margin - left : 0px ; ![ref217]![ref228]![ref204]![ref235]![ref189]![ref250]![ref229]![ref187]![ref234]![ref116]

parent . find ( '.AddSelection' ). hide ();  }  ![ref204]![ref236]![ref229]![ref189]![ref217]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.620.png)![ref187]![ref237]![ref228]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.621.png)![ref107]

parent . find ( '.RemoveSelection' ). show();  .UnselectAll  {  ![ref204]![ref229]![ref187]![ref239]![ref189]![ref233]![ref240]![ref228]![ref217]![ref177]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.622.png)![ref180]![ref114]![ref96]![ref193]![ref184]

margin - top :  6px ;  ![ref96]![ref177]![ref180]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.623.png)![ref114]![ref199]![ref193]

parent . find ( '.UnselectAll' ). show();  margin - bottom :  6px ; ![ref116]![ref206]![ref241]

});  }  ![ref107]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.624.png)![ref175]![ref217]![ref206]![ref210]![ref243]![ref237]

e. preventDefault ();  .selectionsGrid  select  { ![ref181]![ref177]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.625.png)![ref96]![ref114]![ref196]![ref245]

});  flex :  1;  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.626.png)![ref114]![ref214]![ref180]![ref215]![ref96]![ref177]

min - width :  120px ; ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.627.png)![ref196]![ref116]

// Important afin que tous les elements soient selectionnes lors de la soumission du formulaire }  ![ref188]![ref196]![ref187]![ref189]![ref251]![ref187]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.629.png)![ref190]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.630.png)![ref226]![ref194]![ref220]![ref226]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.631.png)![ref180]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.632.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.633.png)![ref177]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.634.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.635.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.636.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.637.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.638.png)

$( document ). on( 'submit' ,  'form' ,  function  () { @media  screen  and  ( max- width :  560px  ) ![ref206]![ref226]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.639.png)![ref188]![ref224]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.640.png)![ref187]![ref227]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.641.png)![ref189]![ref187]![ref95]

$( '.SelectedItems option' ). prop ( 'selected' ,  true );  {  ![ref196]![ref245]![ref107]![ref175]![ref96]

.selectionsGrid  { ![ref177]![ref114]![ref178]![ref102]![ref176]

});  display :  flex ;  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.642.png)![ref102]![ref179]![ref181]![ref114]![ref177]![ref180]

flex - flow :  column ; ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.643.png)![ref180]![ref238]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.644.png)![ref193]![ref102]![ref114]![ref252]![ref194]![ref251]![ref187]![ref226]![ref188]![ref253]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.647.png)![ref196]![ref187]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.648.png)

$( ".AddSelection" ). on( 'click' ,  function  () { margin - right :  2px ; ![ref96]![ref116]![ref204]![ref206]![ref205]![ref209]![ref207]![ref203]![ref208]![ref240]![ref203]![ref254]![ref188]![ref189]

let  parent  =  $( this ). parent (). parent ();  }  ![ref189]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.650.png)![ref194]![ref206]![ref204]![ref217]![ref219]![ref187]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.651.png)![ref219]![ref187]![ref189]![ref218]![ref187]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.652.png)![ref255]![ref256]![ref202]![ref107]![ref96]

parent . find ( '.UnselectedItems' ). first (). find ( 'option:selected' ). each ( function  () { .HorSelectionsCMD  { ![ref188]![ref228]![ref189]![ref257]![ref237]![ref208]![ref187]![ref178]![ref177]![ref244]![ref102]![ref114]

$( this ). remove ();  display :  none ; ![ref247]![ref254]![ref258]![ref187]![ref187]![ref189]![ref228]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.657.png)![ref204]![ref188]![ref259]![ref208]![ref187]![ref217]![ref229]![ref116]![ref96]

parent . find ( '.SelectedItems' ). first (). append ( $( this ));  }  ![ref217]![ref260]![ref219]![ref189]![ref207]![ref187]![ref228]![ref261]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.661.png)![ref256]![ref204]![ref107]![ref96]![ref242]

sortSelect ( parent . find ( ".SelectedItems" ). first ()); .VerSelectionsCMD  { ![ref187]![ref224]![ref262]![ref263]![ref254]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.664.png)![ref189]![ref208]![ref187]![ref228]![ref189]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.665.png)![ref219]![ref264]![ref217]![ref265]![ref187]![ref256]![ref188]![ref177]![ref176]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.668.png)![ref102]![ref178]

display :  flex ;  ![ref116]![ref96]

scrollTo ( parent . find ( ".SelectedItems" ). first (),  $( this ). offset (). top );  } ![ref116]![ref217]![ref187]![ref204]![ref229]![ref189]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.669.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.670.png)![ref237]![ref228]

parent . find ( ".SelectedItems" ). focus ();  }  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.671.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.672.png)![ref107]![ref206]![ref241]

});  select  option  { ![ref219]![ref204]![ref217]![ref198]![ref266]![ref189]![ref250]![ref206]![ref187]

parent . find ( '.AddSelection' ). hide ();  ![ref204]![ref206]![ref187]![ref267]![ref189]![ref233]![ref240]![ref219]![ref217]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.675.png)![ref96]![ref117]![ref180]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.676.png)![ref177]![ref268]

parent . find ( '.RemoveSelection' ). show();  text - overflow :  ellipsis ; ![ref198]![ref233]![ref189]![ref269]![ref187]![ref219]![ref217]![ref204]![ref206]![ref96]![ref114]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.679.png)![ref177]![ref268]

parent . find ( '.UnselectAll' ). show ();  overflow :  hidden ; ![ref196]![ref186]![ref270]![ref116]

} );  } 

$( ".RemoveSelection" ). on( 'click' ,  function  () {![ref254]![ref206]![ref205]![ref208]![ref207]![ref204]![ref203]![ref203]![ref188]![ref240]![ref209]![ref189]![ref194]![ref226]![ref253]![ref187]![ref252]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.681.png)![ref271]![ref189]![ref187]![ref188]

let  parent  =  $( this ). parent (). parent ();  ![ref187]![ref206]![ref204]![ref217]![ref219]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.683.png)![ref189]![ref187]![ref256]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.684.png)![ref246]![ref218]![ref187]![ref194]![ref195]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.685.png)![ref219]

parent . find ( '.SelectedItems' ). first (). find ( 'option:selected' ). each ( function  () {![ref228]![ref188]![ref187]![ref208]![ref189]![ref257]![ref237]

$( this ). remove ();  ![ref229]![ref217]![ref187]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.686.png)![ref189]![ref204]![ref228]![ref254]![ref258]![ref259]![ref187]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.687.png)![ref188]![ref208]![ref187]

parent . find ( '.UnselectedItems' ). first (). append ( $( this )); ![ref256]![ref261]![ref207]![ref204]![ref228]![ref260]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.688.png)![ref189]![ref217]![ref187]![ref219]

sortSelect ( parent . find ( ".UnselectedItems" ). first ()); ![ref187]![ref217]![ref265]![ref219]![ref228]![ref187]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.689.png)![ref262]![ref188]![ref189]![ref254]![ref187]![ref256]![ref263]![ref246]![ref224]![ref272]![ref208]![ref264]

scrollTo ( parent . find ( ".UnselectedItems" ). first (),  $( this ). offset (). top ); ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.691.png)![ref187]![ref217]![ref228]![ref204]![ref229]![ref237]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.692.png)![ref189]parent . find ( ".UnselectedItems" ). focus (); ![ref241]![ref206]

});  ![ref189]![ref198]![ref206]![ref204]![ref217]![ref219]![ref233]![ref266]![ref187]

parent . find ( '.AddSelection' ). show ();  ![ref219]![ref206]![ref217]![ref189]![ref204]![ref267]![ref250]![ref240]![ref187]

parent . find ( '.RemoveSelection' ). hide (); ![ref219]![ref204]![ref206]![ref217]![ref269]![ref233]![ref187]![ref189]![ref198]

parent . find ( '.UnselectAll' ). show (); ![ref245]![ref196]

});  ![ref271]![ref189]![ref196]![ref187]![ref188]![ref187]![ref226]![ref194]![ref253]![ref252]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.693.png)

$( ".UnselectAll" ). on( 'click' ,  function  () {![ref188]![ref204]![ref207]![ref206]![ref209]![ref205]![ref203]![ref203]![ref189]![ref240]![ref208]![ref254]

let  parent  =  $( this ). parent (). parent (); ![ref186]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.694.png)![ref187]![ref200]![ref206]

deSelectAll ( parent ); ![ref196]![ref245]

}); ![ref270]

}  ![ref273]![ref265]![ref187]![ref200]![ref194]

function  deSelectAll ( parent ) {  ![ref204]![ref217]![ref189]![ref219]![ref187]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.696.png)![ref250]![ref196]![ref198]

parent . find ( '.AddSelection' ). hide ();  ![ref219]![ref196]![ref204]![ref217]![ref187]![ref250]![ref198]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.697.png)![ref189]

parent . find ( '.RemoveSelection' ). hide (); ![ref196]![ref217]![ref219]![ref198]![ref204]![ref189]![ref250]![ref187]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.698.png)

parent . find ( '.UnselectAll' ). hide ();  ![ref274]![ref227]![ref224]![ref225]![ref226]![ref207]![ref189]![ref187]![ref217]![ref204]![ref196]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.700.png)![ref219]

parent . find ( '.SelectedItems option' ). prop ( 'selected' ,  false );  ![ref274]![ref204]![ref217]![ref196]![ref219]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.701.png)![ref224]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.702.png)![ref187]![ref226]![ref225]![ref189]![ref187]

parent . find ( '.UnselectedItems option' ). prop ( 'selected' ,  false ); ![ref270]

} ![ref275]

// /////////////////////////////////////////////////////////////////![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.704.png)

// Sort text items of a listbox![ref275]

// /////////////////////////////////////////////////////////////////![ref212]![ref276]![ref187]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.706.png)![ref194]
function  normalize ( str ) {  ![ref187]![ref189]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.707.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.708.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.709.png)![ref196]![ref276]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.710.png)![ref217]![ref277]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.712.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.713.png)![ref278]![ref278]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.715.png)![ref187]![ref224]![ref226]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.716.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.717.png)

return  str . normalize ( "NFD" ). replace ( /[ \ u0300 - \ u036f]/ g,  "" ); ![ref270]

}  ![ref260]![ref194]![ref187]![ref273]![ref279]

function  sortSelect ( select ) { ![ref280]![ref196]![ref220]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.720.png)![ref187]![ref218]![ref217]

select . each ( function  () { ![ref206]![ref209]![ref205]![ref280]![ref208]![ref186]![ref207]![ref188]

let  select  =  $( this );  ![ref189]![ref206]![ref280]![ref217]![ref281]![ref187]![ref279]![ref217]![ref187]![ref187]![ref282]![ref194]![ref187]![ref283]![ref226]![ref284]![ref273]![ref285]![ref219]

select . html ( select . find ( 'option' ). sort ( function  ( option1 ,  option2 ) { ![ref286]![ref228]![ref277]![ref188]![ref287]![ref288]![ref189]![ref187]![ref286]![ref289]![ref290]![ref189]![ref187]![ref291]![ref292]![ref188]

return  $( option1 ). text () <  $( option2 ). text () ?  - 1 : 1;![ref293]![ref206]

})) ![ref245]![ref196]

}); ![ref270]

}  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.734.png)![ref197]![ref194]

function  sortAllSelect () { ![ref188]![ref196]![ref187]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.735.png)![ref189]![ref187]![ref249]![ref195]![ref218]

$( 'select' ). each ( function  () {![ref188]![ref186]![ref208]![ref207]![ref280]![ref205]![ref206]![ref209]

let  select  =  $( this );  ![ref219]![ref206]![ref217]![ref217]![ref187]![ref279]![ref187]![ref280]![ref187]![ref226]![ref189]![ref282]![ref194]![ref187]![ref283]![ref284]![ref273]![ref285]![ref281]

select . html ( select . find ( 'option' ). sort ( function  ( option1 ,  option2 ) { ![ref288]![ref189]![ref228]![ref277]![ref188]![ref187]![ref286]![ref290]![ref188]![ref292]![ref189]![ref286]![ref291]![ref289]![ref187]![ref287]

return  $( option1 ). text () <  $( option2 ). text () ?  - 1 : 1;![ref293]![ref206]

})) ![ref245]![ref196]

}); ![ref270]

}  ![ref194]![ref262]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.736.png)![ref187]![ref294]![ref248]![ref226]

function  scrollTo ( selectObj ,  optionTop ) {  ![ref254]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.738.png)![ref263]![ref272]![ref217]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.739.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.740.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.741.png)![ref196]![ref209]

var  selectTop  =  selectObj . offset (). top ;  ![ref295]![ref196]![ref295]![ref217]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.743.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.744.png)![ref187]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.745.png)![ref290]![ref217]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.746.png)![ref294]![ref201]

selectObj . scrollTop ( selectObj . scrollTop () + ( optionTop  -  selectTop )); ![ref270]

} 

**Utilitaire pour determiner la prochaine session**

Utilisez cette ce singleton pour determiner l’annee et la session des prochaines inscriptions et allocations.

public  sealed  class  NextSession![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.747.png)![ref296]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.749.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.750.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.751.png)![ref297]

{  ![ref298]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.754.png)![ref299]![ref300]![ref301]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.758.png)

public  const  int  January = 1;  // month limit for winter registrations![ref301]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.759.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.760.png)![ref299]![ref298]![ref300]

public  const  int  August = 8;   // month limit for automn registrations ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.761.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.762.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.763.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.764.png)![ref300]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.765.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.766.png)![ref302]![ref303]

private  static  readonly  NextSession  instance =  new  NextSession (); ![ref300]![ref301]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.769.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.770.png)![ref304]public  static  NextSession  Instance => instance; ![ref301]![ref304]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.772.png)![ref300]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.773.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.774.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.775.png)

public  static  DateTime  CurrentDate =  DateTime .Now; 

static  public  List <int > ValidSessions![ref305]![ref300]![ref306]![ref307]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.779.png)![ref308]![ref309]![ref310]![ref300]

{  ![ref311]![ref312]

get ![ref305]![ref312]

{  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.785.png)![ref299]![ref308]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.786.png)![ref313]![ref306]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.788.png)![ref307]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.789.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.790.png)![ref303]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.791.png)

List <int >  result  =  new  List <int >(); ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.792.png)![ref314]![ref313]

if  (CurrentDate.Month > January && CurrentDate.Month <= August)![ref313]![ref315]

{   ![ref316]![ref317]![ref318]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.798.png)![ref319]

result . Add(1); ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.800.png)![ref318]![ref319]![ref317]![ref316]

result . Add(3); ![ref317]![ref316]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.801.png)![ref319]![ref318]

result . Add(5); ![ref313]![ref320]

} ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.803.png)![ref313]

else ![ref315]![ref313]

{   ![ref321]![ref322]![ref319]![ref318]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.806.png)

result . Add(2); ![ref319]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.807.png)![ref322]![ref321]![ref318]

result . Add(4); ![ref322]![ref321]![ref319]![ref318]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.808.png)

result . Add(6); ![ref320]![ref313]

}  ![ref323]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.810.png)![ref324]![ref313]

return  result ; ![ref312]![ref320]

} ![ref320]![ref300]

}  ![ref310]![ref325]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.813.png)![ref300]![ref309]

static  public  int  Year ![ref300]![ref305]

{  ![ref312]![ref311]

get ![ref305]![ref312]

{  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.814.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.815.png)![ref325]![ref313]

int  value  = CurrentDate.Year; ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.816.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.817.png)![ref313]![ref314]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.818.png)

if  (CurrentDate.Month > August && CurrentDate.Month <= 12)  value ++; ![ref313]![ref324]![ref323]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.819.png)

return  value ; ![ref320]![ref312]

} ![ref320]![ref300]

}  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.820.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.821.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.822.png)![ref300]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.823.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.824.png)![ref326]![ref310]![ref309]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.826.png)![ref327]

static  public  string  ShortCaption => (ValidSessions. Contains (1) ?  "Automne "  :  "Hiver " ) + Year; static![ref300]![ref310]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.828.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.829.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.830.png)![ref309]![ref326]  public  string  Caption =>  "Session "  + ShortCaption;![ref328]

}

Utilisation du singleton NextSession : ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.832.png)

public  class  Allocation  :  Record ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.833.png)![ref296]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.834.png)![ref297]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.835.png)![ref327]![ref329]{  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.837.png)![ref330]![ref300]![ref301]

public  Allocation () ![ref300]![ref305]

{  ![ref331]![ref302]![ref332]![ref312]

Year =  NextSession .Year;![ref320]![ref300]

} 

public  int  TeacherId {  get ;  set ; } ![ref333]![ref334]![ref335]![ref299]![ref300]![ref336]![ref301]![ref337]![ref338]![ref301]![ref299]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.847.png)![ref336]![ref334]![ref339]![ref300]public  int  CourseId {  get ;  set ; } ![ref340]![ref300]![ref301]![ref336]![ref334]![ref341]![ref342]![ref299]public  int  Year {  get ;  set ; } 

[ JsonIgnore ]   ![ref300]![ref301]![ref343]![ref344]![ref345]![ref346]![ref347]![ref348]![ref349]![ref350]![ref351]![ref300]

public  Course  Course =>  DB.Courses. Get (CourseId);

[ JsonIgnore ]   ![ref300]![ref301]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.861.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.862.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.863.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.864.png)![ref346]![ref352]![ref300]![ref351]![ref349]![ref350]

public  Teacher  Teacher =>  DB.Teachers. Get (TeacherId);

[ JsonIgnore ]  ![ref353]![ref354]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.868.png)![ref355]![ref356]![ref301]![ref300]![ref357]![ref358]![ref354]![ref359]![ref350]![ref351]![ref300]

public  bool  IsNextSession => Year ==  NextSession .Year &&  NextSession .ValidSessions. Contains (Course.Session);![ref328]

} 

public  class  Registration  :  Record ![ref296]![ref329]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.874.png)![ref297]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.875.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.876.png)

{  ![ref330]![ref300]![ref301]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.877.png)

public  Registration () ![ref305]![ref300]

{  ![ref332]![ref312]![ref331]![ref302]

Year =  NextSession .Year;![ref300]![ref320]

}  ![ref301]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.878.png)![ref300]![ref339]![ref334]![ref336]![ref299]![ref338]

public  int  StudentId {  get ;  set ; } ![ref300]![ref301]![ref299]![ref333]![ref336]![ref334]![ref335]![ref337]public  int  CourseId {  get ;  set ; } ![ref336]![ref342]![ref341]![ref300]![ref334]![ref299]![ref301]![ref340]public  int  Year {  get ;  set ; } 

[ JsonIgnore ]  ![ref344]![ref345]![ref348]![ref301]![ref343]![ref300]![ref346]![ref347]![ref351]![ref300]![ref359]![ref350]

public  Course  Course =>  DB.Courses. Get (CourseId);

[ JsonIgnore ]  ![ref300]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.879.png)![ref301]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.880.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.881.png)![ref346]![ref352]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.882.png)![ref359]![ref350]![ref351]![ref300]

public  Student  Student =>  DB.Students. Get (StudentId);

[ JsonIgnore ]  ![ref353]![ref355]![ref300]![ref354]![ref356]![ref301]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.883.png)![ref357]![ref358]![ref354]![ref359]![ref350]![ref351]![ref300]

public  bool  IsNextSession => Year ==  NextSession .Year &&  NextSession .ValidSessions. Contains (Course.Session); ![ref328]

} 

**Retention de l'etat (ouvert) des  balises  <details></details>![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.884.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.885.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.886.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.887.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.888.png)**

Vue  GetStudents.chhtml  qui presente la liste des etudiants inscrits regroupes par annees decroissante  : ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.889.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.890.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.891.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.892.png)@model  IEnumerable <Models. Student > ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.893.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.894.png)![ref28]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.895.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.896.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.897.png)

@{  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.898.png)![ref27]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.899.png)

/\* List of years wich has at least one subscribed student \*/ ![ref142]![ref27]![ref360]![ref361]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.902.png)![ref30]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.903.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.904.png)![ref362]![ref24]![ref363]![ref362]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.907.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.908.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.909.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.910.png)

var  yearsList  = (( List <int >)Session[ "StudentsYearsList" ]). OrderByDescending ( i  =>  i ); ![ref141]

} 

@foreach  ( int  year  in  yearsList ) ![ref131]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.911.png)![ref364]![ref37]![ref361]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.913.png)![ref46]![ref138]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.914.png)

{ 

var  students  = Model. Where( s  =>  s .Year ==  year ); ![ref27]![ref45]![ref24]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.915.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.916.png)![ref54]![ref365]![ref360]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.918.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.919.png)![ref363]![ref174]![ref25]![ref174]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.920.png)![ref27]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.921.png)![ref365]![ref46]

if  ( students . Count () > 0)![ref26]![ref27]

{  Le id de la balise <details> doit ![ref133]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.922.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.923.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.924.png)![ref35]![ref151]![ref366]![ref367]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.927.png)

<details  id ="student\_ details\_ @year ">  contenir “details” pour etre cible ![ref134]![ref135]![ref140]![ref366]![ref151]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.928.png)![ref134]![ref137]![ref133]![ref42]

<@summaryforeach >Cohorte ( var item@yearin  </studentssummary) >  lors de la restauration ![ref26]![ref42]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.929.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.930.png)![ref37]![ref364]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.931.png)![ref154]![ref42]![ref24]![ref138]

{  ![ref48]![ref133]![ref158]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.932.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.933.png)

<div  class ="StudentListLayout"> ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.934.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.935.png)![ref155]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.936.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.937.png)![ref24]![ref57]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.938.png)![ref367]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.939.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.940.png)![ref151]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.941.png)![ref53]![ref39]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.942.png)

<a  href =" @Url. Action ( "Details" ,  new  { id =  item .Id }) "> ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.943.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.944.png)![ref62]![ref155]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.945.png)![ref172]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.946.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.947.png)

<div  style =" display : flex"> ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.948.png)![ref63]![ref151]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.949.png)![ref133]![ref368]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.951.png)![ref134]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.952.png)![ref369]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.954.png)

<span  class ="studentCode"> @item .Code </ span >  ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.955.png)![ref138]![ref133]![ref171]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.956.png)![ref64]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.957.png)![ref151]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.958.png)![ref140]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.959.png)![ref139]![ref368]![ref63]

<div  class ="studentName"> @item .LastName  @item .FirstName </ div > ![ref156]![ref62]![ref158]![ref134]

</ div > ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.960.png)![ref369]![ref57]![ref134]

</ a> ![ref134]![ref145]![ref136]![ref48]

</ div > ![ref42]![ref60]

}  ![ref134]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.961.png)![ref136]![ref35]

</ details > ![ref60]![ref27]

} ![ref141]

}

**Etats des balises <details>…</details> conserves dans Storage/Local storage du fureteur par l’entremise de fonctions JavaScript (voir plus bas)**

function  RestoreDetailsState () {![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.962.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.963.jpeg)![ref370]![ref27]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.965.jpeg)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.966.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.967.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.968.png)

// //////////////////////////////////////////////////////// ///![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.969.png)![ref27] Install event handler //////////////////////////////////////////////////////////![ref370]![ref27]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.970.png)

$( "details" ). off ();  ![ref24]![ref27]![ref371]![ref372]![ref46]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.973.png)![ref39]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.974.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.975.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.976.png)![ref67]![ref24]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.977.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.978.png)![ref371]![ref372]![ref27]![ref67]

$( "details" ). on( 'toggle' ,  function  () {![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.979.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.980.png)![ref32]![ref24]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.981.png)![ref373]![ref35]![ref371]

let  details\_dom  =  $( this )[0]; ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.983.png)![ref132]![ref46]![ref35]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.984.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.985.png)![ref373]

if  ( details\_dom  !=  undefined ) { ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.986.png)

// Save detail state ![ref39]![ref42]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.987.png)![ref54]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.988.png)![ref24]![ref25]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.989.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.990.png)![ref54]![ref59]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.991.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.992.png)

`  `localStorage . setItem ( details\_dom . id ,  details\_dom . open ); ![ref60]![ref35]

} ![ref27]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.993.png)

}) ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.994.png)![ref27]

// Restore state of each details tags ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.995.png)![ref362]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.996.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.997.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.998.png)![ref54]![ref374]![ref374]![ref27]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1000.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1001.png)![ref46]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1002.png)![ref375]

for  ( let  i  = 0;  i  <  localStorage . length ;  i ++) {![ref376]![ref35]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1005.png)![ref32]![ref374]![ref59]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1006.png)![ref46]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1007.png)![ref25]

const  key  =  localStorage . key ( i ); ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1008.png)![ref35]

// target only keys that contain "details" string![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1009.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1010.png)![ref35]![ref132]![ref376]![ref59]![ref46]![ref46]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1011.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1012.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1013.png)

if  ( key . indexOf ( "details" ) >  - 1) { ![ref42]![ref371]![ref32]![ref375]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1014.png)![ref46]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1015.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1016.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1017.png)![ref377]

let  details\_dom  =  $( "#"  +  key )[0];![ref24]![ref37]![ref377]![ref42]![ref45]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1019.png)![ref70]

if  ( details\_dom  !=  undefined ) ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1020.png)![ref48]

// all values in localstorage are stored as string ![ref59]![ref48]![ref377]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1021.png)![ref54]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1022.png)![ref46]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1023.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1024.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1025.png)![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1026.png)![ref376]![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1027.png)

details\_dom . open  =  localStorage . getItem ( key ) ==  "true" ; ![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1028.png)![ref362]![ref375]![ref42]let  i  = 0; ![ref35]![ref60]

} ![ref27]![ref60]

![](Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1029.png) } 

[ref1]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.009.png
[ref2]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.043.png
[ref3]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.052.png
[ref4]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.054.png
[ref5]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.055.png
[ref6]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.056.png
[ref7]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.058.png
[ref8]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.059.png
[ref9]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.061.png
[ref10]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.062.png
[ref11]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.064.png
[ref12]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.065.png
[ref13]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.069.png
[ref14]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.070.png
[ref15]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.077.png
[ref16]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.079.png
[ref17]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.082.png
[ref18]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.083.png
[ref19]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.086.png
[ref20]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.089.png
[ref21]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.093.png
[ref22]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.097.png
[ref23]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.105.png
[ref24]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.134.png
[ref25]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.137.png
[ref26]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.140.png
[ref27]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.141.png
[ref28]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.142.png
[ref29]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.143.png
[ref30]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.144.png
[ref31]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.149.png
[ref32]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.150.png
[ref33]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.154.png
[ref34]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.155.png
[ref35]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.156.png
[ref36]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.157.png
[ref37]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.159.png
[ref38]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.160.png
[ref39]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.162.png
[ref40]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.166.png
[ref41]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.169.png
[ref42]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.170.png
[ref43]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.171.png
[ref44]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.174.png
[ref45]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.177.png
[ref46]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.178.png
[ref47]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.182.png
[ref48]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.184.png
[ref49]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.185.png
[ref50]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.186.png
[ref51]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.187.png
[ref52]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.188.png
[ref53]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.190.png
[ref54]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.192.png
[ref55]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.195.png
[ref56]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.197.png
[ref57]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.200.png
[ref58]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.201.png
[ref59]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.202.png
[ref60]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.204.png
[ref61]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.207.png
[ref62]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.208.png
[ref63]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.212.png
[ref64]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.216.png
[ref65]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.217.png
[ref66]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.218.png
[ref67]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.221.png
[ref68]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.225.png
[ref69]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.226.png
[ref70]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.231.png
[ref71]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.242.png
[ref72]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.251.png
[ref73]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.252.png
[ref74]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.253.png
[ref75]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.254.png
[ref76]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.255.png
[ref77]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.266.png
[ref78]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.271.png
[ref79]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.272.png
[ref80]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.273.png
[ref81]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.275.png
[ref82]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.276.png
[ref83]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.277.png
[ref84]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.278.png
[ref85]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.279.png
[ref86]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.280.png
[ref87]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.282.png
[ref88]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.285.png
[ref89]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.289.png
[ref90]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.290.png
[ref91]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.293.png
[ref92]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.294.png
[ref93]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.295.png
[ref94]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.296.png
[ref95]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.298.png
[ref96]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.299.png
[ref97]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.300.png
[ref98]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.301.png
[ref99]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.302.png
[ref100]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.303.png
[ref101]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.304.png
[ref102]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.305.png
[ref103]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.306.png
[ref104]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.307.png
[ref105]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.308.png
[ref106]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.312.png
[ref107]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.313.png
[ref108]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.314.png
[ref109]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.315.png
[ref110]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.316.png
[ref111]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.317.png
[ref112]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.318.png
[ref113]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.319.png
[ref114]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.320.png
[ref115]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.321.png
[ref116]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.322.png
[ref117]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.327.png
[ref118]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.329.png
[ref119]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.331.png
[ref120]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.334.png
[ref121]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.336.png
[ref122]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.337.png
[ref123]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.343.png
[ref124]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.345.png
[ref125]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.346.png
[ref126]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.347.png
[ref127]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.349.png
[ref128]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.350.png
[ref129]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.351.png
[ref130]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.355.png
[ref131]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.376.png
[ref132]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.379.png
[ref133]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.380.png
[ref134]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.381.png
[ref135]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.385.png
[ref136]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.386.png
[ref137]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.387.png
[ref138]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.388.png
[ref139]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.389.png
[ref140]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.397.png
[ref141]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.398.png
[ref142]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.410.png
[ref143]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.411.png
[ref144]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.416.png
[ref145]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.417.png
[ref146]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.418.png
[ref147]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.422.png
[ref148]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.423.png
[ref149]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.427.png
[ref150]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.431.png
[ref151]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.432.png
[ref152]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.434.png
[ref153]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.435.png
[ref154]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.438.png
[ref155]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.441.png
[ref156]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.446.png
[ref157]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.450.png
[ref158]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.451.png
[ref159]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.453.png
[ref160]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.454.png
[ref161]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.455.png
[ref162]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.456.png
[ref163]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.460.png
[ref164]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.461.png
[ref165]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.463.png
[ref166]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.464.png
[ref167]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.466.png
[ref168]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.468.png
[ref169]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.469.png
[ref170]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.470.png
[ref171]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.476.png
[ref172]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.478.png
[ref173]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.492.png
[ref174]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.494.png
[ref175]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.513.png
[ref176]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.517.png
[ref177]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.518.png
[ref178]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.519.png
[ref179]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.521.png
[ref180]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.522.png
[ref181]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.523.png
[ref182]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.525.png
[ref183]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.532.png
[ref184]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.533.png
[ref185]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.534.png
[ref186]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.537.png
[ref187]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.538.png
[ref188]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.539.png
[ref189]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.540.png
[ref190]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.541.png
[ref191]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.542.png
[ref192]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.543.png
[ref193]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.545.png
[ref194]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.547.png
[ref195]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.548.png
[ref196]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.549.png
[ref197]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.550.png
[ref198]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.551.png
[ref199]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.552.png
[ref200]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.554.png
[ref201]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.556.png
[ref202]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.557.png
[ref203]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.558.png
[ref204]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.559.png
[ref205]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.560.png
[ref206]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.561.png
[ref207]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.562.png
[ref208]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.563.png
[ref209]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.564.png
[ref210]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.565.png
[ref211]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.566.png
[ref212]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.568.png
[ref213]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.569.png
[ref214]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.571.png
[ref215]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.572.png
[ref216]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.573.png
[ref217]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.574.png
[ref218]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.576.png
[ref219]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.578.png
[ref220]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.579.png
[ref221]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.580.png
[ref222]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.581.png
[ref223]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.582.png
[ref224]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.584.png
[ref225]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.585.png
[ref226]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.586.png
[ref227]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.587.png
[ref228]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.589.png
[ref229]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.590.png
[ref230]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.591.png
[ref231]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.592.png
[ref232]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.593.png
[ref233]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.594.png
[ref234]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.595.png
[ref235]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.596.png
[ref236]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.597.png
[ref237]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.599.png
[ref238]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.600.png
[ref239]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.601.png
[ref240]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.602.png
[ref241]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.603.png
[ref242]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.604.png
[ref243]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.605.png
[ref244]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.606.png
[ref245]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.607.png
[ref246]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.610.png
[ref247]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.611.png
[ref248]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.612.png
[ref249]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.613.png
[ref250]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.619.png
[ref251]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.628.png
[ref252]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.645.png
[ref253]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.646.png
[ref254]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.649.png
[ref255]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.653.png
[ref256]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.654.png
[ref257]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.655.png
[ref258]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.656.png
[ref259]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.658.png
[ref260]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.659.png
[ref261]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.660.png
[ref262]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.662.png
[ref263]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.663.png
[ref264]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.666.png
[ref265]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.667.png
[ref266]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.673.png
[ref267]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.674.png
[ref268]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.677.png
[ref269]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.678.png
[ref270]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.680.png
[ref271]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.682.png
[ref272]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.690.png
[ref273]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.695.png
[ref274]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.699.png
[ref275]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.703.png
[ref276]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.705.png
[ref277]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.711.png
[ref278]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.714.png
[ref279]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.718.png
[ref280]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.719.png
[ref281]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.721.png
[ref282]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.722.png
[ref283]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.723.png
[ref284]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.724.png
[ref285]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.725.png
[ref286]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.726.png
[ref287]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.727.png
[ref288]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.728.png
[ref289]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.729.png
[ref290]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.730.png
[ref291]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.731.png
[ref292]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.732.png
[ref293]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.733.png
[ref294]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.737.png
[ref295]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.742.png
[ref296]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.748.png
[ref297]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.752.png
[ref298]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.753.png
[ref299]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.755.png
[ref300]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.756.png
[ref301]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.757.png
[ref302]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.767.png
[ref303]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.768.png
[ref304]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.771.png
[ref305]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.776.png
[ref306]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.777.png
[ref307]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.778.png
[ref308]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.780.png
[ref309]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.781.png
[ref310]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.782.png
[ref311]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.783.png
[ref312]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.784.png
[ref313]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.787.png
[ref314]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.793.png
[ref315]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.794.png
[ref316]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.795.png
[ref317]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.796.png
[ref318]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.797.png
[ref319]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.799.png
[ref320]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.802.png
[ref321]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.804.png
[ref322]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.805.png
[ref323]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.809.png
[ref324]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.811.png
[ref325]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.812.png
[ref326]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.825.png
[ref327]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.827.png
[ref328]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.831.png
[ref329]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.836.png
[ref330]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.838.png
[ref331]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.839.png
[ref332]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.840.png
[ref333]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.841.png
[ref334]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.842.png
[ref335]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.843.png
[ref336]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.844.png
[ref337]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.845.png
[ref338]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.846.png
[ref339]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.848.png
[ref340]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.849.png
[ref341]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.850.png
[ref342]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.851.png
[ref343]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.852.png
[ref344]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.853.png
[ref345]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.854.png
[ref346]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.855.png
[ref347]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.856.png
[ref348]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.857.png
[ref349]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.858.png
[ref350]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.859.png
[ref351]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.860.png
[ref352]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.865.png
[ref353]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.866.png
[ref354]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.867.png
[ref355]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.869.png
[ref356]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.870.png
[ref357]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.871.png
[ref358]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.872.png
[ref359]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.873.png
[ref360]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.900.png
[ref361]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.901.png
[ref362]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.905.png
[ref363]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.906.png
[ref364]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.912.png
[ref365]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.917.png
[ref366]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.925.png
[ref367]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.926.png
[ref368]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.950.png
[ref369]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.953.png
[ref370]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.964.png
[ref371]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.971.png
[ref372]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.972.png
[ref373]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.982.png
[ref374]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.999.png
[ref375]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1003.png
[ref376]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1004.png
[ref377]: Aspose.Words.e8c6e093-f335-4daf-aa6b-45b8db784a6f.1018.png
