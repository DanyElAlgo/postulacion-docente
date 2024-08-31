using Microsoft.VisualBasic;

public class UsuarioService : IUsuarioService
{

    public void registrarUsuario()
    {
        System.Console.WriteLine("Registro de usuario");
    }
    public bool validarUsuario(){
        System.Console.WriteLine("Usuario validado");

        return true;
    }

    public void eliminarUsuario()
    {
        System.Console.WriteLine("Usuario eliminado");
    }

    public void modificarUsuario()
    {
        System.Console.WriteLine("Usuario modificado");
    }



}
