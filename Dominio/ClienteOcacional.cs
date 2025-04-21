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

        public ClienteOcacional(string documento,string nombre, string mail, string contrasenia, string nacionalidad, bool elegibleRegalo): base(documento, nombre, mail, contrasenia, nacionalidad)
        {
            _elegibleRegalo = elegibleRegalo;
        }

        public override void Validar()
        {
            base.Validar();
            if (_elegibleRegalo == false) throw new Exception("El cliente no es elegible para regalo");
        }



    }
}
