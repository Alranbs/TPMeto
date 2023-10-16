using System.Collections.Generic;

namespace Tp_en_C_;

public class Agencia {
    string NombreAgencia;
    List<Cliente> clientes = new List<Cliente>();
    List<Factura> facturas = new List<Factura>();
    List<Paquete> paquetes = new List<Paquete>();

    public Agencia(string N){
        NombreAgencia = N;
    }

    public void Reservar(int NumeroCliente, int NumeroPaquete, DateTime HoraSalida, DateTime HoraLlegada, string Ciudad){
        Cliente ClienteActual = ObtenerCliente(NumeroCliente);
        Paquete PaqueteBase = ObtenerPaquete(NumeroPaquete);
        Reserva NuevaReserva = new Reserva();
        Vuelo NuevoVuelo = new Vuelo(HoraSalida, HoraLlegada, Ciudad);
        NuevaReserva.AsignarPaquete(PaqueteBase);
        NuevaReserva.AsignarVuelo(NuevoVuelo);
        string Cuil = ClienteActual.ObtenerCuil();
        Factura NuevaFactura = new Factura("", Ciudad);
        RegistrarFactura(NuevaFactura);
        ClienteActual.AsignarReserva(NuevaReserva);
    }

    public void RegistrarCliente(){
        Console.WriteLine("Ingrese el nombre del Cliente");
        string NombreCliente = Console.ReadLine(); 
        Console.WriteLine("Ingrese el apellido del Cliente");
        string ApellidoCliente = Console.ReadLine();         
        Console.WriteLine("Ingrese el documento del Cliente");
        string DocumentoCliente = Console.ReadLine();         
        Console.WriteLine("Ingrese el tipo de documento del Cliente");
        string TipoDocCliente = Console.ReadLine();         
        Console.WriteLine("Ingrese la nacionalidad del Cliente");
        string NacionalidadCliente = Console.ReadLine();         
        Console.WriteLine("Ingrese el sexo del Cliente");
        string SexoCliente = Console.ReadLine();         
        Console.WriteLine("Ingrese el cuil del Cliente");        
        string CuilCliente = Console.ReadLine();                                                 
        Cliente Cliente = new Cliente(NombreCliente, ApellidoCliente, DocumentoCliente, TipoDocCliente, NacionalidadCliente, SexoCliente, CuilCliente);
        clientes.Add(Cliente);
    }

    public void RegistrarCliente(Cliente c){
        clientes.Add(c);
    }

    public void EliminarCliente(Cliente c){
        clientes.Remove(c);
    }    
    public Cliente ObtenerCliente(int numeroCliente){
        foreach(Cliente elem in clientes)
        {
            if (elem.ObtenerNumeroCliente() == numeroCliente){
                return elem;
            }
            
        }
        return null;
    }    

    public void RegistrarFactura(Factura f){
        facturas.Add(f);
    }
    public void EliminarFactura(Factura f){
        facturas.Remove(f);
    }
    public Factura ObtenerFactura(int numeroFactura){
        foreach(Factura elem in facturas)
        {
            if (elem.ObtenerNumeroFactura() == numeroFactura){
                return elem;
            }
        }
        return null;        
    }
    public void RegistrarPaquete(){
        Console.WriteLine("Ingrese el alojamiento del Paquete");
        string Alojamiento = Console.ReadLine();
        Console.WriteLine("Ingrese el vehiculo del Paquete");
        int Idv = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la asistencia del Paquete");
        string Asistencia = Console.ReadLine();
        Console.WriteLine("Ingrese la duracion del viaje del Paquete");
        string Duracion = Console.ReadLine();
        DateTime Dur = new DateTime();
        Console.WriteLine("Ingrese las actividades del Paquete");
        string Actividad = Console.ReadLine();
        List<string> Actividades = new List<string>();
        Actividades.Add(Actividad);
        Paquete Paquete = new Paquete(Alojamiento, Idv, Asistencia, Dur, Actividades);
        paquetes.Add(Paquete);
    }
    public void RegistrarPaquete(Paquete p){
        paquetes.Add(p);
    }
    public void EliminarPaquete(Paquete p){
        paquetes.Remove(p);
    }
    public Paquete ObtenerPaquete(int numeroPaquete){
        foreach(Paquete elem in paquetes)
        {
            if (elem.ObtenerNumeroPaquete() == numeroPaquete){
                return elem;
            }
        }
        return null;        
    }    
}