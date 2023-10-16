namespace Tp_en_C_;

public class Reserva {
    static int numActual = 0;
    int NumeroDeReserva;
    DateTime FechaDeReserva = new DateTime();
    Paquete paquete = null;
    Vuelo vuelo = null;

    public Reserva()
    {
        NumeroDeReserva = Interlocked.Increment(ref numActual);
        FechaDeReserva = DateTime.Now;
    }
    public void AsignarPaquete(Paquete p){
        paquete = p;
    }

    public void AsignarVuelo(Vuelo v){
        vuelo = v;
    }
    public void mostrarInfo(){
        Console.WriteLine("Numero de Reserva: " + NumeroDeReserva);
        Console.WriteLine("Fecha de Reserva: " + FechaDeReserva.ToString());
        Console.WriteLine("Numero de Paquete: " + paquete.ObtenerNumeroPaquete());
        Console.WriteLine("Numero de Vuelo: " + vuelo.ObtenerNumeroVuelo());
    }
}