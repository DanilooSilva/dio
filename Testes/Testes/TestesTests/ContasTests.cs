using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testes.Tests
{
    [TestClass()]
    public class ContasTests
    {
        [TestMethod()]
        public void SomaTest()
        {
            int a = 5;
            int b = 5;
            int esperado = 10;

            var contas = new Contas();
            var result = contas.Soma(a, b);

            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void SubtracaoTest()
        {
            int a = 10;
            int b = 2;
            int esperado = 8;

            var contas = new Contas();
            var result = contas.Subtracao(a, b);

            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void DivisaoTest()
        {
            int a = 10;
            int b = 2;
            int esperado = 5;

            var contas = new Contas();
            var result = contas.Divisao(a, b);

            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void MutiplicacaoTest()
        {
            int a = 10;
            int b = 2;
            int esperado = 20;

            var contas = new Contas();
            var result = contas.Mutiplicacao(a, b);

            Assert.AreEqual(esperado, result);
        }
    }
}