using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClientePremium : Cliente
    {
        private int _puntos;

        public ClientePremium(string documento, string nombre, string mail, string contrasenia, string nacionalidad, int puntos): base (documento, nombre, mail, contrasenia, nacionalidad)
        {
            _puntos = puntos;
        }

        public override void Validar()
        {
            base.Validar();
            if (_puntos < 0) throw new Exception("Los puntos no pueden ser negativos.");
        }

        public override string ToString()
        {
            return $"Cliente Ocacional: {_nombre} - Mail: {_mail} - Nacionalidad: {_nacionalidad}\n" +
                $"Cantidad de Puntos: {_puntos}";
        }

        public bool Puntos
        {
            get { return _puntos; }
        }

        public void CambiarPuntos(int puntos)
        {
            _puntos = puntos;
        }

    }
}
