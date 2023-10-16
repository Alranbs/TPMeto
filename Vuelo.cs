namespace Tp_en_C_;

public class Vuelo {
    static int numActual = 0;
    int NumeroDeVuelo;
    DateTime HoraSalida;
    DateTime HoraLlegada;
    string Ciudad;

    public Vuelo(DateTime HS, DateTime HL, string C){
        NumeroDeVuelo = Interlocked.Increment(ref numActual);
        HoraSalida = HS;
        HoraLlegada = HL;
        Ciudad = C;
    }

    public int ObtenerNumeroVuelo(){
        return NumeroDeVuelo;
    }
}