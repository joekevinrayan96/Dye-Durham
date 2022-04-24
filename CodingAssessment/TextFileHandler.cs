/*Class which handles read and write of text files
 */

using System.Collections.Generic;
using System.IO;


namespace NameSorter
{
    public class TextFileHandler
    {
        public string[] ReadTextFile(string textFile)
        {
            if (File.Exists(textFile))
            {
                string[] fullNames = File.ReadAllLines(textFile);
                return fullNames;
            }
            else
            {
                return null;
            }
        }

        public void WriteTextFile(string writeFile, List<string> arrayofNames)
        {
            File.WriteAllLines(writeFile, arrayofNames);

        }


    }
}
