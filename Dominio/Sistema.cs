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

        // Getters
        public List<Aeropuerto> ListaAeropuertos
        {
            get { return _aeropuertos; }
        }
        public List<Avion> ListaAviones
        {
            get { return _aviones; }
        }
        public List<Pasaje> ListaPasajes
        {
            get { return _pasajes; }
        }
        public List<Ruta> ListaRutas
        {
            get { return _rutas; }
        }
        public List<Usuario> ListaUsuarios
        {
            get { return _usuarios; }
        }
        public List<Vuelo> ListaVuelos
        {
            get { return _vuelos; }
        }


        public Sistema()
        {
            // Pre-cargar datos
            PrecargarAeropuertos();
            PrecargarAviones();
            PrecargarRutas();
            PrecargarVuelos();
            PrecargarUsuarios();
            PrecargarPasajes();

        }


        //Metodos para Agregar
        public void AgregarAeropuerto(Aeropuerto ae)
        {
            if (ae == null) throw new Exception("El aeropuerto no puede ser nulo.");
            ae.Validar();
            if (_aeropuertos.Contains(ae)) throw new Exception("El aeropuerto con ese código IATA ya existe en el sistema.");
            _aeropuertos.Add(ae);
        }

        public void AgregarAvion(Avion av)
        {
            if (av == null) throw new Exception("El avión no puede ser nulo.");
            av.Validar();
            _aviones.Add(av);
        }

        public void AgregarRuta(Ruta r)
        {
            if (r == null) throw new Exception("La ruta no puede ser nula");
            r.Validar();
            _rutas.Add(r);
        }

        public void AgregarVuelo(Vuelo v)
        {
            if (v == null) throw new Exception("El vuelo no puede ser nulo");
            v.Validar();
            _vuelos.Add(v);
        }

        public void AgregarUsuario(Usuario u)
        {
            if (u == null) throw new Exception("El usuario no puede ser nulo.");
            u.Validar();
            if (_usuarios.Contains(u)) throw new Exception("El usuario con ese mail ya existe en el sistema.");
            _usuarios.Add(u);
        }

        public void AgregarPasaje(Pasaje p)
        {
            if (p == null) throw new Exception("El pasaje no puede ser nulo");
            p.Validar();
            _pasajes.Add(p);
        }



        //Precargas
        private void PrecargarAeropuertos()
        {
            AgregarAeropuerto(new Aeropuerto("MVD", "Montevideo", 1500, 25));
            AgregarAeropuerto(new Aeropuerto("EZE", "Buenos Aires", 1800, 30));
            AgregarAeropuerto(new Aeropuerto("GRU", "São Paulo", 2000, 35));
            AgregarAeropuerto(new Aeropuerto("SCL", "Santiago de Chile", 1700, 28));
            AgregarAeropuerto(new Aeropuerto("LIM", "Lima", 1600, 26));
            AgregarAeropuerto(new Aeropuerto("BOG", "Bogotá", 1750, 29));
            AgregarAeropuerto(new Aeropuerto("PTY", "Ciudad de Panamá", 2100, 32));
            AgregarAeropuerto(new Aeropuerto("MEX", "Ciudad de México", 2200, 34));
            AgregarAeropuerto(new Aeropuerto("JFK", "Nueva York", 3000, 50));
            AgregarAeropuerto(new Aeropuerto("MIA", "Miami", 2900, 48));
            AgregarAeropuerto(new Aeropuerto("MAD", "Madrid", 3100, 55));
            AgregarAeropuerto(new Aeropuerto("BCN", "Barcelona", 2950, 52));
            AgregarAeropuerto(new Aeropuerto("CDG", "París", 3200, 58));
            AgregarAeropuerto(new Aeropuerto("FRA", "Frankfurt", 3150, 56));
            AgregarAeropuerto(new Aeropuerto("AMS", "Ámsterdam", 3000, 53));
            AgregarAeropuerto(new Aeropuerto("LHR", "Londres", 3300, 60));
            AgregarAeropuerto(new Aeropuerto("ROM", "Roma", 2900, 49));
            AgregarAeropuerto(new Aeropuerto("DOH", "Doha", 3400, 65));
            AgregarAeropuerto(new Aeropuerto("DXB", "Dubái", 3450, 66));
            AgregarAeropuerto(new Aeropuerto("SYD", "Sídney", 3600, 70));
        }

        private void PrecargarAviones()
        {
            AgregarAvion(new Avion("Boeing", "737 MAX", 180, 6570, 12.5));
            AgregarAvion(new Avion("Airbus", "A320neo", 174, 6300, 11.8));
            AgregarAvion(new Avion("Embraer", "E195-E2", 132, 4800, 9.6));
            AgregarAvion(new Avion("Bombardier", "CRJ900", 90, 2900, 8.2));
        }

        private void PrecargarRutas()
        {
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MVD"), BuscarAeropuertoPorCodigo("EZE"), 220));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MVD"), BuscarAeropuertoPorCodigo("GRU"), 1580));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MVD"), BuscarAeropuertoPorCodigo("SCL"), 1370));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MVD"), BuscarAeropuertoPorCodigo("LIM"), 3120));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("EZE"), BuscarAeropuertoPorCodigo("GRU"), 1670));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("EZE"), BuscarAeropuertoPorCodigo("MEX"), 7400));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("EZE"), BuscarAeropuertoPorCodigo("MIA"), 7100));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("GRU"), BuscarAeropuertoPorCodigo("BOG"), 4350));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("GRU"), BuscarAeropuertoPorCodigo("JFK"), 7680));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("GRU"), BuscarAeropuertoPorCodigo("MAD"), 8150));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("SCL"), BuscarAeropuertoPorCodigo("LIM"), 2450));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("SCL"), BuscarAeropuertoPorCodigo("CDG"), 11500));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("SCL"), BuscarAeropuertoPorCodigo("MEX"), 6600));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("LIM"), BuscarAeropuertoPorCodigo("BOG"), 1870));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("LIM"), BuscarAeropuertoPorCodigo("PTY"), 2300));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("BOG"), BuscarAeropuertoPorCodigo("JFK"), 4000));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("BOG"), BuscarAeropuertoPorCodigo("MIA"), 2500));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("PTY"), BuscarAeropuertoPorCodigo("MIA"), 1850));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("PTY"), BuscarAeropuertoPorCodigo("MAD"), 8400));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MEX"), BuscarAeropuertoPorCodigo("JFK"), 3360));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MEX"), BuscarAeropuertoPorCodigo("CDG"), 9200));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("JFK"), BuscarAeropuertoPorCodigo("MAD"), 5760));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("JFK"), BuscarAeropuertoPorCodigo("LHR"), 5550));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MIA"), BuscarAeropuertoPorCodigo("LHR"), 7100));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MAD"), BuscarAeropuertoPorCodigo("BCN"), 500));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MAD"), BuscarAeropuertoPorCodigo("FRA"), 1450));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("FRA"), BuscarAeropuertoPorCodigo("CDG"), 500));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("CDG"), BuscarAeropuertoPorCodigo("AMS"), 430));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("AMS"), BuscarAeropuertoPorCodigo("LHR"), 370));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("LHR"), BuscarAeropuertoPorCodigo("DXB"), 5500));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("DXB"), BuscarAeropuertoPorCodigo("SYD"), 12000));
        }

        private void PrecargarVuelos()
        {
            AgregarVuelos(new Vuelo("LA101", BuscarRuta("MVD", "EZE"), BuscarAvionPorModeloPorModelo("737 MAX"), new List<Dia> { Dia.Lunes, Dia.Martes, Dia.Miercoles, Dia.Jueves, Dia.Viernes }));
            AgregarVuelos(new Vuelo("IB102", BuscarRuta("EZE", "MVD"), BuscarAvionPorModelo("A320neo"), new List<Dia> { Dia.Sabado, Dia.Domingo }));
            AgregarVuelos(new Vuelo("AF123", BuscarRuta("MVD", "GRU"), BuscarAvionPorModelo("E195-E2"), new List<Dia> { Dia.Lunes, Dia.Miercoles, Dia.Viernes }));
            AgregarVuelos(new Vuelo("LH456", BuscarRuta("GRU", "MVD"), BuscarAvionPorModelo("CRJ900"), new List<Dia> { Dia.Martes, Dia.Jueves }));
            AgregarVuelos(new Vuelo("TK789", BuscarRuta("MVD", "SCL"), BuscarAvionPorModelo("737 MAX"), new List<Dia> { Dia.Lunes, Dia.Miercoles, Dia.Viernes }));
            AgregarVuelos(new Vuelo("AZ555", BuscarRuta("SCL", "LIM"), BuscarAvionPorModelo("A320neo"), new List<Dia> { Dia.Martes, Dia.Jueves }));
            AgregarVuelos(new Vuelo("DL321", BuscarRuta("LIM", "BOG"), BuscarAvionPorModelo("E195-E2"), new List<Dia> { Dia.Lunes, Dia.Miercoles, Dia.Viernes }));
            AgregarVuelos(new Vuelo("AF987", BuscarRuta("BOG", "JFK"), BuscarAvionPorModelo("CRJ900"), new List<Dia> { Dia.Sabado, Dia.Domingo }));
            AgregarVuelos(new Vuelo("UA1020", BuscarRuta("MEX", "JFK"), BuscarAvionPorModelo("737 MAX"), new List<Dia> { Dia.Lunes, Dia.Martes, Dia.Miercoles }));
            AgregarVuelos(new Vuelo("QF888", BuscarRuta("JFK", "LHR"), BuscarAvionPorModelo("A320neo"), new List<Dia> { Dia.Jueves, Dia.Viernes }));
            AgregarVuelos(new Vuelo("CX777", BuscarRuta("LHR", "SYD"), BuscarAvionPorModelo("E195-E2"), new List<Dia> { Dia.Martes, Dia.Jueves }));
            AgregarVuelos(new Vuelo("EK500", BuscarRuta("DXB", "SYD"), BuscarAvionPorModelo("CRJ900"), new List<Dia> { Dia.Lunes, DiaViernes }));
            AgregarVuelos(new Vuelo("SV600", BuscarRuta("MIA", "JFK"), BuscarAvionPorModelo("737 MAX"), new List<Dia> { Dia.Miercoles, Dia.Viernes }));
            AgregarVuelos(new Vuelo("AC234", BuscarRuta("GRU", "JFK"), BuscarAvionPorModelo("A320neo"), new List<Dia> { Dia.Lunes, Dia.Miercoles }));
            AgregarVuelos(new Vuelo("KL400", BuscarRuta("AMS", "LHR"), BuscarAvionPorModelo("E195-E2"), new List<Dia> { Dia.Sabado, Dia.Domingo }));
            AgregarVuelos(new Vuelo("QR500", BuscarRuta("LHR", "DXB"), BuscarAvionPorModelo("CRJ900"), new List<Dia> { Dia.Lunes, Dia.Miercoles, Dia.Viernes }));
            AgregarVuelos(new Vuelo("AI207", BuscarRuta("CDG", "AMS"), BuscarAvionPorModelo("737 MAX"), new List<Dia> { Dia.Martes, Dia.Jueves }));
            AgregarVuelos(new Vuelo("AM800", BuscarRuta("BCN", "FRA"), BuscarAvionPorModelo("A320neo"), new List<Dia> { Dia.Lunes, DiaJueves }));
            AgregarVuelos(new Vuelo("NH255", BuscarRuta("SCL", "MEX"), BuscarAvionPorModelo("E195-E2"), new List<Dia> { Dia.Lunes, DiaViernes }));
            AgregarVuelos(new Vuelo("MH321", BuscarRuta("JFK", "SYD"), BuscarAvionPorModelo("CRJ900"), new List<Dia> { Dia.Miercoles, DiaSábado }));
            AgregarVuelos(new Vuelo("OS234", BuscarRuta("AMS", "LHR"), BuscarAvionPorModelo("737 MAX"), new List<Dia> { Dia.Lunes, DiaMiercoles, DiaJueves }));
            AgregarVuelos(new Vuelo("TG123", BuscarRuta("MIA", "EZE"), BuscarAvionPorModelo("A320neo"), new List<Dia> { Dia.Martes, DiaDomingo }));
            AgregarVuelos(new Vuelo("MU787", BuscarRuta("SCL", "LIM"), BuscarAvionPorModelo("E195-E2"), new List<Dia> { Dia.Lunes, DiaViernes }));
            AgregarVuelos(new Vuelo("PR919", BuscarRuta("MVD", "SCL"), BuscarAvionPorModelo("CRJ900"), new List<Dia> { Dia.Martes, DiaViernes }));
            AgregarVuelos(new Vuelo("JL706", BuscarRuta("GRU", "EZE"), BuscarAvionPorModelo("737 MAX"), new List<Dia> { Dia.Lunes, DiaDomingo }));
            AgregarVuelos(new Vuelo("SQ805", BuscarRuta("MEX", "BOG"), BuscarAvionPorModelo("A320neo"), new List<Dia> { Dia.Miercoles, DiaViernes }));
            AgregarVuelos(new Vuelo("TK223", BuscarRuta("CDG", "MAD"), BuscarAvionPorModelo("E195-E2"), new List<Dia> { Dia.Lunes, DiaJueves }));
            AgregarVuelos(new Vuelo("GA550", BuscarRuta("AMS", "DXB"), BuscarAvionPorModelo("CRJ900"), new List<Dia> { Dia.Martes, DiaMiercoles, DiaViernes }));
            AgregarVuelos(new Vuelo("AZ234", BuscarRuta("MIA", "LHR"), BuscarAvionPorModelo("737 MAX"), new List<Dia> { Dia.Miercoles, DiaJueves }));
            AgregarVuelos(new Vuelo("FI788", BuscarRuta("FRA", "SYD"), BuscarAvionPorModelo("A320neo"), new List<Dia> { Dia.Lunes, DiaViernes }));
            AgregarVuelos(new Vuelo("BA312", BuscarRuta("GRU", "LHR"), BuscarAvionPorModelo("E195-E2"), new List<Dia> { Dia.Martes, DiaJueves }));
            AgregarVuelos(new Vuelo("CX500", BuscarRuta("LHR", "JFK"), BuscarAvionPorModelo("CRJ900"), new List<Dia> { Dia.Lunes, DiaSábado }));
            AgregarVuelos(new Vuelo("AF220", BuscarRuta("SYD", "LHR"), BuscarAvionPorModelo("737 MAX"), new List<Dia> { Dia.Martes, DiaViernes }));
            AgregarVuelos(new Vuelo("VN100", BuscarRuta("SCL", "LIM"), BuscarAvionPorModelo("A320neo"), new List<Dia> { Dia.Miercoles, Dia.Sabado }));
        }

        private void PrecargarUsuarios()
        {
            // Administradores
            AgregarUsuario(new Administrador("fede@mail.com", "fede123", "adminfede"));
            AgregarUsuario(new Administrador("sofia.admin@airline.com", "admin456", "AdminSofia"));

            // Clientes Premium
            AgregarUsuario(new ClientePremium("12345678", "Luis Pérez", "luis.premium@mail.com", "passLuis", "Uruguayo", 1200));
            AgregarUsuario(new ClientePremium("87654321", "Ana Torres", "ana.premium@mail.com", "passAna", "Argentina", 2300));
            AgregarUsuario(new ClientePremium("45678912", "Carlos Gómez", "carlos.premium@mail.com", "passCarlos", "Chileno", 800));
            AgregarUsuario(new ClientePremium("65432109", "Valeria Díaz", "valeria.premium@mail.com", "passValeria", "Paraguaya", 1500));
            AgregarUsuario(new ClientePremium("78945612", "Tomás Ruiz", "tomas.premium@mail.com", "passTomas", "Brasileño", 1800));

            // Clientes Ocasionales
            AgregarUsuario(new ClienteOcacional("32165498", "Camila Soto", "camila.ocasional@mail.com", "passCamila", "Uruguaya", true));
            AgregarUsuario(new ClienteOcacional("98732145", "Matías Vera", "matias.ocasional@mail.com", "passMatias", "Argentina", false));
            AgregarUsuario(new ClienteOcacional("65498721", "Lucía Fernández", "lucia.ocasional@mail.com", "passLucia", "Chilena", true));
            AgregarUsuario(new ClienteOcacional("85296374", "Jorge Acosta", "jorge.ocasional@mail.com", "passJorge", "Peruano", false));
            AgregarUsuario(new ClienteOcacional("74125896", "Daniela Lima", "daniela.ocasional@mail.com", "passDaniela", "Colombiana", true));
        }

        private void PrecargarPasajes()
        {
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("VN100"), new DateTime(2025, 5, 1), BuscarClientePorDocumento("12345678"), Equipaje.Light));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("AR100"), new DateTime(2025, 5, 2), BuscarClientePorDocumento("87654321"), Equipaje.Cabina));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("AM101"), new DateTime(2025, 5, 3), BuscarClientePorDocumento("11223344"), Equipaje.Bodega));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("AF202"), new DateTime(2025, 5, 4), BuscarClientePorDocumento("22334455"), Equipaje.Light));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("BA305"), new DateTime(2025, 5, 5), BuscarClientePorDocumento("33445566"), Equipaje.Cabina));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("DL400"), new DateTime(2025, 5, 6), BuscarClientePorDocumento("44556677"), Equipaje.Bodega));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("UA600"), new DateTime(2025, 5, 7), BuscarClientePorDocumento("55667788"), Equipaje.Light));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("VS700"), new DateTime(2025, 5, 8), BuscarClientePorDocumento("66778899"), Equipaje.Cabina));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("IB801"), new DateTime(2025, 5, 9), BuscarClientePorDocumento("77889900"), Equipaje.Bodega));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("LH902"), new DateTime(2025, 5, 10), BuscarClientePorDocumento("88990011"), Equipaje.Light));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("EK103"), new DateTime(2025, 5, 11), BuscarClientePorDocumento("99001122"), Equipaje.Cabina));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("QR104"), new DateTime(2025, 5, 12), BuscarClientePorDocumento("10111213"), Equipaje.Bodega));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("SQ105"), new DateTime(2025, 5, 13), BuscarClientePorDocumento("12131415"), Equipaje.Light));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("CX106"), new DateTime(2025, 5, 14), BuscarClientePorDocumento("13141516"), Equipaje.Cabina));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("NH107"), new DateTime(2025, 5, 15), BuscarClientePorDocumento("14151617"), Equipaje.Bodega));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("JL108"), new DateTime(2025, 5, 16), BuscarClientePorDocumento("15161718"), Equipaje.Light));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("OS109"), new DateTime(2025, 5, 17), BuscarClientePorDocumento("16171819"), Equipaje.Cabina));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("SK110"), new DateTime(2025, 5, 18), BuscarClientePorDocumento("17181920"), Equipaje.Bodega));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("AY111"), new DateTime(2025, 5, 19), BuscarClientePorDocumento("18192021"), Equipaje.Light));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("FI112"), new DateTime(2025, 5, 20), BuscarClientePorDocumento("19202122"), Equipaje.Cabina));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("LA113"), new DateTime(2025, 5, 21), BuscarClientePorDocumento("20212223"), Equipaje.Bodega));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("UX114"), new DateTime(2025, 5, 22), BuscarClientePorDocumento("21222324"), Equipaje.Light));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("TP115"), new DateTime(2025, 5, 23), BuscarClientePorDocumento("22232425"), Equipaje.Cabina));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("WY116"), new DateTime(2025, 5, 24), BuscarClientePorDocumento("23242526"), Equipaje.Bodega));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("VY117"), new DateTime(2025, 5, 25), BuscarClientePorDocumento("24252627"), Equipaje.Light));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("TK118"), new DateTime(2025, 5, 26), BuscarClientePorDocumento("25262728"), Equipaje.Cabina));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("SN119"), new DateTime(2025, 5, 27), BuscarClientePorDocumento("26272829"), Equipaje.Bodega));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("ST120"), new DateTime(2025, 5, 28), BuscarClientePorDocumento("27282930"), Equipaje.Light));
            AgregarPasaje(new Pasaje(BuscarVueloPorNumero("W6121"), new DateTime(2025, 5, 29), BuscarClientePorDocumento("28293031"), Equipaje.Cabina));
        }
    }


    //Metodos de busqueda
    private Aeropuerto BuscarAeropuertoPorCodigo(string codigo)
    {
        Aeropuerto buscado = null;
        foreach (Aeropuerto a in _aeropuertos)
        {
            if (a.Codigo == codigo)
            {
                buscado = a;
                break;
            }
        }
        if (buscado == null)
        {
            throw new Exception($"No se encontró un aeropuerto con el código {codigo}.");
        }
        return buscado;
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
        if (buscado == null)
        {
            throw new Exception($"No se encontró el vuelo con el número {numeroVuelo}.");
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
        if (buscado == null)
        {
            throw new Exception($"No se encontró el cliente con el documento {documento}.");
        }
        return buscado;
    }

    private Avion BuscarAvionPorModelo(string modelo)
    {
        Avion buscado = null;
        int i = 0;
        while (buscado == null && i < _aviones.Count)
        {
            if (_aviones[i].Modelo == modelo) buscado = _aviones[i];
            i++;
        }
        return buscado;
        if (buscado == null)
        {
            throw new Exception($"No se encontró avión con el modelo {modelo}.");
        }
        return buscado;
    }

    private Ruta BuscarRuta(string origen, string destino)
    {
        Ruta buscada = null;
        int i = 0;
        while (buscada == null && i < _rutas.Count)
        {
            if (_rutas[i].Origen.Codigo == origen && _rutas[i].Destino.Codigo == destino)
                buscada = _rutas[i];
            i++;
        }

        if (buscada == null)
        {
            throw new Exception($"No se encontró ruta de {origen} a {destino}.");
        }

        return buscada;
    }

}
