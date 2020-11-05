using System.Collections;
using System.Collections.Generic;
/*Clase que incluye los métodos de Agregar, Eliminar, Encontrar 
 * y Obtener para hacer operaciones en componentes hijos(hojas).*/
namespace Composite
{
    internal class Employee : IEmployed , IEnumerable<IEmployed> //Se utiliza colecciones por iteración
    {
        private List<IEmployed> _subordinates = new List<IEmployed>();

        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }

        public void AddSubordinate(IEmployed subordinate)
        {
            _subordinates.Add(subordinate);
        }

        public void RemoveSubordinate(IEmployed subordinate)
        {
            _subordinates.Remove(subordinate);
        }

        public IEmployed GetSubordinate(int index)
        {
            return _subordinates[index];
        }

        public IEnumerator<IEmployed> GetEnumerator()
        {
            foreach (IEmployed subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
