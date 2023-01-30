using ProjetCsharp.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCsharp
{
    internal class Dialog1
    {
        private int index = 0;
        public Dialog1()
        {
            Choices choice1 = new Choices(new List<string> { "1st", "2nd", "3rd" });
            bool loop = true;
            while (loop)
            {
                
                ConsoleKey e = Console.ReadKey().Key;
                
                switch (index)
                {
                    default:
                        loop = false;
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Hi !");
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("My name is Lucas");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("And I live on the second floor");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Which floor do you live on ?");
                        choice1.Write();
                        break;
                    case 4:
                        Console.Clear(); ;
                        Console.WriteLine("That's under mine !");
                        index = 6;
                        break; 
                    case 5:
                        Console.Clear();
                        Console.WriteLine("That's the same as mine !");
                        index = 6;
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("That's on top of mine !");
                        break;


                    
                }
                if (e == ConsoleKey.Enter)
                {
                    if (index == 3)
                    {
                        switch(choice1.State)
                        {
                            case 0: index = 4;
                                break;
                            case 1: index = 5;
                                break;
                            case 2: index = 6;
                                break;
                        }
                    }
                    else { index++; }
                }
            }
        }
    }
}
