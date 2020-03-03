using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpgave1;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace ObligatoriskOpgave1.BogTests
{
    [TestClass()]
    public class BogTests
    {
        Bog b = new Bog();

        [TestMethod()]
        public void BogTitleTest()
        {
            b.Titel = "Løvernes Konge";
            Assert.AreEqual("Løvernes Konge", b.Titel);
        }

        [TestMethod()]
        public void BogForfatterTest()
        {
            b.Forfatter = "oliver";
            Assert.AreEqual("oliver", b.Forfatter);
        }


    }
}