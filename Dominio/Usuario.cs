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

        // El mail tiene que ser unico
        public override bool Equals(object obj)
        {
            Usuario u = obj as Usuario;
            return this._mail == u._mail;
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
            ValidarArroba();
            if (!_mail.Contains(".")) throw new Exception("El correo electrónico debe contener un punto '.'.");
            if (!(_mail.EndsWith(".com") || !_mail.Contains(".com")) throw new Exception("El correo electrónico debe terminar en '.com'.");
        }

        public void ValidarArroba()
        {
            bool tieneArroba = false;
            int posicionArroba = -1;

            for (int i = 0; i < _mail.Length; i++)
            {
                if (_mail[i] == '@')
                {
                    tieneArroba = true;
                    posicionArroba = i;
                    break; // Si tiene arroba salgo
                }
            }

            // Si no tiene arroba, muestro mensaje
            if (!tieneArroba)
                throw new Exception("El correo electrónico debe contener '@'.");

            // Constrolo que el arroba no sea la primer ni la ultima letra
            if (posicionArroba == 0 || posicionArroba == _mail.Length - 1) throw new Exception("El '@' no puede estar al principio ni al final.");
        }


    }
}
