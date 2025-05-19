Application "Manipulation de Liste"

A Windows Forms application that allows users to select a folder, display its files, and copy some or all of them into a selection list. The user can then add, remove, or clear items from the selection as needed.

Main Features:
- Select a folder from the disk
- Display all files in the selected folder
- Add one or all files to a selection list
- Remove an item from the selection list
- Clear the entire selection
- Automatically update file counters

User Interface:
- lstFichier: list displaying files from the selected folder
- lstSelection: list displaying the user's selected files
- btnRechercher: button to choose a folder using a dialog box
- >> / >: buttons to add all files or a selected file to the selection list
- DEL: button to remove a file from the selection
- Clear All: button to clear the selection list
- lblNbFichiers / lblNbSelection: labels showing the number of files in each list

Technologies Used:
- Language: C#
- UI Framework: Windows Forms (WinForms)
- Recommended IDE: Visual Studio

How to Use:
1. Open the 'manipulationDeListe.sln' project in Visual Studio.
2. Click 'Start' or press F5 to run the application.
3. Click 'Rechercher' to choose a folder containing files.
4. Use the arrow buttons to add files to your selection.
5. Remove or clear the selection as needed.

Constraints:
- No duplicate files are allowed in the selection list.
- File counters are updated automatically after each action.
