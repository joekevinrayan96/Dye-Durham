/*Main class file executes the functions from those different classes
 */

using System;
using System.IO;


namespace NameSorter
{
    public class Program
    {
        public static readonly string textFile = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "unsorted-names-list.txt");
        static string writeFile = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "sorted-names-list.txt");
        

        static void Main(string[] args)
        {

            NameSorterClass nameSorterObj = new NameSorterClass();
            TextFileHandler textFileHandlerObj = new TextFileHandler();

            /*  Reason to have if condition is for better user experience whereas not having this 
                if condition, when unsorted-names-list.txt file is not found error message would 
                showup in twice.
             */

            if (nameSorterObj.SortNames(textFileHandlerObj.ReadTextFile(textFile)) == null)
            {
                Console.WriteLine("unsorted-names-list.txt not found!");

            }
            else
            {

                textFileHandlerObj.WriteTextFile(writeFile, nameSorterObj.SortNames(textFileHandlerObj.ReadTextFile(textFile)));

                foreach (var names in nameSorterObj.SortNames(textFileHandlerObj.ReadTextFile(textFile)))
                {
                    Console.WriteLine(names);
                }
            }

            Console.Write("\n \nPress any key to close this app...");
            Console.ReadLine();


        }
    }
}
