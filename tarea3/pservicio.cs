class pservicio:persona
{
    public int incorporacion {get; set;}
    public int despacho {get; set;}
    public string seccion {get;set;}
    public pservicio(string nombre, string apellido, long cedula, string Ecivil, int incorporacion, int despacho, string seccion):base(nombre, apellido, cedula, Ecivil){
        this.incorporacion = incorporacion;
        this.despacho = despacho;
        this.seccion = seccion;
    }
    public string cambioE(string Ecivil){
        System.Console.WriteLine("desea cambiar el estado civil del personal de servicio?");
        string d=Console.ReadLine();
        
        if(d == "s"){
            System.Console.WriteLine("Escriba su nuevo estado civil:");
            Ecivil = Console.ReadLine();
            return Ecivil;
        }else{return Ecivil;}
        }
        public int reasignar(int despacho)
    {
        System.Console.WriteLine("Desea reasignar despacho del Personal?");
        string d=Console.ReadLine();
        if(d !=""){
            return despacho;
        }else{
            System.Console.WriteLine("A que despacho desea cambiar?");
            despacho=Convert.ToInt32(Console.ReadLine());
            return despacho;
        }
    }
    public string translado(string seccion){
        System.Console.WriteLine("Desea cambiar de seccion?");
        string d=Console.ReadLine();
        if(d=="s"){
            System.Console.WriteLine("A que seccion desea cambiar?");
            seccion= Console.ReadLine();
            return seccion;
        }else{return seccion;}
    }
    public override void imprimir()
    {
        System.Console.WriteLine("El personal de servicio "+nombre+" "+apellido+" con identificacion "+cedula+" estado civil: "+Ecivil);
        System.Console.WriteLine("Se incorporo el "+incorporacion+" numero de despacho: "+despacho+" y trabaja en el area de "+seccion);
    }
}