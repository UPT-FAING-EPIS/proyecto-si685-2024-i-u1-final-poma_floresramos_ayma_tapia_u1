namespace GestorArchivosOnline.Domain
{
    public class PDF{
       public string nombre;
       public string contenido;
    
    public PDF(string nombre, string contenido)
        {
            
            this.nombre = nombre;
            this.contenido = contenido;
        }
   
    public string  ObtenerNombre()
    {
        return nombre;
    }
   
    public string ObtenerContenido()
    {
        return contenido;
        
    }
    }
}