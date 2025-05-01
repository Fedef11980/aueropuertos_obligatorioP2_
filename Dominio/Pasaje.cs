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
        private int _id;
        private Vuelo _vuelo;
        private DateTime _fecha;
        private Cliente _cliente;
        private Equipaje _equipaje;
        private double _precio = 0;

        public Pasaje(Vuelo vuelo, DateTime fecha, Cliente cliente, Equipaje equipaje)
        {
            _id = s_ultId;
            s_ultId = s_ultId + 1;
            _vuelo = vuelo;
            _fecha = fecha;
            _cliente = cliente;
            _equipaje = equipaje;
            CalcularPrecio();
        }

        private void CalcularPrecio()
        {
            double costoBase = _vuelo.CostoPorAsiento();
            costoBase = costoBase * 0.25;
            if (_cliente is ClienteOcacional)
            {
                if (_equipaje == "CABINA")
                    costoBase = costoBase * 0.10;
                else if (_equipaje == "BODEGA")
                    costoBase = costoBase * 0.20;
            }
            else if (_cliente is ClientePremium)
            {
                if (_equipaje == "BODEGA")
                    costoBase = costoBase * 0.05;
            }
            double tasas = _vuelo.TasaAeropuertos();
            _precio = costoBase + tasas;
        }

        public override string ToString()
        {
            return $"Pasaje ID: {_id} - Cliente: {_cliente.Nombre} - Vuelo: {_vuelo.NumeroVuelo} - Fecha: {_fecha.ToShortDateString()} \n" +
                $"Equipaje: {_equipaje.ToString()} - Precio: ${_precio}";
        }

        public void Validar()
        {
            if (_vuelo == null) throw new Exception("El vuelo no puede ser nulo.");
            // Validar que la fecha coincida con la frecuencia del vuelo
            if (ValidarVuelo() == false) throw new Exception("La fecha seleccionada no coincide con la frecuencia del vuelo.");
            if (_cliente == null) throw new Exception("El pasajero no puede ser nulo.");
            if (_equipaje == null) throw new Exception("El equipaje no puede ser nulo.");
        }

        private string ConvertirDia(DateTime fecha)
        {
            switch (fecha.DayOfWeek)
            {
                case DayOfWeek.Monday: return "Lunes";
                case DayOfWeek.Tuesday: return "Martes";
                case DayOfWeek.Wednesday: return "Miercoles";
                case DayOfWeek.Thursday: return "Jueves";
                case DayOfWeek.Friday: return "Viernes";
                case DayOfWeek.Saturday: return "Sabado";
                case DayOfWeek.Sunday: return "Domingo";
                default: throw new Exception("Día no válido");
            }
        }

        public bool ValidarVuelo()
        {
            bool coincide = false;
            string FechaSeleccionada = ConvertirDia(_fecha);
            foreach (var d in _vuelo.Frecuencia)
            {
                if (FechaSeleccionada == d.ToString())
                {
                    coincide = true;
                }
            }
            return coincide;
        }
    }
}