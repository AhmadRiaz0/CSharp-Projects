Application "Currency Converter"

A Windows Forms application that converts an entered amount in euros to a selected foreign currency. It uses an array of structures representing multiple currencies with their names, exchange rates, and symbols.

Main Features:
- Input an amount in euros
- Select a foreign currency from a dropdown list
- Automatic conversion of the amount from euros to the selected currency
- Display of:
  - the exchange rate
  - the currency symbol
  - the converted result

Supported Currencies:

| Currency              | Rate (per €1)   | Symbol |
|-----------------------|-----------------|--------|
| US Dollar             | 1.0502          | $      |
| Swiss Franc           | 0.9376          | CHF    |
| Australian Dollar     | 1.6526          | $      |
| Pakistani Rupee       | 291.6432        | Rs     |
| Saudi Riyal           | 3.9417          | ﷼      |
| British Pound         | 0.8321          | £      |

Technologies Used:
- Language: C#
- UI Framework: Windows Forms (WinForms)
- IDE: Visual Studio

How to Use:
1. Open the 'convertisseurMonnaies.sln' project in Visual Studio.
2. Click 'Start' (or press F5) to launch the application.
3. Enter an amount in euros into the input field.
4. Select a currency from the dropdown list.
5. The converted amount, exchange rate, and symbol will be displayed automatically.

Conversion Logic:
float euro = float.Parse(txtEuro.Text);
float conversion = euro * tMonnaie[cboMonnaie.SelectedIndex].valeur;

Error Handling:
If the input amount in euros is invalid (non-numeric), the field is cleared and the cursor is automatically repositioned.
