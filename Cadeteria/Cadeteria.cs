class Cadeteria
{
    private string Nombre {get;set;}
    private string telefono {get;set;}
    private List<Cadete> cadetes;

    public Cadeteria(string nombre, string telefono, List<Cadete> cadetes)
    {
        this.Nombre = nombre;
        this.telefono = telefono;
        this.cadetes = cadetes;
    }

    public void MuestraCadetes()
    {
        foreach(var cadete in this.cadetes)
        {
            Console.WriteLine($"Nombre cadete: {cadete.getNombre()}");
            Console.WriteLine($"Direccion: {cadete.getDireccion()}");
            Console.WriteLine($"ID: {cadete.getID()}");
            Console.WriteLine($"Telefono: {cadete.getTelefono()}");
            Console.WriteLine($"Monto a cobrar: {cadete.getJornal()}");
            Console.WriteLine($"Muestra pedidos a su cargo");
            cadete.muestraPedidos();
        }
    }

    //metodos getter
    public string getNombre(){return this.Nombre;}
    public string getTelefono(){return this.telefono;}
    public List<Cadete> getCadetes(){return this.cadetes;}
}