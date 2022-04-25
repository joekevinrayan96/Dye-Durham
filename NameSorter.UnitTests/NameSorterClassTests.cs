/*Unit Tests class to test NameSorterClass
 */

using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace NameSorter.UnitTests
{
    [TestFixture]
    public class NameSorterClassTests
    {
        /*If array retrieved from textfile is null or textfile not found would return null
         */
        [Test]
        public void SortNames_StringArrayNull_ReturnsNull()
        {
            //Arrange
            var nameSorter = new NameSorterClass();            
            string[] values = null;

            //Act
            var result = nameSorter.SortNames(values);

            //Assert
            Assert.That(result==null);
           
        }


        /*  Test for method sorts names */
        [Test]
        public void SortNames_StringArraySorted_ReturnsSortedArrayList()
        {
            //Arrange
            var nameSorter = new NameSorterClass();
            string[] values = new string[]{ "Joe Kevin Rayan", "Aron Davis Fernando" };
            List<string> sortedValues = new List<string>(){ "Aron Davis Fernando", "Joe Kevin Rayan" };

            //Act
            var result = nameSorter.SortNames(values);

            //Assert
            Assert.IsTrue(sortedValues.SequenceEqual(result));

        }
            
    }
}
