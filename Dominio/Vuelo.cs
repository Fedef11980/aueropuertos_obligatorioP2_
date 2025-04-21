using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Vuelo:IValidable
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

        public string NumeroVuelo
        {
            get { return _numeroVuelo; }
        }

        public List <Dia> Frecuencia
        {
            get { return _frecuencia; }
        }

        
        public void Validar()
        {
            if(string.IsNullOrEmpty(_numeroVuelo)) throw new Exception("El número de vuelo no puede ser vacío");
            if (_ruta == null) throw new Exception("La ruta no puede ser nula");
            if (_avion == null) throw new Exception("El avión no puede ser nulo");
            if (_frecuencia == null || _frecuencia.Count == 0) throw new Exception("La frecuencia no puede ser nula o vacía");
            if (_avion.Alcance < _ruta.Distancia) throw new Exception("El avión no tiene el alcance suficiente para cubrir la distancia de la ruta.");
        }
    }
}
