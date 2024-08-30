public class Formulario{
    public Docente? postulante {get;set;}
    public List<Documento>? documentos {get;set;}
    public void enviarDocumento(){
        if(Sistema.verificarNuevaPostulacion(this)){
            System.Console.WriteLine("Enviado con éxito");
            return;
        }
        System.Console.WriteLine("Hubo un error, verifica tus datos e intenta de nuevo");
        return;
    }
}