using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    // Clase "Hoja"
    public class Contractor : IEmployed
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
    }
}
