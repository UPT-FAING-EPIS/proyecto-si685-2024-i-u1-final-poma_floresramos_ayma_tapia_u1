namespace GestorArchivosOnline.Domain
{
    public class FusionadorPDF : OperacionPDF 
    {
         public List<PDF> pdfsParaFusionar = new List<PDF>();
        public void AgregarPDF(string pdf) 
        {
            // Implementación de agregar un PDF a la lista de fusionar
        }

        public void EliminarPDF(string pdf) 
        {
            // Implementación de eliminar un PDF de la lista de fusionar
        }

        public override string RealizarOperacion() 
        {
            return "Operación de fusión realizada";
        }
    }
}
