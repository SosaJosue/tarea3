class docentes:persona
{
    public int incorporacion {get; set;}
    public int despacho {get; set;}
    public string departamento {get; set;}

    public docentes(string nombre, string apellido, long cedula, string Ecivil,int incorporacion, int despacho, string departamento):base(nombre, apellido, cedula, Ecivil){
        this.incorporacion = incorporacion;
        this.despacho = despacho;
        this.departamento = departamento;
    }
    public string cambioE(string Ecivil){
        System.Console.WriteLine("desea cambiar el estado civil del docente?");
        string d=Console.ReadLine();
        
        if(d == "s"){
            System.Console.WriteLine("Escriba su nuevo estado civil:");
            Ecivil = Console.ReadLine();
            return Ecivil;
        }else{return Ecivil;}
        }
    public int reasignar(int despacho){
        System.Console.WriteLine("Desea reasignar despacho del docente?");
        string d=Console.ReadLine();
        if(d !=""){
            return despacho;
        }else{
            System.Console.WriteLine("A que despacho desea cambiar?");
            despacho=Convert.ToInt32(Console.ReadLine());
            return despacho;
        }
    }
    public string cambiod(string departamento){
        System.Console.WriteLine("Desea cambiar de departamento?");
        string d=Console.ReadLine();
        if(d=="s"){
            System.Console.WriteLine("A que departamento desea cambiar?");
            departamento=Console.ReadLine();
            return departamento;
        }else{return departamento;}

    }
    public override void imprimir()
    {
        System.Console.WriteLine("El docente "+nombre+" "+apellido+" con identificacion "+cedula+" estado civil: "+Ecivil);
        System.Console.WriteLine("Se incorporo el "+incorporacion+" numero de despacho: "+despacho+" y da la materia de "+departamento);
    }
    
}