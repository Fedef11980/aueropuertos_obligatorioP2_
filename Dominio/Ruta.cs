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
        private int _id;
        private Aeropuerto _aeropuertoSalida;
        private Aeropuerto _aeropuertoLlegada;
        private double _distancia;

        public Ruta(Aeropuerto aeropuertoSalida, Aeropuerto aeropuertoLlegada, double distancia)
        {
            _id = s_ultId;
            s_ultId = s_ultId++;
            _aeropuertoSalida = aeropuertoSalida;
            _aeropuertoLlegada = aeropuertoLlegada;
            _distancia = distancia;
        }

        public override string ToString()
        {
            return $"Vuelo Número: {_id} - Distancia recorrida: {_distancia}\n" +
                $"Aeropuerto de salida: {_aeropuertoSalida}\n" +
                 $"Aeropuerto de Llegada: {_aeropuertoLlegada}";
        }
               
        public void Validar()
        {
            if (_aeropuertoSalida == null) throw new Exception("El aeropuerto de salida no puede ser nulo");
            if (_aeropuertoLlegada == null) throw new Exception("El aeropuerto de llegada no puede ser nulo");
            if (_aeropuertoSalida == _aeropuertoLlegada) throw new Exception("El aeropuerto de salida y el de llegada no pueden ser iguales");
            if (_distancia <= 0) throw new Exception("La distancia debe ser mayor a cero");
        }

        public double Distancia
        {
            get { return _distancia; }
        }

        public double AeropuertoSalida
        {
            get { return _aeropuertoSalida; }
        }

        public double AeropuertoLlegada
        {
            get { return _aeropuertoLlegada; }
        }

        public double TasaAeropuertos()
        {
            double tasas = 0;
            tasas = _aeropuertoSalida.CostoTasa + _aeropuertoLlegada.CostoTasa;
            return tasas;
        }

        public double CostoOperacion()
        {
            double tasas = 0;
            tasas = _aeropuertoSalida.CostoOpracion + _aeropuertoLlegada.CostoOpracion;
            return tasas;
        }
    }
}
