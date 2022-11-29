using Entidades;
using Entidades.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Test
{
    [TestClass]
    public class ArchivoTxtShould
    {
        public string ruta = AppDomain.CurrentDomain.BaseDirectory;

        [TestMethod]
        [DataRow ("Testing")]
        public void EscribirTxtTest(string archivo)
        {
            string dato = "Estamos testeando el escribir txt";
            new ArchivoTxT().EscribirTxt(archivo, dato);

            Assert.IsNotNull(archivo);
        }

        [TestMethod]
        [DataRow("Testing")]
        public void LeerTxtTest(string nombre)
        {
            string testError = "Si es igual debe dar error";
            string archivoLeido = new ArchivoTxT().LeerTxt(nombre);

            Assert.IsNotNull(archivoLeido);
            Assert.AreNotEqual(archivoLeido, testError);
        }
    }
}
