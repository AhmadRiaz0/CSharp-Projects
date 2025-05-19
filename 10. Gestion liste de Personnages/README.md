# PolymorphismAbstraction

## Description

This project is a C# Windows Forms application that demonstrates the concepts of **polymorphism** and **abstraction** in object-oriented programming.

The program manages a list of characters of different types (`Human` and `Xmen`), all derived from an abstract class `Character`.

Each character has a **login** (name) and specific attributes depending on its type:  
- `Human` has an attribute `life` (int).  
- `Xmen` has an attribute `power` (string).

---

## Main Features

- Add a human or xmen character via the user interface.  
- Dynamic handling of specific properties (life or power) based on the selected type.  
- Display character information using polymorphism (the `info()` method is overridden in each subclass).  
- Update the displayed list with details of each character.

---

## Project Structure

- **Abstract class `Character`**:  
  - Protected attribute `login` (string).  
  - Abstract method `info()` to be implemented in subclasses.

- **Subclass `Human`**:  
  - Private attribute `life` (int).  
  - Constructors with or without login.  
  - Override of `info()` method to display `login` and `life`.

- **Subclass `Xmen`**:  
  - Private attribute `power` (string).  
  - Constructors with or without login.  
  - Override of `info()` method to display `login` and `power`.

- **Form `Form1`**:  
  - Manages the user interface (buttons, list, text fields, radio buttons, numericUpDown, comboBox).  
  - Adds characters into a `Character[]` array.  
  - Updates the displayed list.  
  - Manages visibility of controls depending on the selected character type.

---

## Usage

1. Start the application.  
2. Choose the character type (Human or Xmen) via radio buttons.  
3. Enter a login (optional).  
4. If Human, set life using the numeric control.  
   If Xmen, select a power from the dropdown list.  
5. Click **Add** to create and add the character to the list.  
6. The list updates automatically with character details.

---

## Notes

- The `characters` array is limited to 100 entries.  
- The `login` attribute is optional. If left empty, a default login is assigned.  
- The `info()` method illustrates polymorphism well: the same method returns different information depending on the subclass.

---

## Possible Improvements

- Replace the fixed array with a dynamic collection (`List<Character>`).  
- Add character deletion or modification features.  
- Advanced input validation.  
- Save characters to a file.
