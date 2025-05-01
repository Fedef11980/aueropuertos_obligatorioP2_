using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Aeropuerto
    {
        private string _codigoIATA;
        private string _ciudad;
        private double _costoOperacion;
        private double _costoTasa;

        public Aeropuerto(string codigo, string ciudad, double costoOperacion, double costoTasa)
        {
            _codigoIATA = codigo;
            _ciudad = ciudad;
            _costoOperacion = costoOperacion;
            _costoTasa = costoTasa;
        }

        public override string ToString()
        {
            return $"Aeropuerto: {_codigoIATA}\n" +
                $" Ciudad de: {_ciudad} - Costo de operacion: {_costoOperacion} - Costo de tasa: {_costoTasa}.";
        }

        // El codigoIATA tiene que ser unico
        public override bool Equals(object? obj)
        {
            Aeropuerto aeropuerto = obj as Aeropuerto;
            return aeropuerto != null && this._codigoIATA == aeropuerto._codigoIATA;
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(_codigoIATA)) throw new Exception("El código no puede ser vacío.");
            if (_codigoIATA.Length != 3) throw new Exception("El código debe tener exactamente 3 caracteres.");
            if (!_codigoIATA.All(char.IsLetter)) throw new Exception("El código IATA debe contener solo letras.");
            if (string.IsNullOrEmpty(_ciudad)) throw new Exception("La ciudad no puede ser nula.");
            if (_costoOperacion < 0) throw new Exception("El costo de operación debe ser mayor a 0.");
            if (_costoTasa < 0) throw new Exception("El costo de tasa debe ser mayor a 0.");
        }

        public string CodigoIATA
        {
            get { return _codigoIATA; }
        }

        public string Ciudad
        {
            get { return _ciudad; }
        }

        public double CostoTasa
        {
            get { return _costoTasa; }
        }

        public double CostoOpracion
        {
            get { return _costoOperacion; }
        }

    }
}
