using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClienteOcacional
    {
        private bool _elegibleRegalo;

        public ClienteOcacional(bool elegibleRegalo)
        {
            _elegibleRegalo = elegibleRegalo;
        }
    }
}
