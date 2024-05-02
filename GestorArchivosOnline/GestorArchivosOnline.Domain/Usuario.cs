using System;

namespace GestorArchivosOnline.Domain
{
    public class Usuario
    {
        public string Nombre { get; private set; }
        public string Correo { get; private set; }
        public string Contraseña { get; set; }

        public Usuario(string nombre, string correo, string contraseña)
        {
            Nombre = nombre;
            Correo = correo;
            Contraseña = contraseña;
        }

        public bool IniciarSesion(string contraseña)
        {
            // Simulación básica de inicio de sesión exitoso
            return Contraseña == contraseña;
        }

        public void Registrar()
        {
            // Implementación de registro de usuario
        }
    }
}
