using KowalskiApp.StdLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KowalskiApp.Tests.ModelTests
{
    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void Book_Create_Serialization()
        {
            string author = "Adam Mickiewicz";
            string title = "Pan Tadeusz";
            var expected = $"{author}, {title}";

            var myBook = new Book() {
                Author = author,
                Title = title,
            };

            Assert.AreEqual(expected, myBook.ToString());

        }
        
    }
}