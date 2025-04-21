using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Aeropuerto
    {
        private string _codigo;
        private string _ciudad;
        private double _costoOperacion;
        private double _costoTasa;

        public Aeropuerto(string codigo, string ciudad, double costoOperacion, double costoTasa)
        {
            _codigo = codigo;
            _ciudad = ciudad;
            _costoOperacion = costoOperacion;
            _costoTasa = costoTasa;
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(_codigo)) throw new Exception("El codigo no puede ser vacío");         
            if (string.IsNullOrEmpty(_ciudad)) throw new Exception("La ciudad no puede ser nula.");
            if (_costoOperacion > 0) throw new Exception("El costo de operación debe ser mayor a 0.");
            if (_costoTasa > 0) throw new Exception("El costo de tasa debe ser mayor a 0.");
        }
    }
}
