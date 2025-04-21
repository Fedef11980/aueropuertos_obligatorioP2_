using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ruta : IValidable
    {
        private static int s_ultId = 1;
        private Aeropuerto _aeropuertoSalida;
        private Aeropuerto _aeropuertoLlegada;
        private double _distancia;

        public Ruta(Aeropuerto aeropuertoSalida, Aeropuerto aeropuertoLlegada, double distancia)
        {
            _aeropuertoSalida = aeropuertoSalida;
            _aeropuertoLlegada = aeropuertoLlegada;
            _distancia = distancia;
        }

        public double Distancia
        {
            get { return _distancia; }
        }   

        public void Validar()
        {
            if (_aeropuertoSalida == null) throw new Exception("El aeropuerto de salida no puede ser nulo");
            if (_aeropuertoLlegada == null) throw new Exception("El aeropuerto de llegada no puede ser nulo");
            if (_distancia <= 0) throw new Exception("La distancia debe ser mayor a cero");
            if (_aeropuertoSalida == _aeropuertoLlegada) throw new Exception("El aeropuerto de salida y el de llegada no pueden ser iguales");
        }
    }
}
