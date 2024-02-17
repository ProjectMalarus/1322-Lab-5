using System.ComponentModel.Design;

namespace _1322_Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List <Item> items = new List <Item> ();

            int count = 1;
            bool quit = false;
            while (quit == false)
            {
                

                Console.WriteLine("Please enter B for Book or P for Periodical");
                char selection = Convert.ToChar(Console.ReadLine());

                if (selection == 'B' || selection == 'b')
                {
                    Console.WriteLine("Please enter the name of the Book");
                    string name = Console.ReadLine();


                    Console.WriteLine("Please enter the author of the Book");
                    string writer = Console.ReadLine();


                    Console.WriteLine("Please enter the ISBN of the Book");
                    int isbn = Convert.ToInt32(Console.ReadLine());

                    Book book = new Book(isbn, writer, name);

                    items.Add(book);
                    
                }
                else if (selection == 'P' || selection == 'p')
                {
                    Console.WriteLine("Please enter the name of the Periodical");
                    string name = Console.ReadLine();


                    Console.WriteLine("Please enter the issue number");
                    int issue = Convert.ToInt32(Console.ReadLine());

                    Periodical periodical = new Periodical(issue, name);

                    items.Add(periodical);
                    
                }
                if (count == 5)
                {
                    Console.WriteLine("Your Items:");
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (items[i] is Book)
                        {
                            Book currentBook = (Book)items[i];
                            Console.WriteLine(currentBook.getListing());
                            Console.WriteLine();
                        }
                        else if (items[i] is Periodical)
                        {
                            Periodical currentPeriod = (Periodical)items[i];
                            Console.WriteLine(currentPeriod.getListing());
                            Console.WriteLine();
                        }
                    }
                    quit = true;
                    break;
                }

                count++;
                
            }
                
                
            

           
        }
    }
}
