using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Administrador
    {
        private string _apodo;
        private string _mail;
        private string _contrasenia;

        public Administrador(string apodo, string mail, string contrasenia)
        {
            _apodo = apodo;
            _mail = mail;
            _contrasenia = contrasenia;
        }


        //ponerle que el mail tiene que ser unico

        public void Validar()
        {
            if (string.IsNullOrEmpty(_apodo)) throw new Exception("El apodo no puede ser nulo");
            if (string.IsNullOrEmpty(_mail)) throw new Exception("El mail no puede ser nulo");
            if (string.IsNullOrEmpty(_contrasenia)) throw new Exception("La constraeña no puede ser nula");
            ValidarMail();
        }

        public void ValidarMail()
        {
            if (_mail.Length < 5) throw new Exception("El correo electrónico debe tener al menos 5 caracteres.");
            if (!_mail.Contains("@")) throw new Exception("El correo electrónico debe contener '@'.");
            if (!_mail.Contains(".")) throw new Exception("El correo electrónico debe contener un punto '.'.");
            if (!_mail.Contains("com")) throw new Exception("El correo electrónico debe contener '.com'.");
        }
    }
}
