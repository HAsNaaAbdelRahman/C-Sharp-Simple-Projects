                                    // Tic Tac Toe !

    string[] grid  =  { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    bool PlayerOne = true;
    int numOfTac = 0;

         void Print()
         {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(grid[i * 3 + j] + "|");

                }
                Console.WriteLine();
                Console.WriteLine("------");

            }
    }

         bool isVictory()
         {
            bool row1 = grid[0] == grid[1] && grid[1] == grid[2];
            bool row2 = grid[3] == grid[4] && grid[4] == grid[5];
            bool row3 = grid[6] == grid[7] && grid[7] == grid[8];
            bool column1 = grid[0] == grid[3] && grid[3] == grid[6];
            bool column2 = grid[1] == grid[4] && grid[4] == grid[7];
            bool column3 = grid[2] == grid[5] && grid[5] == grid[8];
            bool isDir = grid[0] == grid[4] && grid[4] == grid[8];
            bool isDil = grid[2] == grid[4] && grid[4] == grid[6];

            return row1 || row1 || row3 || column1 || column2 || column3 || isDil || isDir ;
         }

         void StartGame()
        {
            while(!isVictory() && numOfTac != 9)
            {
                Print();

                if (PlayerOne)
                    Console.WriteLine("Player 1 Trun : ");
                else
                    Console.WriteLine("Player 2 Trun :");


                Console.WriteLine("Enter Your Choice : ");
                string index = Console.ReadLine();

                if( index != "X" && index != "O" && grid.Contains(index))
                {
                    
                    int res = Convert.ToInt32(index) - 1;

                    if (PlayerOne) grid[res] = "X";
                    else grid[res] = "O";

                    numOfTac++;

                }
                PlayerOne = !PlayerOne;
            }
        }

            Console.WriteLine("Tic Tac Toe !");
            Console.WriteLine();
            StartGame();
            string result = isVictory() ? "Congrats, You Win!" : "Tie";
            Console.WriteLine(result);
            Console.WriteLine();

            Print();



        
    

