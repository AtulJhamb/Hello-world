using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
namespace hangman_mine
{
    class Program
    {
        static char a;
       public void hangman()
       {

            int d,d2;
            d2 = 0;
            int c = 0;
            int c1 = 1;
            int flag = 1;
            int flag1 = 1;
            int checknumber = 0;
            string str;
            char[] ch = new char[100];
            FileStream fs = new FileStream(@"d:\c#\bookname.txt", FileMode.Open, FileAccess.Read);
            FileStream fs1 = new FileStream(@"d:\c#\movie.txt", FileMode.Open, FileAccess.Read);
            Console.Write("*********************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("   Welcome to the Hangman Game   ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("*******************");
            string choice;
        agn1:
            Console.WriteLine("please enter your choice");
            Console.WriteLine("\tchoices are Book and Movie Name");
            choice = Console.ReadLine().ToLower();
            //choice = choice.ToLower();

            if (choice == "book" || choice == "Book")
            {
                Console.Clear();
                char[] arr = new char[100];
               
                StreamReader sr = new StreamReader(fs);
                arr = sr.ReadLine().ToCharArray();
                Console.ForegroundColor= ConsoleColor.Red;
                d = arr.Length + 2;
                Console.WriteLine("you have  " + d
                     + " chances");
                Console.ForegroundColor = ConsoleColor.Gray;
                checknumber = arr.Length;
                Console.WriteLine("total words in the Book " + checknumber
                    );


                Console.WriteLine("\n");
                //  c = c - 1;
                Console.Write("input value \t");
                for (int i = 0; i < arr.Length; i++)
                {
                    ch[i] = '*';

                    Console.Write(ch[i]);
                }
                Console.WriteLine();
                for (int b = 0; b <= arr.Length - 1; )
                {
                agn:


                    // Console.Clear();
                    Console.WriteLine("enter the character");
                    try
                    {
                        a = Convert.ToChar(Console.ReadLine());

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.Clear();
                    for (int i = 0; i < 1; i++)
                    {
                        d2 = 0;
                        for (int j = 0; j < arr.Length; j++)
                        {

                            if (a == arr[j])
                            {
                                ch[j] = a;
                                d2 = 1;
                                arr[j] = '6';
                                flag1++;
                            }
                        }
                    }
                    Console.Write("input value \t");
                    for (int i = 0; i < arr.Length; i++)
                    {


                        Console.Write(ch[i]);
                     
                    }

                    if (d2 == 1)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        b++;
                        Console.WriteLine(" \ntotal correct " + b);
                        Console.WriteLine("\ntotal chance lost " + c);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        flag++;
                        //  flag1 = 1;

                    }

                    else
                    {

                        c++;
                        Console.WriteLine("\n total chance lost " + c);
                        //    break;
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.WriteLine("\ntotal correct " + b);

                        if (c == arr.Length + 1)
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("oops you lost the Game");
                            System.Environment.Exit(0);
                        }
                        //  goto agn;

                    }
                    if (flag1 == arr.Length+1)
                    {
                        Console.WriteLine("\n \n \n");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\t************* You won the game   ************");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        System.Environment.Exit(0);
                    }


                    
                }
            }
            if (choice == "movie")
            {
                StreamReader sr1 = new StreamReader(fs1);
                char[] arr1 = new char[100];
                arr1 = sr1.ReadLine().ToCharArray();
                Console.WriteLine("your choose " + choice + " game");
                Console.ForegroundColor
                                    = ConsoleColor
                                    .Red;
                d = arr1.Length + 2;
                Console.Clear();
                Console.WriteLine(" \t you have  " + d
                     + " chances");
                Console.ForegroundColor = ConsoleColor.Gray;
                checknumber = arr1.Length;
                Console.WriteLine("total words you have to entered " + checknumber
                    );

               


                               Console.Write("input value \t");
                for (int i = 0; i < arr1.Length; i++)
                {
                    ch[i] = '*';

                    Console.Write(ch[i]);
                }
                Console.WriteLine();
                for (int b = 0; b <= arr1.Length - 1; )
                {
                agn:


                    // Console.Clear();
                    Console.WriteLine("enter the character");
                    try
                    {
                        a = Convert.ToChar(Console.ReadLine());

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.Clear();
                    for (int i = 0; i < 1; i++)
                    {
                        d2 = 0;
                        for (int j = 0; j < arr1.Length; j++)
                        {

                            if (a == arr1[j])
                            {
                                ch[j] = a;
                                d2 = 1;
                                arr1[j] = '6';
                                flag1++;
                            }
                        }
                    }
                    Console.Write("input value \t");
                    for (int i = 0; i < arr1.Length; i++)
                    {


                        Console.Write(ch[i]);
                     
                    }

                    if (d2 == 1)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        b++;
                        Console.WriteLine("\ntotal correct " + b);
                        Console.WriteLine("\ntotal chance lost " + c);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        flag++;
                        //  flag1 = 1;

                    }

                    else
                    {

                        c++;
                        Console.WriteLine("\n total chance lost " + c);
                        //    break;
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.WriteLine("\ntotal correct " + b);

                        if (c == arr1.Length + 1)
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("oops you lost the Game");
                            System.Environment.Exit(0);
                        }
                        //  goto agn;

                    }
                    if (flag1 == arr1.Length+1)
                    {
                        Console.WriteLine("\n \n \n");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\t************* You won the game   ************");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        System.Environment.Exit(0);
                    }


                   

                }


            }



            if (choice != "book" || choice != "movie")
            {
                goto agn1; ;
            }
        last:

            for (int i = 0; i >= 0; )
            {
                Console.WriteLine(" ");
                break;
            }

        }

       static void Main()
       {
           Program pr = new Program();
           ThreadStart th = new ThreadStart(pr.hangman);
           Thread t = new Thread(th);
           t.Start();
           Console.Write("\n \t");
           Console.WriteLine("*********** You have 90 sec to complete the Game *************");
           Console.WriteLine("\n \n \n");
           Thread.Sleep(90000);
           try
           {
               t.Abort();
               Console.WriteLine();
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("time over");
               Console.ForegroundColor = ConsoleColor.Gray;
           }
           catch (Exception e)
           {
               Console.WriteLine(e.Message);
           }
       }

    }
}

