public class TipoJuego {
    public string Genero { get; set; }  
    public string Modalidad{ get; set; }
    public string Graficos { get; set; }
    public string Plataforma { get; set; }

    public TipoJuego(string genero, string modalidad, string graficos, string plataforma) {
        Genero = genero;
        Modalidad = modalidad;
        Graficos = graficos;
        Plataforma = plataforma;
    }

    public void MostrarInformacion() {
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Modalidad: {Modalidad}");
        Console.WriteLine($"Graficos: {Modalidad}");
        Console.WriteLine($"Plataforma: {Plataforma}");
    }
}