public class Juego {

    public string Nombre { get; set; }
    public List<TipoJuego> TipoJuego { get; set; }

    public Juego(string nombre);{
        Nombre = nombre;
        TipoJuego = new List<TipoJuego>();
    }

    public void MostrarInformacion() {
        Console.WriteLine($"Nombre: {Nombre}");
        foreach (var tipoJuego in TipoJuego) {
            TipoJuego.MostrarInformacion();
        }
    }
}