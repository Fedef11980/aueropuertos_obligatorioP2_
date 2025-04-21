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
    

        public Administrador(string mail, string contrasenia, string apodo): base (mail, contrasenia)
        {
            _apodo = apodo;

        }
        


        //ponerle que el mail tiene que ser unico
        public override void Validar()
        {
            base.Validar();
            if (string.IsNullOrEmpty(_apodo)) throw new Exception("El apodo no puede ser nulo");            
        }

       
    }
}
