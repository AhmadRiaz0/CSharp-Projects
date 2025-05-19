# 📁 Application "Manipulation de Liste"

Cette application Windows Forms permet à l'utilisateur de **sélectionner un dossier**, d'en **afficher les fichiers**, puis de **copier** certains ou tous ces fichiers dans une **liste de sélection**. L'utilisateur peut ensuite **ajouter, supprimer ou vider** la liste de sélection selon ses besoins.

---

## ⚙️ Fonctionnalités principales

- 📂 Sélection d’un dossier sur le disque
- 📝 Affichage de tous les fichiers contenus dans ce dossier
- ➡️ Ajout d’un ou de tous les fichiers à une liste de sélection
- ❌ Suppression d’un élément de la liste de sélection
- 🧹 Effacement complet de la sélection
- 🔄 Mise à jour automatique des compteurs de fichiers

---

## 🖼️ Interface utilisateur

- **lstFichier** : liste contenant les fichiers du dossier sélectionné
- **lstSelection** : liste contenant les fichiers sélectionnés par l'utilisateur
- **btnRechercher** : bouton pour choisir un dossier à l’aide d’une boîte de dialogue
- **>> / >** : boutons pour ajouter tous les fichiers ou un fichier sélectionné à la liste de sélection
- **DEL** : bouton pour supprimer un fichier de la sélection
- **Clear All** : bouton pour vider la liste de sélection
- **lblNbFichiers** / **lblNbSelection** : étiquettes indiquant le nombre de fichiers présents dans chaque liste

---

## 🛠️ Technologies utilisées

- 👨‍💻 Langage : **C#**
- 🖥️ Framework : **Windows Forms**
- 🧰 IDE recommandé : **Visual Studio**

---

## ▶️ Comment l’utiliser

1. Ouvre le projet `manipulationDeListe.sln` avec **Visual Studio**.
2. Clique sur **Démarrer** ou appuie sur `F5` pour exécuter l'application.
3. Clique sur **Rechercher** pour choisir un dossier contenant des fichiers.
4. Utilise les flèches pour ajouter des fichiers à ta sélection.
5. Supprime ou efface ta sélection selon tes besoins.

---

## 🔒 Contraintes

- Aucune duplication n’est autorisée dans la liste de sélection.
- Le nombre de fichiers est automatiquement mis à jour à chaque action.


