using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial_Library;

namespace Parcial_Library
{
    public class HardCodeo
    {
        public static void InicializarVendedores(List<Vendedor> listadoVendedores)
        {
            listadoVendedores.Add(new Vendedor("Raffi_12", "12345", "Raffi Kokac", 35326125, "Administrador"));
            listadoVendedores.Add(new Vendedor("Lucas_UTN_Condor", "12345", "Lucas Rodriguez", 30215965, "Administrador"));
            listadoVendedores.Add(new Vendedor("Ornela_C_UTN", "12345", "Ornela Cusio", 41254515, "Administrador"));
            listadoVendedores.Add(new Vendedor("Esteban_Dios_Nordico", "12345", "Esteban Prieto", 38956965, "Administrador"));
            listadoVendedores.Add(new Vendedor("Nacho_UTN", "12345", "Ignacio Smirlian", 40055065, "Administrador"));
        }

        public static void InicializarClasesVuelo()
        {
            Aerolinea.clasesVuelo.Add("Turista");
            Aerolinea.clasesVuelo.Add("Primera");
        }

        public static void InicializarAeronaves()
        {
            Aerolinea.misAviones.Add(new Aeronave("AA747-8I", 467, 3, 5000, false, true, 374, 93, true));
            Aerolinea.misAviones.Add(new Aeronave("AB747-8I", 467, 3, 5000, true, false, 374, 93, true));
            Aerolinea.misAviones.Add(new Aeronave("AC747-8I", 467, 3, 5000, true, true, 374, 93, true));
            Aerolinea.misAviones.Add(new Aeronave("AD747-8I", 467, 3, 5000, false, false, 374, 93, true));
            Aerolinea.misAviones.Add(new Aeronave("AA787-9I", 294, 4, 10000, true, true, 236, 58, true));
            Aerolinea.misAviones.Add(new Aeronave("AB787-9I", 294, 4, 10000, true, false, 236, 58, true));
            Aerolinea.misAviones.Add(new Aeronave("AC787-9I", 294, 4, 10000, true, true, 236, 58, true));
        }

        public static void InicializarDestinos()
        {
            Aerolinea.misDestinos.Add("Santa Rosa");
            Aerolinea.misDestinos.Add("Bariloche");
            Aerolinea.misDestinos.Add("Corrientes");
            Aerolinea.misDestinos.Add("Córdoba");
            Aerolinea.misDestinos.Add("Jujuy");
            Aerolinea.misDestinos.Add("Mendoza");
            Aerolinea.misDestinos.Add("Neuquén");
            Aerolinea.misDestinos.Add("Posadas");
            Aerolinea.misDestinos.Add("Iguazú");
            Aerolinea.misDestinos.Add("Salta");
            Aerolinea.misDestinos.Add("Santiago del Estero");
            Aerolinea.misDestinos.Add("Trelew");
            Aerolinea.misDestinos.Add("Tucumán");
            Aerolinea.misDestinos.Add("Puerto Madryn");
            Aerolinea.misDestinos.Add("Ushuaia");
            Aerolinea.misDestinos.Add("Recife");
            Aerolinea.misDestinos.Add("Roma");
            Aerolinea.misDestinos.Add("Acapulco");
            Aerolinea.misDestinos.Add("Miami");
        }
        public static void InicializarVuelos()
        {
            Aerolinea.vuelosActivos.Add(new Vuelo(Aerolinea.nuestraAerolinea.CodigoAerolinea.ToString(), "Buenos Aires", "Miami", "03:00 pm", 8, 374, "Disponible", 93, Aerolinea.misAviones[0], DateTime.Today.ToShortDateString(), "11:00 pm"));
            Aerolinea.nuestraAerolinea.CodigoAerolinea++;
            Aerolinea.misAviones[0].EstadoAvion = false;
            Aerolinea.vuelosActivos.Add(new Vuelo(Aerolinea.nuestraAerolinea.CodigoAerolinea.ToString(), "Buenos Aires", "Bariloche", "06:00 am", 2, 374, "Disponible", 93, Aerolinea.misAviones[1], DateTime.Today.ToShortDateString(), "08:00 am"));
            Aerolinea.nuestraAerolinea.CodigoAerolinea++;
            Aerolinea.misAviones[1].EstadoAvion = false;
            Aerolinea.vuelosActivos.Add(new Vuelo(Aerolinea.nuestraAerolinea.CodigoAerolinea.ToString(), "Buenos Aires", "Neuquén", "08:00 am", 3, 374, "Disponible", 93, Aerolinea.misAviones[2], DateTime.Today.ToShortDateString(), "11:00 am"));
            Aerolinea.nuestraAerolinea.CodigoAerolinea++;
            Aerolinea.misAviones[2].EstadoAvion = false;
            Aerolinea.vuelosActivos.Add(new Vuelo(Aerolinea.nuestraAerolinea.CodigoAerolinea.ToString(), "Buenos Aires", "Roma", "10:00 am", 10, 236, "Disponible", 58, Aerolinea.misAviones[4], DateTime.Today.ToShortDateString(), "08:00 pm"));
            Aerolinea.nuestraAerolinea.CodigoAerolinea++;
            Aerolinea.misAviones[4].EstadoAvion = false;
            Aerolinea.nuestraAerolinea.CantidadVuelos += 4;
        }

        public static void InicializarPasajeros()
        {
            List<Pasajero> pasajeros1 = new List<Pasajero>();
            List<Pasajero> pasajeros2 = new List<Pasajero>();
            List<Pasajero> pasajeros3 = new List<Pasajero>();
            List<Pasajero> pasajeros4 = new List<Pasajero>();

            
            pasajeros1.Add(new Pasajero("Turista", 14, true, 27, "Pablo Grande", 40422036, 1));
            pasajeros1.Add(new Pasajero("Turista", 18, true, 35, "Julieta Alvaro", 32962256, 1));
            pasajeros1.Add(new Pasajero("Primera", 12, false, 40, "Nahuel Diaz", 27879085, 2));
            pasajeros1.Add(new Pasajero("Turista", 16, true, 31, "Franco Ledo", 36618721, 1));
            pasajeros1.Add(new Pasajero("Turista", 17, true, 46, "Emilia Perez", 21411410, 1));
            pasajeros1.Add(new Pasajero("Primera", 11, false, 58, "Anabel Herrera", 9686061, 1));
            pasajeros1.Add(new Pasajero("Turista", 18, true, 41, "Sebastian Barberon", 26585033, 1));
            pasajeros1.Add(new Pasajero("Turista", 10, true, 49, "Bianca Almanza", 22718710, 1));
            pasajeros1.Add(new Pasajero("Primera", 9, true, 27, "Elian Ferreyra", 40520312, 1));
            pasajeros1.Add(new Pasajero("Turista", 21, true, 35, "Alan Ferreyra", 32265663, 2));
            pasajeros1.Add(new Pasajero("Turista", 12, false, 32, "Jeronimo Casáres", 35899911, 1));
            pasajeros1.Add(new Pasajero("Turista", 14, true, 52, "Amir Ribada", 15641002, 1));
            pasajeros1.Add(new Pasajero("Turista", 15, true, 57, "Cesar Cespedes", 10105241, 1));
            pasajeros1.Add(new Pasajero("Turista", 10, true, 21, "Dario Olazabál", 44696331, 1));
            pasajeros1.Add(new Pasajero("Turista", 18, false, 25, "Julio Cortazar", 42626054, 1));
            
            pasajeros2.Add(new Pasajero("Primera", 12, true, 36, "Ricardo Gómez", 31254632, 1));
            pasajeros2.Add(new Pasajero("Primera", 20, true, 21, "Morena Escudero", 42013632, 2));
            pasajeros2.Add(new Pasajero("Primera", 19, true, 23, "Matias Barroso", 41254596, 2));
            pasajeros2.Add(new Pasajero("Primera", 17, true, 25, "Lucas Gaggino", 38986596, 1));
            pasajeros2.Add(new Pasajero("Turista", 16, true, 24, "Matias Di Pino", 43056365, 1));
            pasajeros2.Add(new Pasajero("Turista", 12, false, 32, "Federico Lemos", 35254632, 1));
            pasajeros2.Add(new Pasajero("Turista", 9, true, 56, "Esteban Gonzalez", 11415254, 1));
            pasajeros2.Add(new Pasajero("Turista", 15, false, 42, "Marcela Pereyra", 25693889, 1));
            pasajeros2.Add(new Pasajero("Turista", 20, true, 30, "Guillermo Ascuiz", 37002153, 1));
            pasajeros2.Add(new Pasajero("Turista", 16, true, 41, "Sergio Moreno", 26744878, 1));
            pasajeros2.Add(new Pasajero("Turista", 18, false, 26, "Leila Quiroz", 41266323, 1));
            pasajeros2.Add(new Pasajero("Turista", 15, true, 33, "Rodrigo Barrera", 34201004, 1));
            pasajeros2.Add(new Pasajero("Turista", 13, true, 27, "Andrés Carbonaro", 35621488, 1));
            pasajeros2.Add(new Pasajero("Turista", 14, false, 35, "Pablo Erminione", 32989655, 1));
            
            pasajeros3.Add(new Pasajero("Turista", 16, true, 46, "Mario Bonerba", 21487782, 1));
            pasajeros3.Add(new Pasajero("Turista", 12, false, 24, "Gonzalo Alvear", 43266859, 1));
            pasajeros3.Add(new Pasajero("Turista", 22, false, 54, "Jorge Ravetti", 13621488, 1));
            pasajeros3.Add(new Pasajero("Primera", 21, true, 38, "Rodrigo Ravetti", 29363222, 2));
            pasajeros3.Add(new Pasajero("Turista", 10, false, 69, "Lucio Lacasio", 8263525, 1));
            pasajeros3.Add(new Pasajero("Primera", 9, true, 42, "Alberto Uspeda", 25464125, 1));
            pasajeros3.Add(new Pasajero("Turista", 12, false, 36, "Pedro Roffio", 23132563, 1));
            pasajeros3.Add(new Pasajero("Primera", 16, true, 38, "Maximiliano Loppia", 29489658, 1));
            pasajeros3.Add(new Pasajero("Turista", 11, true, 36, "Ezequiel Espinosa", 31521455, 1));
            pasajeros3.Add(new Pasajero("Turista", 21, false, 28, "Marcos Muslera", 39719728, 1));
            pasajeros3.Add(new Pasajero("Turista", 19, true, 32, "Hector Izquierdoz", 35611621, 1));
            pasajeros3.Add(new Pasajero("Turista", 14, false, 31, "Sebastian Rost", 34122362, 1));
            pasajeros3.Add(new Pasajero("Turista", 9, true, 34, "Ayelen Rial", 33896556, 1));
            
            pasajeros4.Add(new Pasajero("Turista", 17, true, 39, "Lucas Gimenez", 28464130, 1));
            pasajeros4.Add(new Pasajero("Turista", 15, true, 27, "Martin Bracchi", 40233696, 1));
            pasajeros4.Add(new Pasajero("Turista", 11, true, 32, "Mauro Fava", 35757880, 1));
            pasajeros4.Add(new Pasajero("Turista", 9, true, 34, "Rodrigo Manera", 33896556, 1));
            pasajeros4.Add(new Pasajero("Turista", 12, false, 42, "Veronica Facio", 25699323, 1));
            pasajeros4.Add(new Pasajero("Turista", 18, true, 30, "Ludmila Buono", 37105245, 1));
            pasajeros4.Add(new Pasajero("Turista", 18, true, 32, "Veronica Obermeide", 35966486, 1));
            pasajeros4.Add(new Pasajero("Turista", 12, false, 43, "Lucia Rioparisi", 25500366, 1));
            pasajeros4.Add(new Pasajero("Primera", 14, true, 52, "Oscar Wilde", 15589901, 1));
            pasajeros4.Add(new Pasajero("Primera", 19, true, 62, "Julio Verne", 5784477, 1));
            pasajeros4.Add(new Pasajero("Primera", 14, true, 37, "Gianni Migliori", 30102033, 1));
            pasajeros4.Add(new Pasajero("Primera", 10, true, 47, "Julio Cortazar", 20515222, 1));

            Aerolinea.vuelosActivos[0].ListaPasajero = pasajeros1;
            Aerolinea.nuestraAerolinea.Pasajeros += pasajeros1.Count;
            Aerolinea.vuelosActivos[1].ListaPasajero = pasajeros2;
            Aerolinea.nuestraAerolinea.Pasajeros += pasajeros2.Count;
            Aerolinea.vuelosActivos[2].ListaPasajero = pasajeros3;
            Aerolinea.nuestraAerolinea.Pasajeros += pasajeros3.Count;
            Aerolinea.vuelosActivos[3].ListaPasajero = pasajeros4;
            Aerolinea.nuestraAerolinea.Pasajeros += pasajeros4.Count;
        }
    }    
}
