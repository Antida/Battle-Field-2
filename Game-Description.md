Game "Battle Field"
====================================
Your task is to write an interactive console-based implementation of the game "Battle Field" in which the player tries to
clean a matrix of numbers and empty cells by series of explosions, which detonate areas of different sizes. 
At the start of the game, the program should read the size of the battlefieldn and should generate a random battlefield: 
a matrix of size n x n (1 ≤n≤ 10). Each cell of the matrix should be initially filled with a random number in the range 
[1..5\] (donating a mine of some size) or with an empty cell "-". The number mines should be between 15% and 30% of the 
cells in the battlefield. At each step, the player enters two coordinates row and col and depending on the number in 
the cell at the specified position {row, col} the computer detonates an area of the matrix. The detonated areas depend 
on the size of the detonated mine and follow the patterns below:

<img src="http://i.imgur.com/wzoNKJN.png?1"></img>

Write a program that simulates the "Battle Field" game. The game should print the battlefield and sequentially read 
coordinates and perform detonations at the specified positions. If an empty or already detonated position or invalid 
cell is specified, print "Invalid move!". Otherwise, detonate the specified mine, and print the battlefield after the 
explosion. When a mine is detonated, it destroys all mines inside its detonated area without causing chained explosions. 
Visualize the mines as numbers, the empty cells as "-" and the detonated cells as "X". The game finishes when all mines 
are detonated. After the game is finished, you should print the total number of mines detonated by the player.

Rows are numbered from up to down (starting from 0) and columns are numbered from left to right (starting from 0). Coordinates are given in format row number followed by space followed by column number. Some players could try to cheat by entering illegal moves, so be cautious.

### Example Game Session
The player's input is shown in italic:

<img src="http://i.imgur.com/TxeOHmp.png?1"></img>

Some players could try to cheat by entering illegal moves, so be cautious and prevent illegal input.


