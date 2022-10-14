using NLog;
using System.IO;
Logger logger = LogManager.GetCurrentClassLogger();
main();
int main()
{
    string path = @"C:\Cursos\Programacion_UNT\Taller_de_Lenguajes_2\tl2-tp3-2022-Agustin978\Cadeteria\Files\cadeteria";
    string ext = ".csv";
    List<Pedido> pedidos1 = new List<Pedido>();
    List<Pedido> pedidos2 = new List<Pedido>();
    Pedido pedido1 = new Pedido("Con salsa", 0, 2.52, "Agustin", "Rojas Paz 33", "3816431774", "Cerca del parque Guillermina");
    Pedido pedido2 = new Pedido("Con queso", 0, 3, "Ignacio", "Rojas Paz 75", "3816431874", "Cerca del parque");
    Pedido pedido3 = new Pedido("Con coca", 0, 3, "Esteban", "Niidea 25", "3816432364", "Cerca");
    Pedido pedido4 = new Pedido("No quiero el pedido", 0, 100, "Quca", "No te voy a decir", "000000000", "Me mando a la mierda");

    pedidos1.Add(pedido1);
    pedidos1.Add(pedido2);
    pedidos2.Add(pedido3);
    pedidos2.Add(pedido4);

    Cadete cadete1 = new Cadete("Agustin", "Rojas paz 21", "4355105", pedidos1);
    Cadete cadete2 = new Cadete("Estirado", "Bajo el puente Roca", "0000000", pedidos2);
    List<Cadete> cadetes = new List<Cadete>();
    cadetes.Add(cadete1);
    cadetes.Add(cadete2);
    Cadeteria cadeteria = new Cadeteria("Sistema de cadetes de Agustin", "0000000", cadetes);
    cadete2.eliminaPedido(4);
    cadete1.agregaPedido(pedido4);
    cadeteria.MuestraCadetes();
    GuardaArchivo(path, ext, cadeteria);

    try
    {
        //Console.WriteLine($"\n Veamos: \n{GetObjectCSVFromFile(path,ext)}");
        GetObjectCSVFromFile(path,ext);
    }catch(Exception ex)
    {
        //Mensaje de error (que sucedio)
        var mensaje = "Mensaje de error: "+ex.Message;
        //Informacion sobre la excepcion interna
        if(ex.InnerException != null)
        {
            mensaje += " ---- Inner exception: "+ex.InnerException.Message;
        }
        //Donde sucedio el error
        mensaje += " ---- Stack trace: "+ex.StackTrace;
        logger.Error(mensaje);
    }
    return 0;
}

void GuardaArchivo(string path, string ext, Cadeteria cadeteria)
{
    FileStream miArchivo = new FileStream(path+ext, FileMode.OpenOrCreate);
    using(StreamWriter strWriter = new StreamWriter(miArchivo))
    {
        //strWriter.Write("{0};{1};{2}", );
        foreach(var cadete in cadeteria.getCadetes())
        {
            strWriter.Write("{0};{1};{2}\n", cadeteria.getNombre(), cadeteria.getTelefono(), cadete.getNombre());
            //Coloco el simbolo + para luego hacer el deserealizado del archivo con este caracter especial
        }
    }
}

//Funcion para retornar un string con todo lo encontrado en el archivo
void GetObjectCSVFromFile(string path, string ext)
{
    /*
    string CSVObject;
    FileStream miArchivo = new FileStream(path+ext, FileMode.Open);
    using(StreamReader strReader = new StreamReader(miArchivo))
    {
        CSVObject = strReader.ReadToEnd();
    }
    return CSVObject;
    */
    string[] CSVObject = File.ReadAllLines(path+ext);
    foreach(var obj in CSVObject)
    {
        var valores = obj.Split(";");
        Console.WriteLine($"->Nombre cadeteria: {valores[0]}\n->Telefono: {valores[1]}\n->Cadete: {valores[2]}");
    }
}
/*
void DeserializeCSV(string CSVObject)
{
    string[] ObjectSeparado = CSVObject.Split("+");
    foreach(var elemento in ObjectSeparado)
    {
        List<Cadete> cadetes = 
    }
}*/