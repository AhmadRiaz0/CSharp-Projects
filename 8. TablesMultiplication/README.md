Application "Multiplication Tables"

An educational Windows Forms application that tests knowledge of multiplication tables through a series of 20 randomly generated questions.

Objective:
Allow users (students or anyone wishing to practice) to train by answering random questions on simple multiplications (from 1 × 1 to 9 × 9).

Features:
- Random question generation (between 1 × 1 and 9 × 9)
- Answer input with immediate feedback (green for correct, red for incorrect)
- Real-time score tracking
- Display of the correct answer if the user is wrong
- Ability to restart the test at any time
- "Next" button to move to the following question

Test Flow:
1. A random multiplication question is generated.
2. The user enters their answer.
3. Upon validation (Enter key), the app:
   - Checks the answer
   - Shows the correct answer if necessary
   - Updates the score and progress
4. After 20 questions, the "Restart" button appears.

Progress Tracking:
- Current score: number of correct answers
- Total questions asked: visible counter
- Immediate feedback by color:
  - ✅ Green: correct answer
  - ❌ Red: wrong answer + correction displayed

Technologies Used:
- Language: C#
- UI Framework: Windows Forms (WinForms)
- IDE: Visual Studio

How to Run:
1. Open the 'tablesMultiplication.sln' project in Visual Studio.
2. Click 'Start' (F5).
3. Start practicing!

Possible Improvements:
- Add a timer per question
- Score history
- Difficulty level selection
- More detailed final report
