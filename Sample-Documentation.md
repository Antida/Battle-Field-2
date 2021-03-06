## Sample Refactoring Documentation for Project "Game 15"

1. **Redesigned the project structure**:
  - Renamed the project to Game-15.
  - Renamed the main class Program to GameFifteen.
  - Extracted each class in a separate file with a good name: GameFifteen.cs, Board.cs, Point.cs.
  - ... 

2. **Reformatted the source code:**
  - Removed all unneeded empty lines, e.g. in the method PlayGame().
  - Inserted empty lines between the methods.
  - Split the lines containing several statements into several simple lines, e.g.:
  <img src="http://i.imgur.com/l3LeDI3.png?1"></img>
  - Formatted the curly braces { and } according to the best practices for the C# language
  - Put { and } after all conditionals and loops (when missing).
  - Character casing: variables and fields made camelCase; types and methods made PascalCase
` - Formatted all other elements of the source code according to the best practices introduced in the course "High-Quality Programming Code".
  - …
3. **Renamed variables**:
  - In class **Fifteen: number ➔ numberOfMoves**.
  - In Main(string[] args): g ➔ gameFifteen**.
4. **Introduced constants:**
GameBoardSize = 4
ScoreBoardSize = 5
5. **Extracted the method** GenerateRandomGame() from the method Main().
6. **Introduced class** ScoreBoard and moved all related functionality in it.
7. Moved method GenerateRandomNumber(int start, int end) to separate class RandomUtils.
8. …
