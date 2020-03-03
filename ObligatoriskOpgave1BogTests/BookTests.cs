using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpgave1;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace ObligatoriskOpgave1.BogTests
{
    //####################### 
    //### 81% CODE COVERAGE ###
    //#######################

    [TestClass()]
    public class BookTests
    {
        private Book _book;

        [TestInitialize]
        public void BookTest()
        {
            _book = new Book("Løvernes Konge","Karl Marx",100,"1234567891011");
        }
        
        [TestMethod()]
        public void BookTitleTest()
        {
            Assert.AreEqual("Løvernes Konge", _book.Title);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void BookTitleTestNullException()
        {
            _book.Title = null;
        }

        [TestMethod()]
        public void BookAuthorTest()
        {
            Assert.AreEqual("Karl Marx", _book.Author);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void BookAuthorTestNullException()
        {
            _book.Author = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BookAuthorTestOutOfRangeException()
        {
            _book.Author = "a";
        }

        [TestMethod]
        public void BookNoOfPagesTest()
        {
            Assert.AreEqual(100,_book.NoOfPages);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BookNoOfPagesOutOfRangeLowerException()
        {
            _book.NoOfPages = 3;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BookNoOfPagesOutOfRangeHigherException()
        {
            _book.NoOfPages = 1001;
        }
        [TestMethod]
        public void BookISBNTest()
        {
            _book.ISBN13 = "1234567891011";
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void BookNoOfPagesOutOfRangeNullException()
        {
            _book.ISBN13 = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BookISBNOutOfRangeLowerException()
        {
            _book.ISBN13 = "123456789";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BookISBNOutOfRangeHigherException()
        {
            _book.ISBN13 = "123456789101112131416";
        }
    }
}