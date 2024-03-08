using System;
namespace FIFO.Project1
{
    // to do list
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();

            Console.WriteLine("Welcome To {To Do List App} ");
            Console.WriteLine("What would you like to do today?");

            string option = "";

            while (option != "e")
            {
                Console.WriteLine(". Enter 1 To add a Task ");
                Console.WriteLine(". Enter 2 To remove a Task ");
                Console.WriteLine(". Enter 3 To view the list ");
                Console.WriteLine(". Enter e to Exit");

                 option = Console.ReadLine();


                if (option == "1")
                {
                    Console.WriteLine("Enter a Task :");
                    string task = Console.ReadLine();
                    list.Add(task);
                    Console.WriteLine("Task added.");
                }
                else if(option == "2")
                {
                    for(int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(i + " "+ list[i]);
                    }

                    Console.WriteLine("Enter ther number of the task to remove from the list");

                    int res = Convert.ToInt32(Console.ReadLine());
                    list.RemoveAt(res);
                    Console.WriteLine("Task deleted.");

                }
                else if(option == "3")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i]);
                    }
                
                }
                else if(option == "e")
                {
                    System.Threading.Thread.Sleep(300);
                    Console.WriteLine("Exiting the program.");
                }


            }
            Console.WriteLine("Thank You for using to do list app.");


        }
    }
   
}

    
