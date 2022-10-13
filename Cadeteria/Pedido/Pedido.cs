using static Cliente;
class Pedido
{
    private static int autoIncremental;
    private int NroPedido;
    private string observacion {get;set;}
    private Cliente cliente;
    private string[] estado = new string[3] {"Tomado", "En proceso", "Despachado"};
    private string estadoP;

    public Pedido(string observacion, Cliente cliente, int estado)
    {
        autoIncremental++;
        this.NroPedido = autoIncremental;
        this.observacion = observacion;
        this.cliente = cliente;
        this.estadoP = this.estado[estado];
    }

    //Metodo getter

}   