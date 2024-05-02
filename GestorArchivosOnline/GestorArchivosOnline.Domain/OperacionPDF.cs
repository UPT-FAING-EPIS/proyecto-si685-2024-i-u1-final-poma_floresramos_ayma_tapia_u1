namespace GestorArchivosOnline.Domain
{
    public abstract class OperacionPDF 
    {
        public PDF? resultado2;
        public  string resultado;

        public abstract string RealizarOperacion();
    }
}
