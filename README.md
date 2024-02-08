# Gestion de Stock

Ce projet vise à créer une petite application en console de gestion de stock en utilisant les collections de type Liste en C#.

## Objectif

L'objectif principal de ce projet est de manipuler les collections de type Liste en développant une application pour la gestion d'un stock. Chaque article est caractérisé par son numéro de référence, son nom, son prix de vente et une quantité en stock.

## Fonctionnalités

L'application offre les fonctionnalités suivantes :

- **Recherche d'article par référence :** Permet de trouver un article en entrant sa référence.
- **Ajout d'article au stock :** Ajoute un nouvel article au stock en vérifiant l'unicité de la référence.
- **Suppression d'article par référence :** Supprime un article du stock en utilisant sa référence.
- **Modification d'article par référence :** Modifie les détails d'un article existant en utilisant sa référence.
- **Recherche d'article par nom :** Permet de rechercher un article en entrant son nom.
- **Recherche d'article par intervalle de prix de vente :** Affiche tous les articles dont le prix de vente se situe dans un intervalle donné.
- **Affichage de tous les articles :** Affiche la liste complète de tous les articles présents dans le stock.
- **Quitter :** Permet de quitter l'application.

## Structure du Projet

- **Article.cs :** Contient la définition de la classe Article avec ses attributs, son constructeur et sa méthode ToString().
- **Program.cs :** Contient la logique principale de l'application, y compris la création du stock et l'implémentation du menu.




