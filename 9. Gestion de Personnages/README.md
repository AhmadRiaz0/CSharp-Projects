Project "Encapsulation - Character Management"

A Windows Forms application demonstrating the concept of **encapsulation** in object-oriented programming through simple character management.

Objective:
- Learn to **hide** sensitive data using private attributes.
- Use **GET/SET methods** to access and modify this data.
- Handle a dynamic array of characters with encapsulated properties.

Features:
- Create a character with a user-entered login.
- Each character has a **life** value randomly initialized between 0 and 4.
- Display characters with their login and life in a list.
- Select a character from the list to modify their life using a numeric control.
- Automatically indicate the character with the **maximum life**.
- Display a specific message if a character is **dead** (life = 0).

Technologies:
- Language: C#
- Platform: Windows Forms (.NET Framework)
- Concepts: Encapsulation, classes, private properties, collections

Usage:
1. Enter a login in the input field and press **Enter** to create a character.
2. The character is added to the list with their life displayed.
3. Select a character from the list to modify their life using the numeric control.
4. Observe real-time updates of information and the character with the highest life.

Key Concepts:
- **Encapsulation**: the `login` and `life` attributes are private and accessible only via public methods.
- **Object array**: storing characters in an array.
- **GUI management**: dynamic update of controls based on user actions.
