class Persona
{
    private string Nombre;
    private string Direccion;
    private string telefono;
    private int ID;
    private static int autoincremental;

    public Persona(string Nombre, string Direccion, string telefono)
    {
        autoincremental++;
        this.ID = autoincremental;
        this.Nombre = Nombre;
        this.Direccion = Direccion;
        this.telefono = telefono;
    }

    //Metodos getter
    public string getNombre(){return this.Nombre;}
    public string getDireccion(){return this.Direccion;}
    public string getTelefono(){return this.telefono;}
    public int getID(){return this.ID;}
    //Metodos setter
    public void setNombre(string Nombre){this.Nombre = Nombre;}
    public void setDireccion(string direccion){this.Direccion = direccion;}
    public void setTelefono(string telefono){this.telefono = telefono;}
}