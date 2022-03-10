using System;
using System.IO;

namespace readcont
{
    class FileRead
    {
      public static void Main()
      {
            string filename;
            while(true)
            {
                Console.WriteLine("\n-------menu-------\n");
                Console.WriteLine("\n1.create a file");
                Console.WriteLine("\n2.existence of the file");
                Console.WriteLine("\n3.read the contents of the file");
                Console.WriteLine("\n4.exit");
                Console.Write("\n enter your choice:");
                int ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        Console.Write("\n enter the name to create:");
                        filename = Console.ReadLine();
                        Console.WriteLine("n write the contents to the file:\n");
                        string r = Console.ReadLine();
                        using(StreamWriter fileStr=File.CreateText(filename))
                        {
                            fileStr.WriteLine(r);
                        }
                        Console.WriteLine("file is created.");
                        break;
                    case 2:
                        Console.Write("\nenter the file name:");
                        filename = Console.ReadLine();
                        if(File.Exists(filename))
                        {
                            Console.WriteLine("file exist.");
                        }
                        else
                        {
                            Console.WriteLine("file does not exist in the current directory!");
                        }
                        break;
                    case 3:
                        Console.Write("enter the file name to read the contents:");
                        filename = Console.ReadLine();
                        if(File.Exists(filename))
                        {
                            using (StreamReader sr = File.OpenText(filename))
                            {
                                string s = "";
                                Console.WriteLine(" here is the content of the file:");
                                while((s=sr.ReadLine())!=null)
                                {
                                    Console.WriteLine(s);
                                }
                                Console.WriteLine("");
                            }
                        }
                        else
                        {
                            Console.WriteLine("file does not exist");
                        }
                        break;
                    case 4:
                        Console.WriteLine("\n exiting..");
                        return;
                    default:
                        Console.WriteLine("\n invalid choice");
                        break;
                }
            }
      }
    }
}
