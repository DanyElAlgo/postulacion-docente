public class DocumentoService: IDocumentoService
{
    public void guardarDocumento()
    {
        System.Console.WriteLine("El documento ser guardo correctamente");
    }

    public bool revisarDocumento()
    {
        System.Console.WriteLine("El documento esta correctamente estructurado");

        return true;
    }
}