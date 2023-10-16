namespace Tp_en_C_;

public class Factura{
    static int numActual = 0;
    int NumeroDeFactura;
    string Descripcion;
    string CuilCliente;

    public Factura(string d, string c){
        NumeroDeFactura = Interlocked.Increment(ref numActual);
        Descripcion = d;
        CuilCliente = c;
    }

    public int ObtenerNumeroFactura(){
        return NumeroDeFactura;
    }

    public string ObtenerCuil(){
        return CuilCliente;
    }
}