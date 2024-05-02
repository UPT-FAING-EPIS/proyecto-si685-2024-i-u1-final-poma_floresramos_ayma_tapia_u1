using System;
using NUnit.Framework;
using GestorArchivosOnline.Domain;

namespace GestorArchivosOnline.Tests
{
    [TestFixture]
    public class GestorArchivosTests
    {
        [Test]
        public void Usuario_IniciarSesion_Correcto()
        {
            // Prepara
            Usuario usuario = new Usuario("John", "john@example.com", "contraseña_prueba");

            // Actua
            bool resultado = usuario.IniciarSesion("contraseña_prueba");

            // Afirma
            Assert.IsTrue(resultado);
        }

        [Test]
        public void Usuario_IniciarSesion_Incorrecto()
        {
            // Prepara
            Usuario usuario = new Usuario("John", "john@example.com", "contraseña_prueba");

            // Actua
            bool resultado = usuario.IniciarSesion("otra_contraseña");

            // Afirma
            Assert.IsFalse(resultado);
        }

        [Test]
        public void DetalleSuscripcionUsuario_ComprarSuscripcion()
        {
            // Prepara
            Usuario usuario = new Usuario("John", "john@example.com", "contraseña_prueba");
            DetalleSuscripcionUsuario detalleSuscripcion = new DetalleSuscripcionUsuario(usuario, TipoSuscripcion.MENSUAL, DateTime.Now, DateTime.Now.AddMonths(1), 10.0f);

            // Actua
            detalleSuscripcion.ComprarSuscripcion();

           
        }

        [Test]
        public void FusionadorPDF_RealizarOperacion()
        {
            // Prepara
            FusionadorPDF fusionadorPDF = new FusionadorPDF();

            // Actua
            string resultado = fusionadorPDF.RealizarOperacion();

            // Afirma
            Assert.That(resultado, Is.EqualTo("Operación de fusión realizada"));
        }

        [Test]
        public void CortadorPDF_RealizarOperacion()
        {
            // Prepara
            CortadorPDF cortadorPDF = new CortadorPDF();

            // Actua
            string resultado = cortadorPDF.RealizarOperacion();

            // Afirma
            Assert.That(resultado, Is.EqualTo("Operación de corte realizada"));
        }
    }
}
