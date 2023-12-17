## Objectifs du Projet 
### Créer des endpoints pour gérer les opérations CRUD.
Utiliser la technique de File upload dans une API Web.
Utiliser les classes DTO pour le découplage des données.
Utiliser AutoMapper pour le mapping des objets.
Configurer Swagger pour la documentation de l'API.
### Étapes pour le déploiement
#### 1. Création des classes de domaine
Créez les classes Genre et Movie dans le dossier Models pour représenter les films et les genres.
#### 2. Installation des packages EF Core
Ouvrez Visual Studio 2022 et créez un projet de type Application web ASP.NET Core Web API.
Installez les packages NuGet nécessaires pour EF Core dans votre application.
#### 3. Création de la classe de contexte
Créez la classe ApplicationDbContext pour la connexion à la base de données.
#### 4. Inscription du service de contexte et création de la base de données
Dans le fichier Program.cs, inscrivez le service de contexte.
Lancez une migration Entity Framework et créez la base de données via la console du Gestionnaire de packages.
#### 5. Création des services Repository
Ajoutez les interfaces IGenresService et IMoviesService ainsi que leurs implémentations pour gérer les genres et les films.
#### 6. Classes DTO
Créez des classes DTO pour renvoyer les données à la couche de présentation et masquer les propriétés sensibles.
#### 7. Utilisation de AutoMapper
Installez le package AutoMapper via NuGet.
Créez un profil de mapping dans une classe MappingProfile pour définir les opérations de mapping entre les objets.
#### 8. Configuration de Swagger
Installez le package Swashbuckle.AspNetCore via NuGet.
Configurez Swagger dans le fichier Program.cs pour documenter votre API.
#### 9. Activation du service CORS
#### 10. Activez le service CORS pour débloquer l'accès à l'API depuis une application cliente.
# Output Capture 
![image](https://github.com/RyhabElmoncer/WEBAPI/assets/126770762/3093799e-2db2-41a3-9cc8-59d295b132c7)

![image](https://github.com/RyhabElmoncer/WEBAPI/assets/126770762/fefda9e3-9138-4996-902b-cb8bf402997d)
![image](https://github.com/RyhabElmoncer/WEBAPI/assets/126770762/0dd6e222-4548-4702-a088-8f0408270a54)

