﻿namespace dotnet.lib;

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
        return $"Hi {nombre}!";
    }
    public static string DiBonDia(string nombre)
    {
        return $"Bon dia {nombre}!";
    }

    public static string DiBuenosDias(string nombre)
    {
        return $"Buenos dias {nombre}!";
    }

    public static string SayGoodMorning(string nombre)
    {
        return $"Good morning {nombre}!";
    }

    public static string DiBonaNit(string nombre)
    {
        return $"Bona nit {nombre}!";
    }

    public static string SayGoodNight(string nombre)
    {
        return $"Good night {nombre}!";
    }

    public static string SayHello()
    {
        return $"Hello!";
    }
    public static string DiHola()
    {
        return $"Hola!";
    }
    public static string DiSalut()
    {
        return $"Salut!";
    }
}

