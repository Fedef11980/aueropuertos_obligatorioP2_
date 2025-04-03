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
            if (string.IsNullOrEmpty(_codigoIATA)) throw new Exception("El código IATA no puede estar vacío.");
            if (_codigoIATA.Length != 3) throw new Exception("El código IATA debe tener exactamente 3 caracteres.");
            if (!_codigoIATA.All(char.IsLetter)) throw new Exception("El código IATA debe contener solo letras.");
            if (string.IsNullOrEmpty(_ciudad)) throw new Exception("La ciudad no puede ser nula.");
            if (_costoOperacion > 0) throw new Exception("El costo de operación debe ser mayor a 0.");
            if (_costoTasa > 0) throw new Exception("El costo de tasa debe ser mayor a 0.");
        }
    }
}
