# CoursSupDeVinci

CoursSupDeVinci est un projet en C# conçu pour gérer et traiter des données liées à un environnement scolaire. Il inclut des fonctionnalités pour la gestion des personnes, des classes, ainsi que l'intégration d'une base de données avec Entity Framework Core.

## Fonctionnalités

- **Gestion des personnes** : Récupérer toutes les personnes ou filtrer par des critères spécifiques (ex. : personnes de Nantes).
- **Gestion des classes** : Créer et gérer des classes avec les personnes associées.
- **Import CSV** : Charger des données à partir de fichiers CSV pour alimenter la base de données.
- **Intégration base de données** : Utilise PostgreSQL avec Entity Framework Core pour la persistance des données.
- **Requêtes LINQ** : Effectuer des requêtes avancées sur les données, comme le calcul de moyennes ou des filtres conditionnels.

## Technologies utilisées

- **Langage** : C#
- **Frameworks** : .NET, Entity Framework Core
- **Base de données** : PostgreSQL
- **Injection de dépendances** : Microsoft.Extensions.DependencyInjection
- **Configuration** : Microsoft.Extensions.Configuration
- **Gestion des fichiers** : Parsing de fichiers CSV

## Structure du projet

- `Data/` : Contient les interfaces et implémentations des dépôts pour les opérations sur la base de données.
- `Model/` : Définit les modèles de données (ex. : `Person`, `Detail`, `Classe`).
- `Utils/` : Classes utilitaires pour des opérations courantes (ex. : conversions de dates).
- `Program.cs` : Point d'entrée de l'application, incluant la configuration des services et la logique d'exécution.

## Prise en main

### Prérequis

- .NET 6.0 ou version ultérieure
- Base de données PostgreSQL
- Un fichier `appsettings.json` valide avec la structure suivante :
  ```json
  {
    "ConnectionStrings": {
      "DefaultConnection": "Host=localhost;Database=VotreBase;Username=VotreUtilisateur;Password=VotreMotDePasse"
    },
    "CSVFiles": {
      "CoursSupDeVinci": "/chemin/vers/votre/fichier.csv"
    }
  }