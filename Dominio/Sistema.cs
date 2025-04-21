using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sistema
    {
        private List<Aeropuerto> _aeropuertos = new List<Aeropuerto>();
        private List<Avion> _aviones = new List<Avion>();
        private List<Pasaje> _pasajes = new List<Pasaje>();
        private List<Ruta> _rutas = new List<Ruta>();
        private List<Usuario> _usuarios = new List<Usuario>();
        private List<Vuelo> _vuelos = new List<Vuelo>();


        public Sistema()
        {
            // Pre-cargar datos
            PrecargarAeropuertos();
            PrecargarAviones();
            //PrecargarPasajes();
            //PrecargarRutas();
            PrecargarUsuarios();
            //PrecargarVuelos();
        }


        //Metodos de Agregar
        public void AgregarUsuarios(Usuario u)
        {
            if (u == null) throw new Exception("El usuario no puede ser nulo");
            u.Validar();
            _usuarios.Add(u);
        }

        public void AgregarAviones(Avion a)
        {
            if (a == null) throw new Exception("El avión no puede ser nulo");
            a.Validar();
            _aviones.Add(a);
        }

        public void AgregarAeropuertos(Aeropuerto a)
        {
            if (a == null) throw new Exception("El aeropuerto no puede ser nulo");
            a.Validar();
            _aeropuertos.Add(a);
        }

        public void AgregarPasajes(Pasaje p)
        {
            if (p == null) throw new Exception("El pasaje no puede ser nulo");
            p.Validar();
            _pasajes.Add(p);
        }


        //Precargas

        private void PrecargarAeropuertos()
        {
            AgregarAeropuertos(new Aeropuerto("MVD", "Montevideo", 1500, 25));
            AgregarAeropuertos(new Aeropuerto("EZE", "Buenos Aires", 1800, 30));
            AgregarAeropuertos(new Aeropuerto("GRU", "São Paulo", 2000, 35));
            AgregarAeropuertos(new Aeropuerto("SCL", "Santiago de Chile", 1700, 28));
            AgregarAeropuertos(new Aeropuerto("LIM", "Lima", 1600, 26));
            AgregarAeropuertos(new Aeropuerto("BOG", "Bogotá", 1750, 29));
            AgregarAeropuertos(new Aeropuerto("PTY", "Ciudad de Panamá", 2100, 32));
            AgregarAeropuertos(new Aeropuerto("MEX", "Ciudad de México", 2200, 34));
            AgregarAeropuertos(new Aeropuerto("JFK", "Nueva York", 3000, 50));
            AgregarAeropuertos(new Aeropuerto("MIA", "Miami", 2900, 48));
            AgregarAeropuertos(new Aeropuerto("MAD", "Madrid", 3100, 55));
            AgregarAeropuertos(new Aeropuerto("BCN", "Barcelona", 2950, 52));
            AgregarAeropuertos(new Aeropuerto("CDG", "París", 3200, 58));
            AgregarAeropuertos(new Aeropuerto("FRA", "Frankfurt", 3150, 56));
            AgregarAeropuertos(new Aeropuerto("AMS", "Ámsterdam", 3000, 53));
            AgregarAeropuertos(new Aeropuerto("LHR", "Londres", 3300, 60));
            AgregarAeropuertos(new Aeropuerto("ROM", "Roma", 2900, 49));
            AgregarAeropuertos(new Aeropuerto("DOH", "Doha", 3400, 65));
            AgregarAeropuertos(new Aeropuerto("DXB", "Dubái", 3450, 66));
            AgregarAeropuertos(new Aeropuerto("SYD", "Sídney", 3600, 70));
        }

        private void PrecargarAviones()
        {
            AgregarAviones(new Avion("Boeing", "737 MAX", 180, 6570, 12.5));
            AgregarAviones(new Avion("Airbus", "A320neo", 174, 6300, 11.8));
            AgregarAviones(new Avion("Embraer", "E195-E2", 132, 4800, 9.6));
            AgregarAviones(new Avion("Bombardier", "CRJ900", 90, 2900, 8.2));
        }

        private void PrecargarUsuarios()
        {
            // Administradores
            AgregarUsuarios(new Administrador("juan.admin@airline.com", "admin123", "AdminJuan"));
            AgregarUsuarios(new Administrador("sofia.admin@airline.com", "admin456", "AdminSofia"));

            // Clientes Premium
            AgregarUsuarios(new ClientePremium("12345678", "Luis Pérez", "luis.premium@mail.com", "passLuis", "Uruguayo", 1200));
            AgregarUsuarios(new ClientePremium("87654321", "Ana Torres", "ana.premium@mail.com", "passAna", "Argentina", 2300));
            AgregarUsuarios(new ClientePremium("45678912", "Carlos Gómez", "carlos.premium@mail.com", "passCarlos", "Chileno", 800));
            AgregarUsuarios(new ClientePremium("65432109", "Valeria Díaz", "valeria.premium@mail.com", "passValeria", "Paraguaya", 1500));
            AgregarUsuarios(new ClientePremium("78945612", "Tomás Ruiz", "tomas.premium@mail.com", "passTomas", "Brasileño", 1800));

            // Clientes Ocasionales
            AgregarUsuarios(new ClienteOcacional("32165498", "Camila Soto", "camila.ocasional@mail.com", "passCamila", "Uruguaya", true));
            AgregarUsuarios(new ClienteOcacional("98732145", "Matías Vera", "matias.ocasional@mail.com", "passMatias", "Argentina", false));
            AgregarUsuarios(new ClienteOcacional("65498721", "Lucía Fernández", "lucia.ocasional@mail.com", "passLucia", "Chilena", true));
            AgregarUsuarios(new ClienteOcacional("85296374", "Jorge Acosta", "jorge.ocasional@mail.com", "passJorge", "Peruano", false));
            AgregarUsuarios(new ClienteOcacional("74125896", "Daniela Lima", "daniela.ocasional@mail.com", "passDaniela", "Colombiana", true));
        }

        private void PrecargarPasajes()
        {
            AgregarPasajes(new Pasaje(BuscarVueloPorNumero("AAA123"),DateTime new(2024,01,20),BuscarClientePorDocumento("32165498"), Equipaje.Cabina));
        }

        public Vuelo BuscarVueloPorNumero(string numeroVuelo)
        {
            Vuelo buscado = null;
            int i = 0;
            while (buscado == null && i < _vuelos.Count)
            {
                if (_vuelos[i].NumeroVuelo == numeroVuelo) buscado = _vuelos[i];
                i++;
            }
            return buscado;
        }

        private Cliente BuscarClientePorDocumento(string documento)
        {
            Cliente buscado = null;
            foreach (Usuario u in _usuarios)
            {
                if (u is Cliente c && c.Documento == documento)
                {
                    buscado = c; // o directamente: return c;
                    break;       // ya lo encontró, no sigue buscando
                }
            }
            return buscado;
        }



        
    }
}
