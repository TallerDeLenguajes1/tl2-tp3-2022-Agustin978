using NLog;
class Cadete : Persona
{
    private float jornalACobrar;
    private List<Pedido> pedidos;
    private Logger logger = LogManager.GetCurrentClassLogger();
    public Cadete(string Nombre, string Direccion, string telefono, List<Pedido> pedidos):base(Nombre, Direccion, telefono)
    {
        this.pedidos = pedidos;
    }
    public Pedido getPedido(int pedido){return this.pedidos[pedido];}
    public List<Pedido> getPedidos(){return this.pedidos;}
    public float getJornal(){return this.jornalACobrar;}

    private void calculaJornalTotal()
    {
        foreach(var pedido in this.pedidos)
        {
            if(string.Equals(pedido.getEstadoPedido(),"Entregado"))
            {
                this.jornalACobrar += 300;
                this.logger.Info($"El cadete {this.getNombre()}, con id {this.getID()}, realizo una entrega");
            }
        }
    }

    public void agregaPedido(Pedido p)
    {
        this.pedidos.Add(p);
        this.logger.Info($"Se ingreso un nuevo pedido al cadete {this.getNombre()}");
    }

    public void eliminaPedido(int nro)
    {
        foreach(var pedido in this.pedidos.ToArray())
        {
            if(pedido.getNroPedido() == nro)
            {
                this.pedidos.Remove(pedido);
                this.logger.Info($"Se elimino un pedido al cadete {this.getNombre()}");
            }
        }
    }

    public void muestraPedidos()
    {
        foreach(var pedido in this.pedidos)
        {
            pedido.muestraPedido();
            Console.WriteLine("\n");
        }
    }
}