namespace dotnet.lib;

public class SayHi
{
    private SayHi()
    {
    }

    public static string SayHello(string nombre)
    {
        return $"Hola, {nombre}!";
    }
}

