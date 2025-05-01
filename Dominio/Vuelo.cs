using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Vuelo : IValidable
    {
        private string _numeroVuelo;
        private Ruta _ruta;
        private Avion _avion;
        private List<Dia> _frecuencia;

        public Vuelo(string numeroVuelo, Ruta ruta, Avion avion, List<Dia> frecuencia)
        {
            _numeroVuelo = numeroVuelo;
            _ruta = ruta;
            _avion = avion;
            _frecuencia = frecuencia;
        }

        public override string ToString()
        {
            string frecuenciaDias = string.Join(", ", _frecuencia);
            return $"Vuelo Número: {_numeroVuelo} - Avión: {_avion}\n" +
                   $"Ruta: {_ruta} - Frecuencia: {frecuenciaDias}";
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(_numeroVuelo)) throw new Exception("El número de vuelo no puede ser vacío.");
            ValidarNumeroVuelo();
            if (_ruta == null) throw new Exception("La ruta no puede ser nula.");
            if (_avion == null) throw new Exception("El avión no puede ser nulo.");
            if (_frecuencia == null || _frecuencia.Count == 0) throw new Exception("La frecuencia no puede ser nula.");
            if (_avion.Alcance < _ruta.Distancia) throw new Exception("El avión no tiene el alcance suficiente para cubrir la distancia de la ruta.");
        }

        public void ValidarNumeroVuelo()
        {
            if (_numeroVuelo.Length > 6 || _numeroVuelo.Length < 3) throw new Exception("El número de vuelo debe contener entre 3 y 6 carácteres");

            // Lista de letras
            List<char> listaLetras = new List<char>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz");

            // Verificar que los primeros 2 caracteres sean letras
            string primerosDosDigitos = _numeroVuelo.Substring(0, 2); //  me quedo con los 2 primeros elementos del vuelo
            if (!listaLetras.Contains(primerosDosDigitos[0]) || !listaLetras.Contains(primerosDosDigitos[1])) throw new Exception("Los primeros dos carácteres deben ser letras.");

            // Verificar que el resto sean numeros
            string ultimosDigitos = _numeroVuelo.Substring(2);
            List<char> listaNumeros = new List<char>("0123456789");

            for (int i = 0; i < ultimosDigitos.Length; i++)
            {
                if (!listaNumeros.Contains(ultimosDigitos[i])) throw new Exception("Los carácteres despues de los primeros dos carácteres deben ser números.");

            }
        }

        public double CostoPorAsiento()
        {
            double costoAsiento = 0;
            costoAsiento = (_avion.CostoOperacionKm * _ruta.Distancia) + _ruta.CostoOperacion() / _avion.CantidadAsientos;
            return costoAsiento;
        }

        public double TasaAeropuertos()
        {
            double tasas = 0;
            tasas = _ruta.TasaAeropuertos();
            return tasas;
        }

        public string NumeroVuelo
        {
            get { return _numeroVuelo; }
        }

        public List<Dia> Frecuencia
        {
            get { return _frecuencia; }
        }
    }
}
