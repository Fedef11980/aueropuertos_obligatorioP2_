using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Administrador : Usuario
    {
        private string _apodo;

        public Administrador(string mail, string contrasenia, string apodo) : base(mail, contrasenia)
        {
            _apodo = apodo;
        }

        public override string ToString()
        {
            return $"Apodo del Administrdaor: {_apodo}, Mail del Administrdaor: {_mail}, Contraeña del Administrdaor {_contrasenia}.";
        }

        public override void Validar()
        {
            base.Validar();
            if (string.IsNullOrEmpty(_apodo)) throw new Exception("El apodo no puede ser nulo o vacío");
        }

        // Modificar los puntos de un cliente premium
        public void ModificarPuntosClientePremium(ClientePremium cliente, int nuevosPuntos)
        {
            cliente.CambiarPuntos(nuevosPuntos);
        }

        // Cambiar elegibilidad de un cliente ocasional
        public void CambiarEstadoElegible(ClienteOcacional cliente, bool elegible)
        {
            cliente.CambiarElegibilidadRegalo(elegible);
        }

    }
}