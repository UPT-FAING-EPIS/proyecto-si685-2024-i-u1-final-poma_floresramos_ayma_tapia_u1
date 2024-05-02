using System;

namespace GestorArchivosOnline.Domain
{
    public class ListaDeOperacionesSuscripcionUsuario 
    {
        public DetalleSuscripcionUsuario suscripcionUsuario { get; private set; }
        public OperacionPDF operacionPDF;
        public DateTime fechaRealizacion;

        public ListaDeOperacionesSuscripcionUsuario(DetalleSuscripcionUsuario suscripcionUsuario, OperacionPDF operacionPDF, DateTime fechaRealizacion) 
        {
            this.suscripcionUsuario = suscripcionUsuario;
            this.operacionPDF = operacionPDF;
            this.fechaRealizacion = fechaRealizacion;
        }

        public string RealizarOperacion() 
        {
            return operacionPDF.RealizarOperacion();
        }
    }
}
