/*This class sort names which gets the list of names read from the text file
 */


using System.Collections.Generic;
using System.Linq;


namespace NameSorter
{
    public class NameSorterClass
    {
        public List<string> SortNames(string[] fullNames)
        {
            List<string> arrayOfNames = new List<string>();
            if (fullNames == null)
            {
                return null;
                
            }


            foreach (string fullName in fullNames)
            {
                arrayOfNames.Add(fullName);
            }

            arrayOfNames.Sort((n1, n2) => n1.Split(" ").Last().CompareTo(n2.Split(" ").Last()));
            return arrayOfNames;         
            




        }
        
    }
}
