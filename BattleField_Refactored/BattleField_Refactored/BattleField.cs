﻿namespace BattleField
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
            //top side numbers
            Console.Write("   ");
            for (int i = 0; i < fieldSize; i++)
            {
                Console.Write(" " + i.ToString() + "  ");
            }
            Console.WriteLine("");

            Console.Write("    ");
            for (int i = 0; i < 4 * fieldSize - 3; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("");
            //top side numbers


            Console.WriteLine("");

            for (int i = 0; i < fieldSize; i++)
            {
                //left side numbers
                Console.Write(i.ToString() + "|");
                for (int j = 0; j < fieldSize; j++)
                {
                    Console.Write(" " + this.field[i, j].ToString());
                }
            }
        }

        public void InitMines()
        {
            //tuka ne sym siguren kakvo tochno pravq ama pyk raboti
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
                    //tuka cikyla se vyrti dokato flag ne e false
                    //s do-while raboti po dobre
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

        //tuka sa mogyshtite metodi za gyrmejite

        public void DetonateMine1(int XCoord, int YCoord)
        {
            if ((XCoord - 1 >= 0) && (XCoord - 1 < fieldSize) && (YCoord - 1 >= 0) && (YCoord - 1 < fieldSize))
            {
                this.field[XCoord - 1, YCoord - 1] = " X ";
            }

            if ((XCoord - 1 >= 0) && (XCoord - 1 < fieldSize) && (YCoord + 1 >= 0) && (YCoord + 1 < fieldSize))
            {
                this.field[XCoord - 1, YCoord + 1] = " X ";
            }

            if ((XCoord + 1 >= 0) && (XCoord + 1 < fieldSize) && (YCoord - 1 >= 0) && (YCoord - 1 < fieldSize))
            {
                this.field[XCoord + 1, YCoord - 1] = " X ";
            }

            if ((XCoord + 1 >= 0) && (XCoord + 1 < fieldSize) && (YCoord + 1 >= 0) && (YCoord + 1 < fieldSize))
            {
                this.field[XCoord + 1, YCoord + 1] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord, YCoord] = " X ";
            }
        }

        public void DetonateMine2(int XCoord, int YCoord)
        {
            if ((XCoord - 1 >= 0) && (XCoord - 1 < fieldSize) && (YCoord - 1 >= 0) && (YCoord - 1 < fieldSize))
            {
                this.field[XCoord - 1, YCoord - 1] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord - 1 >= 0) && (YCoord - 1 < fieldSize))
            {
                this.field[XCoord, YCoord - 1] = " X ";
            }

            if ((XCoord + 1 >= 0) && (XCoord + 1 < fieldSize) && (YCoord - 1 >= 0) && (YCoord - 1 < fieldSize))
            {
                this.field[XCoord + 1, YCoord - 1] = " X ";
            }

            if ((XCoord - 1 >= 0) && (XCoord - 1 < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord - 1, YCoord] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord, YCoord] = " X ";
            }

            if ((XCoord + 1 >= 0) && (XCoord + 1 < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord + 1, YCoord] = " X ";
            }

            if ((XCoord - 1 >= 0) && (XCoord - 1 < fieldSize) && (YCoord + 1 >= 0) && (YCoord + 1 < fieldSize))
            {
                this.field[XCoord - 1, YCoord + 1] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord + 1 >= 0) && (YCoord + 1 < fieldSize))
            {
                this.field[XCoord, YCoord + 1] = " X ";
            }

            if ((XCoord + 1 >= 0) && (XCoord + 1 < fieldSize) && (YCoord + 1 >= 0) && (YCoord + 1 < fieldSize))
            {
                this.field[XCoord + 1, YCoord + 1] = " X ";
            }
        }

        public void DetonateMine3(int XCoord, int YCoord)
        {
            if ((XCoord - 2 >= 0) && (XCoord - 2 < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord - 2, YCoord] = " X ";
            }

            if ((XCoord - 1 >= 0) && (XCoord - 1 < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord - 1, YCoord] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord, YCoord] = " X ";
            }

            if ((XCoord + 1 >= 0) && (XCoord + 1 < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord + 1, YCoord] = " X ";
            }

            if ((XCoord + 2 >= 0) && (XCoord + 2 < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord + 2, YCoord] = " X ";
            }


            if ((XCoord - 1 >= 0) && (XCoord - 1 < fieldSize) && (YCoord - 1 >= 0) && (YCoord - 1 < fieldSize))
            {
                this.field[XCoord - 1, YCoord - 1] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord, YCoord] = " X ";
            }

            if ((XCoord + 1 >= 0) && (XCoord + 1 < fieldSize) && (YCoord + 1 >= 0) && (YCoord + 1 < fieldSize))
            {
                this.field[XCoord + 1, YCoord + 1] = " X ";
            }

            if ((XCoord - 1 >= 0) && (XCoord - 1 < fieldSize) && (YCoord + 1 >= 0) && (YCoord + 1 < fieldSize))
            {
                this.field[XCoord - 1, YCoord + 1] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord, YCoord] = " X ";
            }

            if ((XCoord + 1 >= 0) && (XCoord + 1 < fieldSize) && (YCoord - 1 >= 0) && (YCoord - 1 < fieldSize))
            {
                this.field[XCoord + 1, YCoord - 1] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord - 2 >= 0) && (YCoord - 2 < fieldSize))
            {
                this.field[XCoord, YCoord - 2] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord - 1 >= 0) && (YCoord - 1 < fieldSize))
            {
                this.field[XCoord, YCoord - 1] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord, YCoord] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord + 1 >= 0) && (YCoord + 1 < fieldSize))
            {
                this.field[XCoord, YCoord + 1] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord + 2 >= 0) && (YCoord + 2 < fieldSize))
            {
                this.field[XCoord, YCoord + 2] = " X ";
            }
        }

        public void DetonateMine4(int XCoord, int YCoord)
        {
            if ((XCoord - 1 >= 0) && (XCoord - 1 < fieldSize) && (YCoord - 1 >= 0) && (YCoord - 1 < fieldSize))
            {
                this.field[XCoord - 1, YCoord - 1] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord - 1 >= 0) && (YCoord - 1 < fieldSize))
            {
                this.field[XCoord, YCoord - 1] = " X ";
            }

            if ((XCoord + 1 >= 0) && (XCoord + 1 < fieldSize) && (YCoord - 1 >= 0) && (YCoord - 1 < fieldSize))
            {
                this.field[XCoord + 1, YCoord - 1] = " X ";
            }

            if ((XCoord - 1 >= 0) && (XCoord - 1 < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord - 1, YCoord] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord, YCoord] = " X ";
            }

            if ((XCoord + 1 >= 0) && (XCoord + 1 < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord + 1, YCoord] = " X ";
            }

            if ((XCoord - 1 >= 0) && (XCoord - 1 < fieldSize) && (YCoord + 1 >= 0) && (YCoord + 1 < fieldSize))
            {
                this.field[XCoord - 1, YCoord + 1] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord + 1 >= 0) && (YCoord + 1 < fieldSize))
            {
                this.field[XCoord, YCoord + 1] = " X ";
            }

            if ((XCoord + 1 >= 0) && (XCoord + 1 < fieldSize) && (YCoord + 1 >= 0) && (YCoord + 1 < fieldSize))
            {
                this.field[XCoord + 1, YCoord + 1] = " X ";
            }

            if ((XCoord - 1 >= 0) && (XCoord - 1 < fieldSize) && (YCoord + 2 >= 0) && (YCoord + 2 < fieldSize))
            {
                this.field[XCoord - 1, YCoord + 2] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord + 2 >= 0) && (YCoord + 2 < fieldSize))
            {
                this.field[XCoord, YCoord + 2] = " X ";
            }

            if ((XCoord + 1 >= 0) && (XCoord + 1 < fieldSize) && (YCoord + 2 >= 0) && (YCoord + 2 < fieldSize))
            {
                this.field[XCoord + 1, YCoord + 2] = " X ";
            }

            if ((XCoord - 1 >= 0) && (XCoord - 1 < fieldSize) && (YCoord - 2 >= 0) && (YCoord - 2 < fieldSize))
            {
                this.field[XCoord - 1, YCoord - 2] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord - 2 >= 0) && (YCoord - 2 < fieldSize))
            {
                this.field[XCoord, YCoord - 2] = " X ";
            }

            if ((XCoord + 1 >= 0) && (XCoord + 1 < fieldSize) && (YCoord - 2 >= 0) && (YCoord - 2 < fieldSize))
            {
                this.field[XCoord + 1, YCoord - 2] = " X ";
            }

            if ((XCoord - 2 >= 0) && (XCoord - 2 < fieldSize) && (YCoord - 1 >= 0) && (YCoord - 1 < fieldSize))
            {
                this.field[XCoord - 2, YCoord - 1] = " X ";
            }

            if ((XCoord - 2 >= 0) && (XCoord - 2 < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord - 2, YCoord] = " X ";
            }

            if ((XCoord - 2 >= 0) && (XCoord - 2 < fieldSize) && (YCoord + 1 >= 0) && (YCoord + 1 < fieldSize))
            {
                this.field[XCoord - 2, YCoord + 1] = " X ";
            }

            if ((XCoord + 2 >= 0) && (XCoord + 2 < fieldSize) && (YCoord - 1 >= 0) && (YCoord - 1 < fieldSize))
            {
                this.field[XCoord + 2, YCoord - 1] = " X ";
            }

            if ((XCoord + 2 >= 0) && (XCoord + 2 < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord + 2, YCoord] = " X ";
            }

            if ((XCoord + 2 >= 0) && (XCoord + 2 < fieldSize) && (YCoord + 1 >= 0) && (YCoord + 1 < fieldSize))
            {
                this.field[XCoord + 2, YCoord + 1] = " X ";
            }
        }

        public void DetonateMine5(int XCoord, int YCoord)
        {
            if ((XCoord - 1 >= 0) && (XCoord - 1 < fieldSize) && (YCoord - 1 >= 0) && (YCoord - 1 < fieldSize))
            {
                this.field[XCoord - 1, YCoord - 1] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord - 1 >= 0) && (YCoord - 1 < fieldSize))
            {
                this.field[XCoord, YCoord - 1] = " X ";
            }

            if ((XCoord + 1 >= 0) && (XCoord + 1 < fieldSize) && (YCoord - 1 >= 0) && (YCoord - 1 < fieldSize))
            {
                this.field[XCoord + 1, YCoord - 1] = " X ";
            }

            if ((XCoord - 1 >= 0) && (XCoord - 1 < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord - 1, YCoord] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord, YCoord] = " X ";
            }

            if ((XCoord + 1 >= 0) && (XCoord + 1 < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord + 1, YCoord] = " X ";
            }

            if ((XCoord - 1 >= 0) && (XCoord - 1 < fieldSize) && (YCoord + 1 >= 0) && (YCoord + 1 < fieldSize))
            {
                this.field[XCoord - 1, YCoord + 1] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord + 1 >= 0) && (YCoord + 1 < fieldSize))
            {
                this.field[XCoord, YCoord + 1] = " X ";
            }

            if ((XCoord + 1 >= 0) && (XCoord + 1 < fieldSize) && (YCoord + 1 >= 0) && (YCoord + 1 < fieldSize))
            {
                this.field[XCoord + 1, YCoord + 1] = " X ";
            }

            if ((XCoord - 1 >= 0) && (XCoord - 1 < fieldSize) && (YCoord + 2 >= 0) && (YCoord + 2 < fieldSize))
            {
                this.field[XCoord - 1, YCoord + 2] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord + 2 >= 0) && (YCoord + 2 < fieldSize))
            {
                this.field[XCoord, YCoord + 2] = " X ";
            }

            if ((XCoord + 1 >= 0) && (XCoord + 1 < fieldSize) && (YCoord + 2 >= 0) && (YCoord + 2 < fieldSize))
            {
                this.field[XCoord + 1, YCoord + 2] = " X ";
            }

            if ((XCoord - 1 >= 0) && (XCoord - 1 < fieldSize) && (YCoord - 2 >= 0) && (YCoord - 2 < fieldSize))
            {
                this.field[XCoord - 1, YCoord - 2] = " X ";
            }

            if ((XCoord >= 0) && (XCoord < fieldSize) && (YCoord - 2 >= 0) && (YCoord - 2 < fieldSize))
            {
                this.field[XCoord, YCoord - 2] = " X ";
            }

            if ((XCoord + 1 >= 0) && (XCoord + 1 < fieldSize) && (YCoord - 2 >= 0) && (YCoord - 2 < fieldSize))
            {
                this.field[XCoord + 1, YCoord - 2] = " X ";
            }

            if ((XCoord - 2 >= 0) && (XCoord - 2 < fieldSize) && (YCoord - 1 >= 0) && (YCoord - 1 < fieldSize))
            {
                this.field[XCoord - 2, YCoord - 1] = " X ";
            }

            if ((XCoord - 2 >= 0) && (XCoord - 2 < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord - 2, YCoord] = " X ";
            }

            if ((XCoord - 2 >= 0) && (XCoord - 2 < fieldSize) && (YCoord + 1 >= 0) && (YCoord + 1 < fieldSize))
            {
                this.field[XCoord - 2, YCoord + 1] = " X ";
            }

            if ((XCoord + 2 >= 0) && (XCoord + 2 < fieldSize) && (YCoord - 1 >= 0) && (YCoord - 1 < fieldSize))
            {
                this.field[XCoord + 2, YCoord - 1] = " X ";
            }

            if ((XCoord + 2 >= 0) && (XCoord + 2 < fieldSize) && (YCoord >= 0) && (YCoord < fieldSize))
            {
                this.field[XCoord + 2, YCoord] = " X ";
            }

            if ((XCoord + 2 >= 0) && (XCoord + 2 < fieldSize) && (YCoord + 1 >= 0) && (YCoord + 1 < fieldSize))
            {
                this.field[XCoord + 2, YCoord + 1] = " X ";
            }

            if ((XCoord - 2 >= 0) && (XCoord - 2 < fieldSize) && (YCoord - 2 >= 0) && (YCoord - 2 < fieldSize))
            {
                this.field[XCoord - 2, YCoord - 2] = " X ";
            }

            if ((XCoord + 2 >= 0) && (XCoord + 2 < fieldSize) && (YCoord - 2 >= 0) && (YCoord - 2 < fieldSize))
            {
                this.field[XCoord + 2, YCoord - 2] = " X ";
            }

            if ((XCoord - 2 >= 0) && (XCoord - 2 < fieldSize) && (YCoord + 2 >= 0) && (YCoord + 2 < fieldSize))
            {
                this.field[XCoord - 2, YCoord + 2] = " X ";
            }

            if ((XCoord + 2 >= 0) && (XCoord + 2 < fieldSize) && (YCoord + 2 >= 0) && (YCoord + 2 < fieldSize))
            {
                this.field[XCoord + 2, YCoord + 2] = " X ";
            }
        }


        //tuka se izbira kva bomba da grymne
        public void DetonateMine(int XCoord, int YCoord)
        {
            switch (Convert.ToInt32(this.field[XCoord, YCoord]))
            {
                case 1: this.DetonateMine1(XCoord, YCoord);
                    break;
                case 2: this.DetonateMine2(XCoord, YCoord);
                    break;
                case 3: this.DetonateMine3(XCoord, YCoord);
                    break;
                case 4: this.DetonateMine4(XCoord, YCoord);
                    break;
                case 5: this.DetonateMine5(XCoord, YCoord);
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
                Console.Write("Enter battle field size: ");
                tempFieldSize = Console.ReadLine();
            } 
            while ((!Int32.TryParse(tempFieldSize, out fieldSize)) || (fieldSize < 0) || (fieldSize > 11));

            BattleField bf = new BattleField();
            bf.InitField();
            bf.InitMines();
            bf.DisplayField();

            string coordinates;
            int XCoord, YCoord;

            do
            {
                do
                {
                    Console.Write("Enter coordinates: ");
                    coordinates = Console.ReadLine();
                    XCoord = Convert.ToInt32(coordinates.Substring(0, 1));
                    YCoord = Convert.ToInt32(coordinates.Substring(2));

                    if ((XCoord < 0) || (YCoord > fieldSize - 1) || (bf.field[XCoord, YCoord] == " - "))
                        Console.WriteLine("Invalid Move");
                } while ((XCoord < 0) || (YCoord > fieldSize - 1) || (bf.field[XCoord, YCoord] == " - "));

                bf.DetonateMine(XCoord, YCoord);
                bf.DisplayField();
                bf.detonatedMines++;
            } while (bf.CountRemainingMines() != 0);

            Console.WriteLine("Game Over. Detonated Mines: " + bf.detonatedMines);
            Console.ReadKey();
        }
    }
}