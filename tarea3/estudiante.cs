class estudiante:persona
{

    public estudiante(string nombre, string apellido, long cedula, string Ecivil):base(nombre, apellido, cedula, Ecivil){
        
    }
    
    public string cambioE(string Ecivil){
        System.Console.WriteLine("desea cambiar el estado civil del estudiante?");
        string d=Console.ReadLine();
        
        if(d == "s"){
            System.Console.WriteLine("Escriba su nuevo estado civil:");
            Ecivil = Console.ReadLine();
            return Ecivil;
        }else{return Ecivil;}
    }


    public override void imprimir()
    {
        System.Console.WriteLine("El estudiante "+nombre+" "+apellido+" con identificacion "+cedula+" estado civil: "+Ecivil);
    }
}