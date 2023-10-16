namespace Tp_en_C_;

public class Cliente{
    static int numActual = 0;
    int NumeroDeCliente;
    string NombreCliente;
    string Apellido; 
    string Documento;
    string TipoDeDocumento;
    string Nacionalidad;
    string Sexo;
    string Cuil;
    Reserva reserva = null;

    public Cliente(string Nom, string Ape, string Doc, string Tip, string Nac, string Se, string C){
        NumeroDeCliente = Interlocked.Increment(ref numActual);
        NombreCliente = Nom;
        Apellido = Ape;
        Documento = Doc;
        TipoDeDocumento = Tip;
        Nacionalidad = Nac;
        Sexo = Se;
        Cuil = C;
    }

    public int ObtenerNumeroCliente(){
        return NumeroDeCliente;
    }

    public string ObtenerCuil(){
        return Cuil;
    }
    public void AsignarReserva(Reserva R){
        reserva = R;
    }
    public Reserva ObtenerReserva(){
        return reserva;
    }
}