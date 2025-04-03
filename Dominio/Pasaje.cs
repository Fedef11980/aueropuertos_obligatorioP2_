using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pasaje
    {
        private static int s_ultId = 1;
        private Vuelo _vuelo;
        private DateTime _fecha;
        private Cliente _pasajero;
        private Equipaje _equipaje;
        private double _precio = 0;

        public Pasaje(Vuelo vuelo, DateTime fecha, Cliente pasajero, Equipaje equipaje)
        {
            _vuelo = vuelo;
            _fecha = fecha;
            _pasajero = pasajero;
            _equipaje = equipaje;
        }

        public Validar()
        {
            if (_vuelo == null) throw new Exception("El vuelo no puede ser nulo.");
            //fecha: fecha debe ser mayor igual a la fecha de hoy y debe coincidir con la frecuencia del vuelo
            if (_pasajero == null) throw new Exception("El pasajero no puede ser nulo.");
            if (string.IsNullOrEmpty(_equipaje)) throw new Exception("El equipaje no puede ser nulo.");
            if (!EquipajeValido.Contains(_equipaje.ToUpper())) throw new Exception("El equipaje debe ser LIGHT, CABINA o BODEGA.");
        }
    }
}
