using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Usuario : IValidable
    {
        protected string _mail;
        protected string _contrasenia;

        public Usuario(string mail, string contrasenia)
        {
            _mail = mail;
            _contrasenia = contrasenia;

        }

        public virtual void Validar()
        {
            if (string.IsNullOrEmpty(_mail)) throw new Exception("El mail no puede ser nulo o vacío");
            if (string.IsNullOrEmpty(_contrasenia)) throw new Exception("La contraseña no puede ser nula o vacía");
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
