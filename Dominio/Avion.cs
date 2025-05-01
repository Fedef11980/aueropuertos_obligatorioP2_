using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Avion
    {
        private string _fabricante;
        private string _moelo;
        private int _cantidadAsientos;
        private double _alcance;
        private double _costoOperacionKm;

        public Avion(string fabricante, string modelo, int cantidadAsientos, double alcance, double costoOperacionKm)
        {
            _fabricante = fabricante;
            _moelo = modelo;
            _cantidadAsientos = cantidadAsientos;
            _alcance = alcance;
            _costoOperacionKm = costoOperacionKm;
        }

        public override string ToString()
        {
            return $"El modelo del avion es: {_moelo} \n" +
                $"Cantidad de asientos: {_cantidadAsientos} - Alcance:{_alcance} - Costo de operacion por KM:{_costoOperacionKm} - Fabricante: {_fabricante}";
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(_fabricante)) throw new Exception("El fabricante no puede ser nulo.");
            if (string.IsNullOrEmpty(_moelo)) throw new Exception("El modelo no puede ser nulo.");
            if (_cantidadAsientos < 0) throw new Exception("La cantidad de asientos debe ser mayor a 0.");
            if (_alcance < 0) throw new Exception("El alcacne debe ser mayor a 0.");
            if (_costoOperacionKm < 0) throw new Exception("El costo de operación debe ser mayor a 0.");
        }               

        public double Alcance
        {
            get { return _alcance; }
        }

        public int CantidadAsientos
        {
            get { return _cantidadAsientos; }
        }

        public double CostoOperacionKm
        {
            get { return _costoOperacionKm; }
        }

        public string Fabricante
        {
            get { return _fabricante; }
        }

        public string Modelo
        {
            get { return _moelo; }
        }
    }
}
