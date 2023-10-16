namespace Tp_en_C_;

class Program
{
    static void Main(string[] args)
    {
        Guid messageId = System.Guid.NewGuid();
        Agencia agencia = new Agencia("Despegar");
        Cliente c = new Cliente("Jose","Perez","1234", "DNI","Argentino", "M", "5678");
        DateTime TIEMPO = new DateTime();
        TIEMPO.ToLocalTime();
        List<string> actividades = new List<string>();
        actividades.Add("Tour");
        actividades.Add("Parque de Diversiones");
        Paquete p = new Paquete("Hotel",93, "SI", TIEMPO, actividades);
        agencia.RegistrarCliente(c);
        agencia.RegistrarPaquete(p);
        int numCliente = c.ObtenerNumeroCliente();
        int numeroPaquete = p.ObtenerNumeroPaquete();
        DateTime HoraSalida = new DateTime(2008, 3, 1, 7, 0, 0);
        DateTime HoraLlegada = new DateTime(2008, 3, 2, 17, 0, 0);
        agencia.Reservar(numCliente, numeroPaquete, HoraSalida, HoraLlegada, "Buenos Aires");
        Reserva ReservaCliente = c.ObtenerReserva();
        ReservaCliente.mostrarInfo();
    }
}
