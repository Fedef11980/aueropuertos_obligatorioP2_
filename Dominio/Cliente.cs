using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        private string _documento;
        private string _nombre;
        private string _mail;
        private string _contrasenia;
        private string _nacionalidad;
        private ClienteOcacional _clienteOcacional;
        private ClientePremium _clientePremium;

        public Cliente(string documento, string nombre, string mail, string contrasenia, string nacionalidad, ClienteOcacional clienteOcacional, ClientePremium clientePremium)
        {
            _documento = documento;
            _nombre = nombre;
            _mail = mail;
            _contrasenia = contrasenia;
            _nacionalidad = nacionalidad; ;
            _clienteOcacional = clienteOcacional;
            _clientePremium = clientePremium;
        }

        //ponerle que el mail tiene que ser unico
        //ponerle que el documeto tiene que ser unico
    }
}
}
