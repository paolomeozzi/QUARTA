using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoStruttureDati.Test
{
    using DemoStruttureDati;
    [TestClass]
    public class ListaTest
    {
        [TestMethod]
        public void CreataVuota()
        {
            var lista = new Lista();
            Assert.IsTrue(lista.Count == 0);
        }

        [TestMethod]
        public void AddItems()
        {
            var lista = new Lista();
            lista.Add("ciao");
            lista.Add("mamma");

            Assert.IsTrue(lista.Count == 2);

            var valore = lista.GetItem(1);
            Assert.AreEqual("mamma", valore);

        }

        [TestMethod]
        public void RemoveItems()
        {
            var lista = new Lista();
            lista.Add("ciao");
            lista.Add("mamma");
            lista.Remove("ciao");
            Assert.IsTrue(lista.Count == 1);

            Assert.AreEqual("mamma", lista.GetItem(0));
            lista.RemoveAt(0);
            Assert.IsTrue(lista.Count == 0);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void RemoveInvalidItem()
        {
            var lista = new Lista();
            lista.Add("ciao");
            lista.Add("mamma");

            lista.RemoveAt(2);
        }

        [TestMethod]
        public void ListaToArray()
        {
            var lista = new Lista();
            lista.Add("ciao");
            lista.Add("mamma");
            var valori = lista.ToArray();
            Assert.AreEqual(2, valori.Length);
            Assert.AreEqual("ciao", valori[0]);
        }

    }
}
