using System;

namespace GestorArchivosOnline.Domain
{
    public class DetalleSuscripcionUsuario
    {
        public Usuario Usuario { get; private set; }
        public TipoSuscripcion TipoSuscripcion { get; private set; }
        public DateTime FechaInicio { get; private set; }
        public DateTime FechaFinal { get; private set; }
        public float Precio { get; private set; }
        //public  List<OperacionPDF> operacionesPDF; 
        public DetalleSuscripcionUsuario(Usuario usuario, TipoSuscripcion tipoSuscripcion, DateTime fechaInicio, DateTime fechaFinal, float precio)
        {
            Usuario = usuario;
            TipoSuscripcion = tipoSuscripcion;
            FechaInicio = fechaInicio;
            FechaFinal = fechaFinal;
            Precio = precio;
            // operacionesPDF = new List<OperacionPDF>(); // Inicializa la lista de operaciones PDF
        }
       
        public void ComprarSuscripcion()
        {
            // Implementación de compra de suscripción
        }

        public void ActualizarSuscripcion()
        {
            // Implementación de actualización de suscripción
        }

        public void AgregarOperacionPDF(OperacionPDF operacion)
        {
            //operacionesPDF.Add(operacion); // Agrega una operación PDF a la lista
        }   
    }

}
