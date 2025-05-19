# 🛡️ Projet Encapsulation - Gestion de Personnages

Cette application Windows Forms illustre le concept d’**encapsulation** en programmation orientée objet à travers une gestion simple de personnages.

---

## 📚 Objectif

- Apprendre à **cacher** les données sensibles via des attributs privés.
- Utiliser des **méthodes GET/SET** pour accéder et modifier ces données.
- Manipuler un tableau dynamique de personnages avec leurs propriétés encapsulées.

---

## 🧩 Fonctionnalités

- Création d’un personnage avec un login saisi par l’utilisateur.
- Chaque personnage possède une **vie** initialisée aléatoirement entre 0 et 4.
- Affichage des personnages avec leur login et leur vie dans une liste.
- Sélection d’un personnage dans la liste pour modifier sa vie via un contrôle numérique.
- Indication automatique du personnage ayant la **vie maximale**.
- Affichage d’un message spécifique si un personnage est **mort** (vie = 0).

---

## 🛠️ Technologies

- Langage : C#
- Plateforme : Windows Forms (.NET Framework)
- Concepts : Encapsulation, classes, propriétés privées, collections

---

## ⚙️ Utilisation

1. Saisir un login dans le champ prévu et appuyer sur **Entrée** pour créer un personnage.
2. Le personnage est ajouté à la liste avec sa vie affichée.
3. Sélectionner un personnage dans la liste pour modifier sa vie avec la zone numérique.
4. Observer la mise à jour en temps réel des informations et du personnage avec la vie maximale.

---

## 💡 Concepts clés

- **Encapsulation** : les attributs `login` et `vie` sont privés et accessibles uniquement via méthodes publiques.
- **Tableau d’objets** : stockage des personnages dans un tableau.
- **Gestion de l’interface graphique** : mise à jour dynamique des contrôles selon les actions utilisateur.
