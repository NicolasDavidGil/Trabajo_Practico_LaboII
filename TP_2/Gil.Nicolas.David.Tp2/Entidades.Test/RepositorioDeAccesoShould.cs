﻿using Entidades.Modelos;
using Entidades.Repositorio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Test
{ 
    [TestClass]
    public class RepositorioDeAccesoShould
    {
        [TestMethod]
        public void GetUsersTest()
        {
            List<Usuario> testList = new List<Usuario>();

            testList = new RepositorioDeAcceso().ObtenerUsuarios();

            Assert.IsNotNull(testList);
        }

        [TestMethod]
        public void ObtenerMazoTest()
        {
            List<Carta> testList = new List<Carta>();

            testList = new RepositorioDeAcceso().ObtenerMazo();

            Assert.IsNotNull(testList);
        }

        [TestMethod]
        public void ObtenerPartidasTest()
        {
            List<Partida> testList = new List<Partida>();

            testList = new RepositorioDeAcceso().ObtenerHistorial();

            Assert.IsNotNull(testList);
        }
        [TestMethod]
        public void ObtenerPaisesTest()
        {
            List<string> testList = new List<string>();

            testList = new RepositorioDeAcceso().ObtenerPaises();

            Assert.IsNotNull(testList);
        }
    }
}