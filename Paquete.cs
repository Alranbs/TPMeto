namespace Tp_en_C_;

public class Paquete {
    static int numActual = 0;
    int NumeroDePaquete;
    string Alojamiento;
    int IDVehiculo;
    string Asistencia;
    DateTime DuracionViaje;
    List<string> actividades;

    public Paquete(string A, int IDV, string As, DateTime Dur, List<string>act){
        NumeroDePaquete = Interlocked.Increment(ref numActual);
        Alojamiento = A;
        IDVehiculo = IDV;
        Asistencia = As;
        DuracionViaje = Dur;
        actividades = act;
    }

    public int ObtenerNumeroPaquete(){
        return NumeroDePaquete;
    }
}
