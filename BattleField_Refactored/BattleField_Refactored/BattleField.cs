namespace BattleField
{
    using System;

    public class BattleField
    {
        public static int fieldSize = 0;
        public int detonatedMines = 0;
        public string[,] field = new string[fieldSize, fieldSize];

        public BattleField()
        {
        }

        public void InitField()
        {
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    this.field[i, j] = " - ";
                }
            }
        }

        public void DisplayField()
        {
            // Top side numbers
            Console.Write("   ");
            for (int i = 0; i < fieldSize; i++)
            {
                Console.Write(" " + i.ToString() + "  ");
            }

            Console.Write("    ");
            for (int i = 0; i < (4 * fieldSize) - 3; i++)
            {
                Console.Write("-");
            }

            for (int i = 0; i < fieldSize; i++)
            {
                // Left side numbers
                Console.Write(i.ToString() + "|");
                for (int j = 0; j < fieldSize; j++)
                {
                    Console.Write(" " + this.field[i, j].ToString());
                }
            }
        }

        public void InitMines()
        {
            // Tuka ne sym siguren kakvo tochno pravq ama pyk raboti
            int minesDownLimit = Convert.ToInt32(0.15 * fieldSize * fieldSize);
            int minesUpperLimit = Convert.ToInt32(0.30 * fieldSize * fieldSize);
            int tempMineXCoordinate;
            int tempMineYCoordinate;
            bool flag = true;
            Random rnd = new Random();

            int minesCount = Convert.ToInt32(rnd.Next(minesDownLimit, minesUpperLimit));
            int[,] minesPositions =

                new int[minesCount, minesCount];
            Console.WriteLine("mines count is: " + minesCount);

            for (int i = 0; i < minesCount; i++)
            {
                do
                {
                    // Tuka cikyla se vyrti dokato flag ne e false
                    // S do-while raboti po dobre
                    tempMineXCoordinate =
                        Convert.ToInt32(rnd.Next(0, fieldSize - 1));
                    tempMineYCoordinate =
                        Convert.ToInt32(rnd.Next(0, fieldSize - 1));
                    if (this.field[tempMineXCoordinate, tempMineYCoordinate] == " - ")
                    {
                        this.field[tempMineXCoordinate, tempMineYCoordinate] = " " + Convert.ToString(rnd.Next(1, 6) + " ");
                    }
                    else
                    {
                        flag = false;
                    }
                }
                while (flag);
            }
        }

        // Tuka sa mogyshtite metodi za gyrmejite
        public void DetonateMine1(int xCoord, int yCoord)
        {
            if ((xCoord - 1 >= 0) && (xCoord - 1 < fieldSize) && (yCoord - 1 >= 0) && (yCoord - 1 < fieldSize))
            {
                this.field[xCoord - 1, yCoord - 1] = " X ";
            }

            if ((xCoord - 1 >= 0) && (xCoord - 1 < fieldSize) && (yCoord + 1 >= 0) && (yCoord + 1 < fieldSize))
            {
                this.field[xCoord - 1, yCoord + 1] = " X ";
            }

            if ((xCoord + 1 >= 0) && (xCoord + 1 < fieldSize) && (yCoord - 1 >= 0) && (yCoord - 1 < fieldSize))
            {
                this.field[xCoord + 1, yCoord - 1] = " X ";
            }

            if ((xCoord + 1 >= 0) && (xCoord + 1 < fieldSize) && (yCoord + 1 >= 0) && (yCoord + 1 < fieldSize))
            {
                this.field[xCoord + 1, yCoord + 1] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord, yCoord] = " X ";
            }
        }

        public void DetonateMine2(int xCoord, int yCoord)
        {
            if ((xCoord - 1 >= 0) && (xCoord - 1 < fieldSize) && (yCoord - 1 >= 0) && (yCoord - 1 < fieldSize))
            {
                this.field[xCoord - 1, yCoord - 1] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord - 1 >= 0) && (yCoord - 1 < fieldSize))
            {
                this.field[xCoord, yCoord - 1] = " X ";
            }

            if ((xCoord + 1 >= 0) && (xCoord + 1 < fieldSize) && (yCoord - 1 >= 0) && (yCoord - 1 < fieldSize))
            {
                this.field[xCoord + 1, yCoord - 1] = " X ";
            }

            if ((xCoord - 1 >= 0) && (xCoord - 1 < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord - 1, yCoord] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord, yCoord] = " X ";
            }

            if ((xCoord + 1 >= 0) && (xCoord + 1 < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord + 1, yCoord] = " X ";
            }

            if ((xCoord - 1 >= 0) && (xCoord - 1 < fieldSize) && (yCoord + 1 >= 0) && (yCoord + 1 < fieldSize))
            {
                this.field[xCoord - 1, yCoord + 1] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord + 1 >= 0) && (yCoord + 1 < fieldSize))
            {
                this.field[xCoord, yCoord + 1] = " X ";
            }

            if ((xCoord + 1 >= 0) && (xCoord + 1 < fieldSize) && (yCoord + 1 >= 0) && (yCoord + 1 < fieldSize))
            {
                this.field[xCoord + 1, yCoord + 1] = " X ";
            }
        }

        public void DetonateMine3(int xCoord, int yCoord)
        {
            if ((xCoord - 2 >= 0) && (xCoord - 2 < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord - 2, yCoord] = " X ";
            }

            if ((xCoord - 1 >= 0) && (xCoord - 1 < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord - 1, yCoord] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord, yCoord] = " X ";
            }

            if ((xCoord + 1 >= 0) && (xCoord + 1 < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord + 1, yCoord] = " X ";
            }

            if ((xCoord + 2 >= 0) && (xCoord + 2 < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord + 2, yCoord] = " X ";
            }

            if ((xCoord - 1 >= 0) && (xCoord - 1 < fieldSize) && (yCoord - 1 >= 0) && (yCoord - 1 < fieldSize))
            {
                this.field[xCoord - 1, yCoord - 1] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord, yCoord] = " X ";
            }

            if ((xCoord + 1 >= 0) && (xCoord + 1 < fieldSize) && (yCoord + 1 >= 0) && (yCoord + 1 < fieldSize))
            {
                this.field[xCoord + 1, yCoord + 1] = " X ";
            }

            if ((xCoord - 1 >= 0) && (xCoord - 1 < fieldSize) && (yCoord + 1 >= 0) && (yCoord + 1 < fieldSize))
            {
                this.field[xCoord - 1, yCoord + 1] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord, yCoord] = " X ";
            }

            if ((xCoord + 1 >= 0) && (xCoord + 1 < fieldSize) && (yCoord - 1 >= 0) && (yCoord - 1 < fieldSize))
            {
                this.field[xCoord + 1, yCoord - 1] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord - 2 >= 0) && (yCoord - 2 < fieldSize))
            {
                this.field[xCoord, yCoord - 2] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord - 1 >= 0) && (yCoord - 1 < fieldSize))
            {
                this.field[xCoord, yCoord - 1] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord, yCoord] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord + 1 >= 0) && (yCoord + 1 < fieldSize))
            {
                this.field[xCoord, yCoord + 1] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord + 2 >= 0) && (yCoord + 2 < fieldSize))
            {
                this.field[xCoord, yCoord + 2] = " X ";
            }
        }

        public void DetonateMine4(int xCoord, int yCoord)
        {
            if ((xCoord - 1 >= 0) && (xCoord - 1 < fieldSize) && (yCoord - 1 >= 0) && (yCoord - 1 < fieldSize))
            {
                this.field[xCoord - 1, yCoord - 1] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord - 1 >= 0) && (yCoord - 1 < fieldSize))
            {
                this.field[xCoord, yCoord - 1] = " X ";
            }

            if ((xCoord + 1 >= 0) && (xCoord + 1 < fieldSize) && (yCoord - 1 >= 0) && (yCoord - 1 < fieldSize))
            {
                this.field[xCoord + 1, yCoord - 1] = " X ";
            }

            if ((xCoord - 1 >= 0) && (xCoord - 1 < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord - 1, yCoord] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord, yCoord] = " X ";
            }

            if ((xCoord + 1 >= 0) && (xCoord + 1 < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord + 1, yCoord] = " X ";
            }

            if ((xCoord - 1 >= 0) && (xCoord - 1 < fieldSize) && (yCoord + 1 >= 0) && (yCoord + 1 < fieldSize))
            {
                this.field[xCoord - 1, yCoord + 1] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord + 1 >= 0) && (yCoord + 1 < fieldSize))
            {
                this.field[xCoord, yCoord + 1] = " X ";
            }

            if ((xCoord + 1 >= 0) && (xCoord + 1 < fieldSize) && (yCoord + 1 >= 0) && (yCoord + 1 < fieldSize))
            {
                this.field[xCoord + 1, yCoord + 1] = " X ";
            }

            if ((xCoord - 1 >= 0) && (xCoord - 1 < fieldSize) && (yCoord + 2 >= 0) && (yCoord + 2 < fieldSize))
            {
                this.field[xCoord - 1, yCoord + 2] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord + 2 >= 0) && (yCoord + 2 < fieldSize))
            {
                this.field[xCoord, yCoord + 2] = " X ";
            }

            if ((xCoord + 1 >= 0) && (xCoord + 1 < fieldSize) && (yCoord + 2 >= 0) && (yCoord + 2 < fieldSize))
            {
                this.field[xCoord + 1, yCoord + 2] = " X ";
            }

            if ((xCoord - 1 >= 0) && (xCoord - 1 < fieldSize) && (yCoord - 2 >= 0) && (yCoord - 2 < fieldSize))
            {
                this.field[xCoord - 1, yCoord - 2] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord - 2 >= 0) && (yCoord - 2 < fieldSize))
            {
                this.field[xCoord, yCoord - 2] = " X ";
            }

            if ((xCoord + 1 >= 0) && (xCoord + 1 < fieldSize) && (yCoord - 2 >= 0) && (yCoord - 2 < fieldSize))
            {
                this.field[xCoord + 1, yCoord - 2] = " X ";
            }

            if ((xCoord - 2 >= 0) && (xCoord - 2 < fieldSize) && (yCoord - 1 >= 0) && (yCoord - 1 < fieldSize))
            {
                this.field[xCoord - 2, yCoord - 1] = " X ";
            }

            if ((xCoord - 2 >= 0) && (xCoord - 2 < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord - 2, yCoord] = " X ";
            }

            if ((xCoord - 2 >= 0) && (xCoord - 2 < fieldSize) && (yCoord + 1 >= 0) && (yCoord + 1 < fieldSize))
            {
                this.field[xCoord - 2, yCoord + 1] = " X ";
            }

            if ((xCoord + 2 >= 0) && (xCoord + 2 < fieldSize) && (yCoord - 1 >= 0) && (yCoord - 1 < fieldSize))
            {
                this.field[xCoord + 2, yCoord - 1] = " X ";
            }

            if ((xCoord + 2 >= 0) && (xCoord + 2 < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord + 2, yCoord] = " X ";
            }

            if ((xCoord + 2 >= 0) && (xCoord + 2 < fieldSize) && (yCoord + 1 >= 0) && (yCoord + 1 < fieldSize))
            {
                this.field[xCoord + 2, yCoord + 1] = " X ";
            }
        }

        public void DetonateMine5(int xCoord, int yCoord)
        {
            if ((xCoord - 1 >= 0) && (xCoord - 1 < fieldSize) && (yCoord - 1 >= 0) && (yCoord - 1 < fieldSize))
            {
                this.field[xCoord - 1, yCoord - 1] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord - 1 >= 0) && (yCoord - 1 < fieldSize))
            {
                this.field[xCoord, yCoord - 1] = " X ";
            }

            if ((xCoord + 1 >= 0) && (xCoord + 1 < fieldSize) && (yCoord - 1 >= 0) && (yCoord - 1 < fieldSize))
            {
                this.field[xCoord + 1, yCoord - 1] = " X ";
            }

            if ((xCoord - 1 >= 0) && (xCoord - 1 < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord - 1, yCoord] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord, yCoord] = " X ";
            }

            if ((xCoord + 1 >= 0) && (xCoord + 1 < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord + 1, yCoord] = " X ";
            }

            if ((xCoord - 1 >= 0) && (xCoord - 1 < fieldSize) && (yCoord + 1 >= 0) && (yCoord + 1 < fieldSize))
            {
                this.field[xCoord - 1, yCoord + 1] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord + 1 >= 0) && (yCoord + 1 < fieldSize))
            {
                this.field[xCoord, yCoord + 1] = " X ";
            }

            if ((xCoord + 1 >= 0) && (xCoord + 1 < fieldSize) && (yCoord + 1 >= 0) && (yCoord + 1 < fieldSize))
            {
                this.field[xCoord + 1, yCoord + 1] = " X ";
            }

            if ((xCoord - 1 >= 0) && (xCoord - 1 < fieldSize) && (yCoord + 2 >= 0) && (yCoord + 2 < fieldSize))
            {
                this.field[xCoord - 1, yCoord + 2] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord + 2 >= 0) && (yCoord + 2 < fieldSize))
            {
                this.field[xCoord, yCoord + 2] = " X ";
            }

            if ((xCoord + 1 >= 0) && (xCoord + 1 < fieldSize) && (yCoord + 2 >= 0) && (yCoord + 2 < fieldSize))
            {
                this.field[xCoord + 1, yCoord + 2] = " X ";
            }

            if ((xCoord - 1 >= 0) && (xCoord - 1 < fieldSize) && (yCoord - 2 >= 0) && (yCoord - 2 < fieldSize))
            {
                this.field[xCoord - 1, yCoord - 2] = " X ";
            }

            if ((xCoord >= 0) && (xCoord < fieldSize) && (yCoord - 2 >= 0) && (yCoord - 2 < fieldSize))
            {
                this.field[xCoord, yCoord - 2] = " X ";
            }

            if ((xCoord + 1 >= 0) && (xCoord + 1 < fieldSize) && (yCoord - 2 >= 0) && (yCoord - 2 < fieldSize))
            {
                this.field[xCoord + 1, yCoord - 2] = " X ";
            }

            if ((xCoord - 2 >= 0) && (xCoord - 2 < fieldSize) && (yCoord - 1 >= 0) && (yCoord - 1 < fieldSize))
            {
                this.field[xCoord - 2, yCoord - 1] = " X ";
            }

            if ((xCoord - 2 >= 0) && (xCoord - 2 < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord - 2, yCoord] = " X ";
            }

            if ((xCoord - 2 >= 0) && (xCoord - 2 < fieldSize) && (yCoord + 1 >= 0) && (yCoord + 1 < fieldSize))
            {
                this.field[xCoord - 2, yCoord + 1] = " X ";
            }

            if ((xCoord + 2 >= 0) && (xCoord + 2 < fieldSize) && (yCoord - 1 >= 0) && (yCoord - 1 < fieldSize))
            {
                this.field[xCoord + 2, yCoord - 1] = " X ";
            }

            if ((xCoord + 2 >= 0) && (xCoord + 2 < fieldSize) && (yCoord >= 0) && (yCoord < fieldSize))
            {
                this.field[xCoord + 2, yCoord] = " X ";
            }

            if ((xCoord + 2 >= 0) && (xCoord + 2 < fieldSize) && (yCoord + 1 >= 0) && (yCoord + 1 < fieldSize))
            {
                this.field[xCoord + 2, yCoord + 1] = " X ";
            }

            if ((xCoord - 2 >= 0) && (xCoord - 2 < fieldSize) && (yCoord - 2 >= 0) && (yCoord - 2 < fieldSize))
            {
                this.field[xCoord - 2, yCoord - 2] = " X ";
            }

            if ((xCoord + 2 >= 0) && (xCoord + 2 < fieldSize) && (yCoord - 2 >= 0) && (yCoord - 2 < fieldSize))
            {
                this.field[xCoord + 2, yCoord - 2] = " X ";
            }

            if ((xCoord - 2 >= 0) && (xCoord - 2 < fieldSize) && (yCoord + 2 >= 0) && (yCoord + 2 < fieldSize))
            {
                this.field[xCoord - 2, yCoord + 2] = " X ";
            }

            if ((xCoord + 2 >= 0) && (xCoord + 2 < fieldSize) && (yCoord + 2 >= 0) && (yCoord + 2 < fieldSize))
            {
                this.field[xCoord + 2, yCoord + 2] = " X ";
            }
        }

        // Tuka se izbira kva bomba da grymne
        public void DetonateMine(int xCoord, int yCoord)
        {
            switch (Convert.ToInt32(this.field[xCoord, yCoord]))
            {
                case 1: this.DetonateMine1(xCoord, yCoord);
                    break;
                case 2: this.DetonateMine2(xCoord, yCoord);
                    break;
                case 3: this.DetonateMine3(xCoord, yCoord);
                    break;
                case 4: this.DetonateMine4(xCoord, yCoord);
                    break;
                case 5: this.DetonateMine5(xCoord, yCoord);
                    break;
            }
        }

        public int CountRemainingMines()
        {
            int count = 0;

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; i < fieldSize; i++)
                {
                    if ((this.field[i, j] != " X ") && (this.field[i, j] != " - "))
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static void Main(string[] args)
        {
            string tempFieldSize;
            Console.WriteLine("Welcome to the Battle Field game");
            do
            {
                Console.Write("Enter battle field size (between 1 and 10): ");
                tempFieldSize = Console.ReadLine();
            } 
            while ((!int.TryParse(tempFieldSize, out fieldSize)) || (fieldSize < 1) || (fieldSize > 10));

            BattleField bf = new BattleField();
            bf.InitField();
            bf.InitMines();
            bf.DisplayField();

            string coordinates;
            int xCoord, yCoord;

            do
            {
                do
                {
                    Console.Write("Enter coordinates: ");
                    coordinates = Console.ReadLine();
                    xCoord = Convert.ToInt32(coordinates.Substring(0, 1));
                    yCoord = Convert.ToInt32(coordinates.Substring(2));

                    if ((xCoord < 0) || (yCoord > fieldSize - 1) || (bf.field[xCoord, yCoord] == " - "))
                    {
                        Console.WriteLine("Invalid Move");
                    }
                }
                while ((xCoord < 0) || (yCoord > fieldSize - 1) || (bf.field[xCoord, yCoord] == " - "));

                bf.DetonateMine(xCoord, yCoord);
                bf.DisplayField();
                bf.detonatedMines++;
            } 
            while (bf.CountRemainingMines() != 0);

            Console.WriteLine("Game Over. Detonated Mines: " + bf.detonatedMines);
            Console.ReadKey();
        }
    }
}