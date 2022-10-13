class Cliente:Persona
{
    private string DatosReferenciaDireccion;
    public Cliente(string Nombre, string direccion, int telefono, string datosReferencia):base(Nombre,direccion,telefono)
    {
        this.DatosReferenciaDireccion = datosReferencia;
    }

    //Metodo getter
    public string getDatosReferenciaDireccion(){return this.DatosReferenciaDireccion;}
    //Metodo setter
    public void setDatosReferenciaDireccion(string datosReferencia){this.DatosReferenciaDireccion = datosReferencia;}

    public override string ToString()
    {
        return "Nombre: "+this.getNombre()+"---Direccion: "+this.getDireccion()+"---Referencia de direccion: "+this.getDatosReferenciaDireccion()+"---Telefono: "+this.getTelefono()+"---ID: "+this.getID();
    }
}