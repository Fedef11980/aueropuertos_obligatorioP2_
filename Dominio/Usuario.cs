using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        private Cliente _cliente;
        private Administrador _administrador;

        public Usuario(Cliente cliente, Administrador administrador)
        {
            _cliente = cliente;
            _administrador = administrador;
        }
    }
}
