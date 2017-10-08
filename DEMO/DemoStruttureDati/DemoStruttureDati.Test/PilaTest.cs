using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoStruttureDati.Test
{
    using DemoStruttureDati;
    [TestClass]
    public class PilaTest
    {
        [TestMethod]
        public void CreataVuota()
        {
            var pila = new Pila();
            Assert.IsTrue(pila.Count == 0);
        }

        [TestMethod]
        public void PushEPop()
        {
            var pila = new Pila();
            pila.Push("ciao");
            pila.Push("mamma");

            Assert.IsTrue(pila.Count == 2);

            var valore = pila.Pop();

            Assert.AreEqual("mamma", valore);
            Assert.IsTrue(pila.Count == 1);

        }
        [ExpectedException(typeof(InvalidOperationException))]
        [TestMethod]
        public void PopSuPilaVuota()
        {
            var pila = new Pila();
            pila.Push("ciao");
            pila.Push("mamma");
            pila.Pop();
            pila.Pop();
            pila.Pop();
        }

        [TestMethod]
        public void PilaToArray()
        {
            var pila = new Pila();
            pila.Push("ciao");
            pila.Push("mamma");
            var valori = pila.ToArray();
            Assert.AreEqual(2, valori.Length);
            Assert.AreEqual("ciao", valori[1]);
        }

    }
}
