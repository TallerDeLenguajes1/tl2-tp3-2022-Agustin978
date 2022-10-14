using static Cliente;
class Pedido
{
    private static int autoIncremental;
    private int NroPedido;
    private string observacion {get;set;}
    private Cliente? cliente = null;
    private string[] estado = new string[4] {"Tomado", "En proceso", "Despachado", "Entregado"};
    private string estadoP;
    private double montoPaga;

    public Pedido(string observacion, int estado, double monto, string NombreCli, string direccion, string telefonoCli, string datosRefCli)
    {
        autoIncremental++;
        this.NroPedido = autoIncremental;
        this.observacion = observacion;
        this.estadoP = this.estado[estado];
        this.montoPaga = monto;
        CreaCliente(NombreCli, direccion, telefonoCli, datosRefCli);
    }

    //Metodo getter
    public int getNroPedido(){return this.NroPedido;}
    public string getObservacion(){return this.observacion;}
    public Cliente GetCliente(){return this.cliente;}
    public string getEstadoPedido(){return this.estadoP;}

    public double getMontoPagar(){return this.montoPaga;}

    //Metodo para mostrar el pedido
    public void muestraPedido()
    {
        Console.WriteLine($"------------------Nro Pedido:  {this.getNroPedido()}");
        Console.WriteLine("======================================");
        Console.WriteLine($"Monto a pagar:               $ {this.getMontoPagar()}");
        Console.WriteLine($"Nombre cliente:                {this.GetCliente().getNombre()}");
        Console.WriteLine($"Direccion:                     {this.GetCliente().getDireccion()}");
        Console.WriteLine($"Datos de referencia:           {this.GetCliente().getDatosReferenciaDireccion()}");
        Console.WriteLine($"Telefono:                      {this.GetCliente().getTelefono()}");
        Console.WriteLine($"Id:                            {this.GetCliente().getID()}");
        Console.WriteLine($"Estado del pedido:             {this.getEstadoPedido()}");
    }

    //Metodo para crear al cliente
    private void CreaCliente(string NombreCli, string direccion, string telefonoCli, string datosRefCli)
    {
        this.cliente = new Cliente(NombreCli, direccion, telefonoCli, datosRefCli);
    }
}   