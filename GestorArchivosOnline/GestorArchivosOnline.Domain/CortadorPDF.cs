namespace GestorArchivosOnline.Domain
{
    public class CortadorPDF : OperacionPDF 
    {
        public PDF pdfOriginal;
        public string rangoPaginas;
        public void SeleccionarPaginas(string rango) 
        {
            // Implementación de selección de páginas
        }

        public override string RealizarOperacion() 
        {
            return "Operación de corte realizada";
        }
    }
}
