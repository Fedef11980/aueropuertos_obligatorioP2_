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
        private Cliente _cliente;
        private Equipaje _equipaje;
        private double _precio = 0;

        public Pasaje(Vuelo vuelo, DateTime fecha, Cliente cliente, Equipaje equipaje)
        {
            _vuelo = vuelo;
            _fecha = fecha;
            _cliente = cliente;
            _equipaje = equipaje;
        }

        public void Validar()
        {
            if (_vuelo == null) throw new Exception("El vuelo no puede ser nulo.");
            //fecha: fecha debe coincidir con la frecuencia del vuelo
            if(_fecha == _vuelo.Frecuencia) throw new Exception("La fecha no coincide con la frecuencia del vuelo.");
            if (_cliente == null) throw new Exception("El pasajero no puede ser nulo.");
            if (_equipaje == null) throw new Exception("El equipaje no puede ser nulo.");
            if (_precio < 0) throw new Exception("El precio no puede ser menor a 0.");
        }


    }
}
