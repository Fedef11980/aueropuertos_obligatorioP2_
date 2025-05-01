using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Cliente : Usuario
    {
        protected string _nombre;
        protected string _documento;
        protected string _nacionalidad;

        public Cliente(string mail, string contrasenia, string nombre, string documento, string nacionalidad) : base(mail, contrasenia)
        {
            _nombre = nombre;
            _documento = documento;
            _nacionalidad = nacionalidad; 
        }

        // El documento tiene que ser unico
        public override bool Equals(object? obj)
        {
            Cliente cliente = obj as Cliente;
            return cliente != null && this._documento == cliente._documento;
        }

        public override void Validar()
        {
            base.Validar();
            if (string.IsNullOrEmpty(_nombre)) throw new Exception("El nombre no puede ser nulo");
            if (string.IsNullOrEmpty(_documento)) throw new Exception("El documento no puede ser nulo");
            if (string.IsNullOrEmpty(_nacionalidad)) throw new Exception("La nacionalidad no puede ser nula");
        }

        public string Documento
        {
            get { return _documento; }
        }

        public string Nombre
        {
            get { return _nombre; }
        }

    }
}

