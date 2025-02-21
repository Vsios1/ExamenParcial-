using System;

public class JuegoMemoria
{
    public string Tematica { get; set; }
    public int Fichas { get; set; }
    public int Tiempo { get; set; } 

    public JuegoMemoria(string tematica, int fichas, int tiempo)
    {
        Tematica = tematica;
        Fichas = fichas;
        Tiempo = tiempo;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("=== Información del Juego de Memoria ===");
        Console.WriteLine($"Temática: {Tematica}");
        Console.WriteLine($"Cantidad de Fichas: {Fichas}");
        Console.WriteLine($"Tiempo Límite: {Tiempo} minutos");
    }
}
