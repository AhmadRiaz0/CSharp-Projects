# ✖️🧠 Application "Tables de Multiplication"

Cette application pédagogique Windows Forms permet de tester ses connaissances sur les **tables de multiplication** via une série de 20 questions générées aléatoirement.

---

## 🎯 Objectif

Permettre à un utilisateur (élève, étudiant, ou toute personne souhaitant réviser) de s'entraîner en répondant à des questions aléatoires portant sur les multiplications simples (de 1 à 9).

---

## ⚙️ Fonctionnalités

- 🔢 Génération de questions aléatoires (entre 1 × 1 et 9 × 9)
- 🎯 Saisie de la réponse avec retour immédiat (vert pour correct, rouge pour incorrect)
- 📈 Suivi de la **note** en temps réel
- ✅ Affichage de la **bonne réponse** en cas d’erreur
- 🔁 Possibilité de **relancer un nouveau test** à tout moment
- ➡️ Bouton **"Suivante"** pour passer à la question suivante

---

## 🧠 Déroulement du test

1. Une multiplication aléatoire est générée.
2. L'utilisateur saisit sa réponse dans le champ prévu.
3. À la validation (`Entrée`), l’application :
   - Vérifie la réponse.
   - Affiche la bonne réponse si nécessaire.
   - Met à jour la note et l’avancement.
4. Après 20 questions, le bouton "Recommencer" prend le relais.

---

## 📊 Suivi de progression

- **Note actuelle** : nombre de bonnes réponses
- **Total de questions posées** : compteur visible
- Feedback immédiat par couleur :
  - ✅ Vert : bonne réponse
  - ❌ Rouge : mauvaise réponse + correction affichée

---

## 🧰 Technologies utilisées

- 👨‍💻 Langage : **C#**
- 🖥️ Framework : **Windows Forms**
- 🧰 IDE : **Visual Studio**

---

## ▶️ Lancer l'application

1. Ouvre le projet `tablesMultiplication.sln` dans Visual Studio.
2. Clique sur **Démarrer** (`F5`).
3. Commence à t’entraîner !

---

## ✨ Améliorations possibles

- Ajout d’un **minuteur** par question
- **Historique** des scores
- Sélection de **niveaux de difficulté**
- Affichage d’un **bilan final** plus détaillé



