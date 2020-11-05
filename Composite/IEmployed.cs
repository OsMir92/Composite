namespace Composite
{   /*Clase abstracta que contiene miembros que serán implementados 
    por todos los objetos de la jerarquía. 
    Actúa como la clase base para todos los objetos de la jerarquía*/
    public interface IEmployed
    {   
        int EmployeeID { get; set; }
        string EmployeeName { get; set; }
    }
}
