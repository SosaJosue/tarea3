internal class Program
{
    private static void Main(string[] args)
    {
        
        
        estudiante estudiante1 = new estudiante("mateo", "sanchez", 131313945832, "soltero");
        estudiante1.cambioE("");
        estudiante1.imprimir();
        
        
        List<string> materias = new List<string>();
        materias.Add("Matematicas");

        System.Console.WriteLine("desea Matricularse en una nueva materia?");
        string d=Console.ReadLine();
        if(d=="s"){
        materias.Insert(1,"fisica");
        }

        foreach(var dato in materias){
            System.Console.WriteLine("Esta matriculado en: "+dato.ToString());
        }
        
         

        docentes docente1 = new docentes("Camilo","sanchez",11999577829, "casado", 2008, 5, "Matematicas");
        docente1.cambioE("");
        docente1.reasignar(1);
        docente1.cambiod("");
        docente1.imprimir();

        pservicio servicio = new pservicio("Jose", "avila", 14677294869, "Soltero", 2016, 1, "biblioteca");
        servicio.cambioE("");
        servicio.reasignar(2);
        servicio.translado("");
        servicio.imprimir();
    }
}