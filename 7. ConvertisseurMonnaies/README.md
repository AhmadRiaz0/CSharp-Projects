# 💱 Application "Convertisseur de Monnaies"

Cette application Windows Forms permet de convertir un montant saisi en **euros** vers une **monnaie étrangère** choisie dans une liste. Elle repose sur un tableau de structures représentant plusieurs devises avec leurs noms, taux de conversion et symboles.

---

## ⚙️ Fonctionnalités principales

- 💶 Saisie d’un montant en euros
- 🌐 Sélection d’une devise étrangère dans une liste déroulante
- 🔁 Conversion automatique du montant en euros vers la devise choisie
- 💹 Affichage :
  - du taux de change
  - du symbole monétaire
  - du résultat converti

---

## 🌍 Devises intégrées

| Monnaie               | Taux (pour 1 €) | Symbole |
|-----------------------|-----------------|---------|
| Dollar américain      | 1.0502          | $       |
| Franc suisse          | 0.9376          | CHF     |
| Dollar australien     | 1.6526          | $       |
| Roupie pakistanaise   | 291.6432        | Rs      |
| Riyal saoudien        | 3.9417          | ﷼       |
| Livre sterling        | 0.8321          | £       |

---

## 🧰 Technologies utilisées

- 👨‍💻 Langage : **C#**
- 🖥️ Framework : **Windows Forms**
- 🧰 IDE : **Visual Studio**

---

## ▶️ Utilisation

1. Ouvre le projet `convertisseurMonnaies.sln` avec **Visual Studio**.
2. Clique sur **Démarrer** (`F5`) pour lancer l’application.
3. Saisis un montant en euros dans le champ prévu.
4. Choisis une devise dans la liste déroulante.
5. Le montant converti, le taux de change et le symbole s’afficheront automatiquement.

---

## 🧠 Logique de conversion

```csharp
float euro = float.Parse(txtEuro.Text);
float conversion = euro * tMonnaie[cboMonnaie.SelectedIndex].valeur;

---

## 🛡️ Gestion des erreurs
Si la saisie du montant en euro est invalide (non numérique), le champ est vidé et le curseur est repositionné automatiquement.