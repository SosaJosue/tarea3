class persona
{
    public string nombre {get; set;}
    public string apellido {get; set;}
    public long cedula {get; set;}
    public string Ecivil {get; set;}

    public persona (string nombre, string apellido, long cedula, string Ecivil){
        this.nombre = nombre;
        this.apellido = apellido;
        this.cedula = cedula;
        this.Ecivil = Ecivil;
    }
    
    public virtual void imprimir()
    {}
}