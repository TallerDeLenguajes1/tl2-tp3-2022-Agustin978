using NLog;
class Cadete : Persona
{
    private float jornalACobrar;
    private List<Pedido> pedidos;
    private Logger logger = LogManager.GetCurrentClassLogger();
    public Cadete(string Nombre, string Direccion, int telefono, List<Pedido> pedidos):base(Nombre, Direccion, telefono)
    {
        this.pedidos = pedidos;
    }
    public Pedido getPedidos(int pedido){return this.pedidos[pedido];}
    public float getJornal(){return this.jornalACobrar;}

    private void calculaJornalTotal()
    {
        foreach(var pedido in this.pedidos)
        {
            if(string.Equals(pedido.getEstadoPedido(),"Entregado"))
            {
                this.jornalACobrar += 300;
                this.logger.Trace($"El cadete {this.getNombre()}, con id {this.getID()}, realizo una entrega");
            }
        }
    }

    public void agregaPedido(Pedido p)
    {
        this.pedidos.Add(p);
        this.logger.Trace($"Se ingreso un nuevo pedido al cadete {this.getNombre()}");
    }
}