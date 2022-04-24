using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NameSorter;
using System.IO;

namespace NameSorter.UnitTests
{
    [TestFixture]
    class TextFileHandlerTests
    {
        /*  Test to check if text file exists   */
        [Test]
        public void ReadTextFile_FileExists()
        {
            //Arrange
            var textFileHandler = new TextFileHandler();
            string textFilePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "unsorted-names-list.txt");
          

            //Act
            var result = textFileHandler.ReadTextFile(textFilePath); 

            //Assert            
            Assert.That(textFilePath, Does.Exist);
            
            
            
        }

        /*  Test to check if text file doesn't exist method returns null    */
        [Test]
        public void ReadTextFile_FileExists_ReturnsNull()
        {
            //Arrange
            var textFileHandler = new TextFileHandler();
            string textFilePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "unsorted-names-list.txt");

            //Act
            var result = textFileHandler.ReadTextFile(textFilePath);
           
            //Assert
            if (!File.Exists(textFilePath))
            {
                Assert.IsNull(result);
            }

        }
        
        /*  Test to check if method returns an array of from textfile */
        [Test]
        public void ReadTextFile_FileExists_ReturnsArray()
        {
            //Arrange
            var textFileHandler = new TextFileHandler();
            string textFilePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "unsorted-names-list.txt");
            

            //Act
            var result = textFileHandler.ReadTextFile(textFilePath);

            //Assert
            Assert.IsTrue(result.Length>1);
            
            
        }

        /*  Test to check if method writes text in textfile */
        [Test]
        public void WriteTextFile_WritesText()
        {
            //Arrange            
            string WriteFilePath=Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "sorted-names-list.txt");            
            string values=File.ReadAllText(WriteFilePath);


            //Assert
            Assert.IsTrue(values.Length > 1);
        }
    }
}
