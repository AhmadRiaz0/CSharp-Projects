# PolymorphismeAbstraction

## Description

Ce projet est une application Windows Forms en C# qui démontre les concepts de **polymorphisme** et **abstraction** en programmation orientée objet.

Le programme permet de gérer une liste de personnages de types différents (`Humain` et `Xmen`), tous dérivés d’une classe abstraite `Personnage`.

Chaque personnage possède un **login** (nom) et des caractéristiques propres à son type :  
- `Humain` a un attribut `vie` (int).  
- `Xmen` a un attribut `pouvoir` (string).

---

## Fonctionnalités principales

- Ajouter un personnage humain ou un xmen via l’interface utilisateur.  
- Gestion dynamique des propriétés spécifiques (vie ou pouvoir) selon le type choisi.  
- Affichage des informations des personnages avec polymorphisme (méthode `info()` redéfinie dans chaque sous-classe).  
- Mise à jour de la liste affichée avec les détails de chaque personnage.

---

## Structure du projet

- **Classe abstraite `Personnage`** :  
  - Attribut protégé `login` (string).  
  - Méthode abstraite `info()` à implémenter dans les sous-classes.

- **Sous-classe `Humain`** :  
  - Attribut privé `vie` (int).  
  - Constructeurs avec ou sans login.  
  - Redéfinition de la méthode `info()` pour afficher `login` et `vie`.

- **Sous-classe `Xmen`** :  
  - Attribut privé `pouvoir` (string).  
  - Constructeurs avec ou sans login.  
  - Redéfinition de la méthode `info()` pour afficher `login` et `pouvoir`.

- **Formulaire `Form1`** :  
  - Gestion de l’interface utilisateur (boutons, liste, champs texte, radiobuttons, numericUpDown, comboBox).  
  - Ajout de personnages dans un tableau `Personnage[]`.  
  - Mise à jour de la liste affichée.  
  - Gestion de la visibilité des contrôles selon le type de personnage choisi.

---

## Utilisation

1. Démarrer l’application.  
2. Choisir le type de personnage (Humain ou Xmen) via les boutons radio.  
3. Saisir un login (optionnel).  
4. Si Humain, définir la vie via le contrôle numérique.  
   Si Xmen, choisir un pouvoir dans la liste déroulante.  
5. Cliquer sur **Ajouter** pour créer et ajouter le personnage à la liste.  
6. La liste s’actualise automatiquement avec les informations des personnages.

---

## Remarques

- Le tableau `lesPersonnages` est limité à 100 entrées.  
- L’attribut `login` est optionnel. Si vide, le personnage est créé avec un login par défaut.  
- La méthode `info()` illustre bien le polymorphisme : la même méthode renvoie une information différente selon la sous-classe.

---

## Améliorations possibles

- Remplacer le tableau par une collection dynamique (`List<Personnage>`).  
- Ajouter la suppression ou la modification des personnages.  
- Validation avancée des entrées utilisateur.  
- Sauvegarde des personnages dans un fichier.
