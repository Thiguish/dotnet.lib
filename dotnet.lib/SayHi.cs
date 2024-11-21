namespace dotnet.lib;

public class SayHi
{
    private SayHi()
    {
    }

    public static string DiHola(string nombre)
    {
        return $"Hola, {nombre}!";
    }

    public static string SayHello(string nombre)
    {
        return $"Hi, {nombre}!";
    }
}

