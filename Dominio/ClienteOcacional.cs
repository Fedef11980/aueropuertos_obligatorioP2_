using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClienteOcacional : Cliente
    {
        private bool _elegibleRegalo;

        public ClienteOcacional(string documento, string nombre, string mail, string contrasenia, string nacionalidad, bool elegibleRegalo) : base(documento, nombre, mail, contrasenia, nacionalidad)
        {
            // El atribuo "elegible regalo" se settea de forma aleatoria al entrar al sistema
            // Para esto se trabajara con la hora del sistema, si el segundo en el cual se hace el alta es par se le asigna TRUE
            int segundo = DateTime.Now.Second; // Tomo el segundo actual del sistema 
            _elegibleRegalo = segundo % 2 == 0; // Si el segundo es par setteo TRUE, sino FALSE
        }

        public override string ToString()
        {
            string elegible = "NO";
            if (_elegibleRegalo) elegible = "SI";
            return $"Cliente Ocacional: {_nombre} - Mail: {_mail} - Nacionalidad: {_nacionalidad}\n" +
                $"Elegible para regalo: {elegible}";
        }

        public bool ElegibleRegalo
        {
            get { return _elegibleRegalo; }
        }

        public void CambiarElegibilidadRegalo(bool elegible)
        {
            _elegibleRegalo = elegible;
        }

    }
}
