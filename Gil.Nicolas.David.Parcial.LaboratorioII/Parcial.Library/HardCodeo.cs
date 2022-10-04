using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial.Library;



namespace Parcial.Library
{
    public static class HardCodeo
    {
        public static void InicializarVendedores()
        {            
            Aerolinea.Usuarios.Add(2, new Usuario("Lucas_UTN_Condor", "12345", "Lucas Rodriguez", 30215965, 32, "Administrador", 150000));
            Aerolinea.Usuarios.Add(3, new Usuario("Ornela_C_UTN", "12345", "Ornela Cusio", 41254515, 22, "Administrador", 150000));
            Aerolinea.Usuarios.Add(4, new Usuario("Esteban_Dios_Nordico", "12345", "Esteban Prieto", 38956965, 25, "Administrador", 150000));
            Aerolinea.Usuarios.Add(5, new Usuario("Nacho_UTN", "12345", "Ignacio Smirlian", 40055065, 21, "Administrador", 150000));
            Aerolinea.Usuarios.Add(1, new Usuario("Raffi_12", "12345", "Raffi Kocak", 35326125, 31, "Administrador", 150000));
        }

        //public static void InicializarClasesVuelo()
        //{
            
        //    //Aerolinea.clasesVuelo.Add("Turista");
        //    //Aerolinea.clasesVuelo.Add("Primera");
        //}

        public static void InicializarAeronaves()
        {
            Aerolinea.misAviones.Add(new Aeronave("AA747-8I", 467, 3, 5000, false, true, 0, 374, 93, true));
            Aerolinea.misAviones.Add(new Aeronave("AB747-8I", 467, 3, 5000, true, false, 0, 374, 93, true));
            Aerolinea.misAviones.Add(new Aeronave("AC747-8I", 467, 3, 5000, true, true, 0, 374, 93, true));
            Aerolinea.misAviones.Add(new Aeronave("AD747-8I", 467, 3, 5000, false, false, 0, 374, 93, true));
            Aerolinea.misAviones.Add(new Aeronave("AA787-9I", 294, 4, 10000, true, true, 0, 236, 58, true));
            Aerolinea.misAviones.Add(new Aeronave("AB787-9I", 294, 4, 10000, true, false, 0, 236, 58, true));
            Aerolinea.misAviones.Add(new Aeronave("AC787-9I", 294, 4, 10000, true, true, 0, 236, 58, true));
        }

        public static void InicializarDestinos()
        {
            Aerolinea.misDestinos.Add("Buenos Aires");
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
            Aerolinea.vuelosActivos.Add(new Vuelo("Buenos Aires", "Miami", "03:00 pm", 8, 374, "Disponible", 93, Aerolinea.misAviones[0], DateTime.Today.ToShortDateString(), "11:00 pm"));            
            Aerolinea.misAviones[0].EstadoAvion = false;
            Aerolinea.misAviones[0].TiempoVuelo += 8;
            Aerolinea.vuelosActivos.Add(new Vuelo("Buenos Aires", "Bariloche", "06:00 am", 2, 374, "Disponible", 93, Aerolinea.misAviones[1], DateTime.Today.ToShortDateString(), "08:00 am"));            
            Aerolinea.misAviones[1].EstadoAvion = false;
            Aerolinea.misAviones[1].TiempoVuelo += 2;
            Aerolinea.vuelosActivos.Add(new Vuelo("Buenos Aires", "Neuquén", "08:00 am", 3, 374, "Disponible", 93, Aerolinea.misAviones[2], DateTime.Today.ToShortDateString(), "11:00 am"));            
            Aerolinea.misAviones[2].EstadoAvion = false;
            Aerolinea.misAviones[2].TiempoVuelo += 3;
            Aerolinea.vuelosActivos.Add(new Vuelo("Buenos Aires", "Roma", "10:00 am", 10, 236, "Disponible", 58, Aerolinea.misAviones[4], DateTime.Today.ToShortDateString(), "08:00 pm"));            
            Aerolinea.misAviones[4].EstadoAvion = false;
            Aerolinea.misAviones[4].TiempoVuelo += 10;
            Aerolinea.vuelosFinalizados.Add(new Vuelo("Buenos Aires", "Acapulco", "11 am", 10, 1, "Finalizado", 12, Aerolinea.misAviones[3], "17-05-2022", "9 pm", 233075));
            Aerolinea.misAviones[3].TiempoVuelo += 10;
            Aerolinea.vuelosFinalizados.Add(new Vuelo("Buenos Aires", "Bariloche", "06 am", 2, 0, "Finalizado", 8, Aerolinea.misAviones[1], "22-05-2022", "08 am", 47175));
            Aerolinea.misAviones[1].TiempoVuelo += 2;
            Aerolinea.vuelosFinalizados.Add(new Vuelo("Corrientes", "Posadas", "2 pm", 4, 8, "Finalizado", 14, Aerolinea.misAviones[4], "01-06-2022", "06 pm", 55720));
            Aerolinea.misAviones[4].TiempoVuelo += 4;
            Aerolinea.vuelosFinalizados.Add(new Vuelo("Jujuy", "Neuquén", "12 pm", 4, 21, "Finalizado", 16, Aerolinea.misAviones[2], "08-06-2022", "04 pm", 80260));
            Aerolinea.misAviones[2].TiempoVuelo += 4;
            Aerolinea.vuelosFinalizados.Add(new Vuelo("Buenos Aires", "Roma", "08 am", 11, 4, "Finalizado", 8, Aerolinea.misAviones[0], "15-06-2022", "07 pm", 257262.5f));
            Aerolinea.misAviones[0].TiempoVuelo += 11;
            Aerolinea.vuelosFinalizados.Add(new Vuelo("Buenos Aires", "Mendoza", "06 am", 2, 12, "Finalizado", 23, Aerolinea.misAviones[1], "24-06-2022", "08 am", 44250));
            Aerolinea.misAviones[1].TiempoVuelo += 2;
            Aerolinea.vuelosFinalizados.Add(new Vuelo("Salta", "Puerto Madryn", "05 pm", 4, 23, "Finalizado", 31, Aerolinea.misAviones[2], "29-06-2022", "09 pm", 84460));
            Aerolinea.misAviones[2].TiempoVuelo += 4;
            Aerolinea.vuelosFinalizados.Add(new Vuelo("Posadas", "Mendoza", "01 am", 3, 13, "Finalizado", 22, Aerolinea.misAviones[5], "30-06-2022", "04 am", 39660));
            Aerolinea.misAviones[5].TiempoVuelo += 3;
            Aerolinea.vuelosFinalizados.Add(new Vuelo("Buenos Aires", "Ushuaia", "08 am", 4, 11, "Finalizado", 21, Aerolinea.misAviones[6], "02-07-2022", "12 pm", 53510));
            Aerolinea.misAviones[6].TiempoVuelo += 4;
            Aerolinea.vuelosFinalizados.Add(new Vuelo("Neuquen", "Corrientes", "11 am", 3, 11, "Finalizado", 40, Aerolinea.misAviones[2], "04-07-2022", "02 pm", 63592.5f));
            Aerolinea.misAviones[2].TiempoVuelo += 3;
            Aerolinea.vuelosFinalizados.Add(new Vuelo("Buenos Aires", "Miami", "06 am", 12, 0, "Finalizado", 8, Aerolinea.misAviones[3], "05-07-2022", "06 pm", 283050));
            Aerolinea.misAviones[3].TiempoVuelo += 12;
            Aerolinea.vuelosFinalizados.Add(new Vuelo("Buenos Aires", "Recife", "09 am", 10, 2, "Finalizado", 11, Aerolinea.misAviones[1], "08-07-2022", "07 pm", 233150));
            Aerolinea.misAviones[1].TiempoVuelo += 10;
            Aerolinea.vuelosFinalizados.Add(new Vuelo("Jujuy", "Iguazú", "10 am", 4, 23, "Finalizado", 32, Aerolinea.misAviones[0], "10-07-2022", "02 pm", 84230));
            Aerolinea.misAviones[0].TiempoVuelo += 4;
            Aerolinea.vuelosFinalizados.Add(new Vuelo("Buenos Aires", "Salta", "06 pm", 4, 33, "Finalizado", 21, Aerolinea.misAviones[2], "12-07-2022", "10 pm", 84760));
            Aerolinea.misAviones[2].TiempoVuelo += 4;
            Aerolinea.vuelosFinalizados.Add(new Vuelo("Corrientes", "Bariloche", "03 pm", 3, 10, "Finalizado", 28, Aerolinea.misAviones[4], "22-07-2022", "06 pm", 38175));
            Aerolinea.misAviones[4].TiempoVuelo += 3;
        }

        public static void InicializarClientes()
        {
            Aerolinea.clienteHistorial.Add(new Cliente("Pablo Grande", 40422036, 27, "Ramos 1543", "Buenos Aires", "Ramos Mejia", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Julieta Alvaro", 32962256, 35, "Caseros 121", "Buenos Aires", "Lomas de Zamora", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Nahuel Diaz", 27879085, 40, "Av. San Martin 725", "Buenos Aires", "CABA", "Argentina", "Casado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Franco Ledo", 36618721, 31, "Bolivar 876", "Buenos Aires", "Lomas de Zamora", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Emilia Perez", 21411410, 46, "Mercedez 421", "Buenos Aires", "Adrogue", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Anabel Herrera", 9686061, 58, "Saavedra 1423", "Buenos Aires", "Temperley", "Argentina", "Divorciado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Sebastian Barberon", 26585033, 41, "Garibaldi 762", "Buenos Aires", "Lomas de Zamora", "Argentina", "Casado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Bianca Almanza", 22718710, 49, "Rodriguez 423", "Buenos Aires", "Luis Guillon", "Uruguay", "Casado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Elian Ferreyra", 40520312, 27, "Liniers 912", "Buenos Aires", "Lanus", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Alan Ferreyra", 32265663, 35, "Liniers 912", "Buenos Aires", "Lanus", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Jeronimo Casáres", 35899911, 32, "Granaderos 43", "Buenos Aires", "Lanus", "Argentina", "Casado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Amir Ribada", 15641002, 52, "Granderos 121", "Buenos Aires", "Lanus", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Cesar Cespedes", 10105241, 57, "Bilbao la vieja 22", "Buenos Aires", "Banfield", "Argentina", "Casado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Dario Olazabál", 44696331, 21, "Mitre 1742", "Buenos Aires", "CABA", "Venezuela", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Julio Cortazar", 42626054, 25, "Av. Rolon 423", "Buenos Aires", "Olivos", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Ricardo Gómez", 31254632, 36, "Zapata 2312", "Buenos Aires", "Lomas de Zamora", "Argentina", "Casado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Morena Escudero", 43517743, 21, "Luzuriaga 250", "Buenos Aires", "Lavallol", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Matias Barrozo", 41251333, 58, "Sarmiento 3555", "Buenos Aires", "CABA", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Lucas Gaggino", 38986596, 25, "25 de Mayo 450", "Buenos Aires", "Lanus", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Matias Di Pino", 43056365, 24, "Santiago del Estero 2635", "Buenos Aires", "Lanus", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Federico Lemos", 35254632, 32, "Acevedo 3122", "Buenos Aires", "Banfield", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Esteban Gonzalez", 11415254, 25, "Consorio 121", "Buenos Aires", "Liniers", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Marcela Pereyra", 25693889, 25, "Carlos Croce 121", "Buenos Aires", "Lomas de Zamora", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Guillermo Ascuiz", 37002153, 30, "Esmeralda 31", "Buenos Aires", "Temperley", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Sergio Moreno", 26744878, 41, "French 2544", "Buenos Aires", "Lomas de Zamora", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Leila Quiroz", 41266323, 26, "Alvarado 312", "Buenos Aires", "Marmol", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Rodrigo Barrera", 34201004, 33, "Gilbert 123", "Buenos Aires", "Tigre", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Andrés Carbonaro", 35621488, 27, "24 de Mayo 787", "Buenos Aires", "Lomas de Zamora", "Argentina", "Casado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Pablo Erminione", 32989655, 35, "Chimento 621", "Buenos Aires", "Lomas de Zamora", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Gonzalo Alvear", 43266859, 24, "Av del Valle 224", "Buenos Aires", "Tigre", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Jorge Ravetti", 13621488, 54, "Avellaneda 323", "Buenos Aires", "Monte Grande", "Argentina", "Divorciado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Rodrigo Ravetti", 29363222, 38, "Avelleneda 541", "Buenos Aires", "Monte Grande", "Argentina", "Casado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Lucio Lacasio", 8263525, 69, "San Martin 721", "Buenos Aires", "Pilar", "Argentina", "Casado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Alberto Uspeda", 25464125, 42, "Pedernera 856", "Buenos Aires", "San Martin", "Argentina", "Divorciado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Pedro Roffio", 23132563, 36, "Laprida 256", "Buenos Aires", "San Martin", "Paraguay", "Casado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Maximiliano Loppia", 29489658, 38, "Ceresia 256", "Buenos Aires", "Olivos", "Chile", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Ezequiel Espinosa", 31521455, 36, "Azcuenaga 236", "Buenos Aires", "Temperley", "Venezuela", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Marcos Muslera", 39719728, 28, "Vidicueta 4322", "Buenos Aires", "Tigre", "Uruguay", "Casado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Hector Izquierdoz", 35611621, 32, "Riestra 311", "Buenos Aires", "Avellaneda", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Sebastian Rost", 34122362, 31, "Brasil 1322", "Buenos Aires", "CABA", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Ayelen Rial", 33896556, 34, "Molina Arrotea 2021", "Buenos Aires", "Lomas de Zamora", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Lucas Gimenez", 28464130, 39, "Gutierrez 3111", "Buenos Aires", "Jose C. Paz", "Ecuador", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Martin Bracchi", 40233696, 27, "Vasco Nuñez de Balboa 989", "Buenos Aires", "Lomas de Zamora", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Mauro Fava", 35757880, 32, "Iberlucea 556", "Buenos Aires", "Lanus", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Rodrigo Manera", 33896556, 34, "Chimento 1544", "Buenos Aires", "Lomas de Zamora", "Argentina", "Casado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Veronica Facio", 25699323, 42, "Sixto Fernandez 988", "Buenos Aires", "Lomas de Zamora", "Argentina", "Divorciado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Ludmila Buono", 37105245, 30, "Av. Colombres 312", "Buenos Aires", "CABA", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Veronica Obermeide", 35966486, 32, "Av. Frias 802", "Buenos Aires", "Lomas de Zamora", "Argentina", "Casado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Lucia Rioparisi", 25500366, 43, "Montevideo 1698", "Cordoba", "Cordoba", "Argentina", "Casado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Oscar Wilde", 15589901, 52, "Carabajal 3151", "Buenos Aires", "CABA", "Irlanda", "Casado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Julio Verne", 5784477, 62, "Holmbert 747", "Buenos Aires", "CABA", "Francia", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Gianni Migliori", 30102033, 37, "Amenedo 121", "Buenos Aires", "Adrogue", "Argentina", "Casado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Julio Cortazar", 20515222, 47, "Calderon de la Barca 1282", "Buenos Aires", "La Matanza", "Bélgica", "Casado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Pedro Souto", 38959645, 29, "Dorrego 764", "Buenos Aires", "Temperley", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Claudia Petronio", 22718710, 49, "San Pedrito 534", "Buenos Aires", "Rafael Calzada", "Argentina", "Divorciado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Guillermo Gil", 20385451, 55, "Tucuman 62", "Buenos Aires", "Lomas de Zamora", "Argentina", "Divorciado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Tobias Reinhart", 44151251, 21, "Entre Rios 978", "Buenos Aires", "Lomas de Zamora", "Argentina", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Rafael Cruxio", 35394775, 32, "Saavedra 855", "Buenos Aires", "Martinez", "Argentina", "Casado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Eliot Moreira", 36745222, 31, "Estados Unidos 1422", "Buenos Aires", "CABA", "Brasil", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Homero Simpson", 17125020, 42, "Av Siempre Viva 750", "California", "Springfield", "Estados Unidos", "Casado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Marge Simpson", 15123212, 40, "Av Siempre Viva 750", "California", "Springfield", "Estados Unidos", "Casado", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Lisa Simpson", 12222313, 21, "Av Siempre Viva 750", "California", "Springfield", "Estados Unidos", "Soltero", 0));
            Aerolinea.clienteHistorial.Add(new Cliente("Bartolomeo Simpson", 11312667, 21, "Av Siempre Viva 750", "California", "Springfield", "Estados Unidos", "Soltero", 0));
        }
        public static void InicializarPasajeros()
        {
            string destino1 = Aerolinea.vuelosActivos[0].Destinos;
            string destino2 = Aerolinea.vuelosActivos[1].Destinos;
            string destino3 = Aerolinea.vuelosActivos[2].Destinos;
            string destino4 = Aerolinea.vuelosActivos[3].Destinos;

            Aerolinea.vuelosActivos[0].ListaPasajero.Add(new Pasajero("Turista", 14, true, 1, Aerolinea.clienteHistorial[0], Pasajero.CalcularPrecioVuelo(destino1, Aerolinea.vuelosActivos[0].Duracion, "Tu")));
            Aerolinea.clienteHistorial[0].CantidadVuelos++;
            Aerolinea.vuelosActivos[0].AsientosLibresT--;
            Aerolinea.vuelosActivos[0].ListaPasajero.Add(new Pasajero("Turista", 18, true, 1, Aerolinea.clienteHistorial[1], Pasajero.CalcularPrecioVuelo(destino1, Aerolinea.vuelosActivos[0].Duracion, "Tu")));
            Aerolinea.clienteHistorial[1].CantidadVuelos++;
            Aerolinea.vuelosActivos[0].AsientosLibresT--;
            Aerolinea.vuelosActivos[0].ListaPasajero.Add(new Pasajero("Primera", 12, false, 2, Aerolinea.clienteHistorial[2], Pasajero.CalcularPrecioVuelo(destino1, Aerolinea.vuelosActivos[0].Duracion, "Primera")));
            Aerolinea.clienteHistorial[2].CantidadVuelos++;
            Aerolinea.vuelosActivos[0].AsientosLibresP--;
            Aerolinea.vuelosActivos[0].ListaPasajero.Add(new Pasajero("Turista", 16, true, 1, Aerolinea.clienteHistorial[3], Pasajero.CalcularPrecioVuelo(destino1, Aerolinea.vuelosActivos[0].Duracion, "Tu")));
            Aerolinea.clienteHistorial[3].CantidadVuelos++;
            Aerolinea.vuelosActivos[0].AsientosLibresT--;
            Aerolinea.vuelosActivos[0].ListaPasajero.Add(new Pasajero("Turista", 17, true, 1, Aerolinea.clienteHistorial[4], Pasajero.CalcularPrecioVuelo(destino1, Aerolinea.vuelosActivos[0].Duracion, "Tu")));
            Aerolinea.clienteHistorial[4].CantidadVuelos++;
            Aerolinea.vuelosActivos[0].AsientosLibresT--;
            Aerolinea.vuelosActivos[0].ListaPasajero.Add(new Pasajero("Primera", 11, false, 1, Aerolinea.clienteHistorial[5], Pasajero.CalcularPrecioVuelo(destino1, Aerolinea.vuelosActivos[0].Duracion, "Primera")));
            Aerolinea.clienteHistorial[5].CantidadVuelos++;
            Aerolinea.vuelosActivos[0].AsientosLibresP--;
            Aerolinea.vuelosActivos[0].ListaPasajero.Add(new Pasajero("Turista", 18, true, 1, Aerolinea.clienteHistorial[6], Pasajero.CalcularPrecioVuelo(destino1, Aerolinea.vuelosActivos[0].Duracion, "Tu")));
            Aerolinea.clienteHistorial[6].CantidadVuelos++;
            Aerolinea.vuelosActivos[0].AsientosLibresT--;
            Aerolinea.vuelosActivos[0].ListaPasajero.Add(new Pasajero("Turista", 10, true, 1, Aerolinea.clienteHistorial[7], Pasajero.CalcularPrecioVuelo(destino1, Aerolinea.vuelosActivos[0].Duracion, "Tu")));
            Aerolinea.clienteHistorial[7].CantidadVuelos++;
            Aerolinea.vuelosActivos[0].AsientosLibresT--;
            Aerolinea.vuelosActivos[0].ListaPasajero.Add(new Pasajero("Primera", 9, true, 1, Aerolinea.clienteHistorial[8], Pasajero.CalcularPrecioVuelo(destino1, Aerolinea.vuelosActivos[0].Duracion, "Primera")));
            Aerolinea.clienteHistorial[8].CantidadVuelos++;
            Aerolinea.vuelosActivos[0].AsientosLibresP--;
            Aerolinea.vuelosActivos[0].ListaPasajero.Add(new Pasajero("Turista", 21, true, 2, Aerolinea.clienteHistorial[9], Pasajero.CalcularPrecioVuelo(destino1, Aerolinea.vuelosActivos[0].Duracion, "Tu")));
            Aerolinea.clienteHistorial[9].CantidadVuelos++;
            Aerolinea.vuelosActivos[0].AsientosLibresT--;
            Aerolinea.vuelosActivos[0].ListaPasajero.Add(new Pasajero("Turista", 12, false, 1, Aerolinea.clienteHistorial[10], Pasajero.CalcularPrecioVuelo(destino1, Aerolinea.vuelosActivos[0].Duracion, "Tu")));
            Aerolinea.clienteHistorial[10].CantidadVuelos++;
            Aerolinea.vuelosActivos[0].AsientosLibresT--;
            Aerolinea.vuelosActivos[0].ListaPasajero.Add(new Pasajero("Turista", 14, true, 1, Aerolinea.clienteHistorial[11], Pasajero.CalcularPrecioVuelo(destino1, Aerolinea.vuelosActivos[0].Duracion, "Tu")));
            Aerolinea.clienteHistorial[11].CantidadVuelos++;
            Aerolinea.vuelosActivos[0].AsientosLibresT--;
            Aerolinea.vuelosActivos[0].ListaPasajero.Add(new Pasajero("Turista", 15, true, 1, Aerolinea.clienteHistorial[12], Pasajero.CalcularPrecioVuelo(destino1, Aerolinea.vuelosActivos[0].Duracion, "Tu")));
            Aerolinea.clienteHistorial[12].CantidadVuelos++;
            Aerolinea.vuelosActivos[0].AsientosLibresT--;
            Aerolinea.vuelosActivos[0].ListaPasajero.Add(new Pasajero("Turista", 10, true, 1, Aerolinea.clienteHistorial[13], Pasajero.CalcularPrecioVuelo(destino1, Aerolinea.vuelosActivos[0].Duracion, "Tu")));
            Aerolinea.clienteHistorial[13].CantidadVuelos++;
            Aerolinea.vuelosActivos[0].AsientosLibresT--;
            Aerolinea.vuelosActivos[0].ListaPasajero.Add(new Pasajero("Turista", 18, false, 1, Aerolinea.clienteHistorial[14], Pasajero.CalcularPrecioVuelo(destino1, Aerolinea.vuelosActivos[0].Duracion, "Tu")));
            Aerolinea.clienteHistorial[14].CantidadVuelos++;
            Aerolinea.vuelosActivos[0].AsientosLibresT--;

            Aerolinea.vuelosActivos[1].ListaPasajero.Add(new Pasajero("Primera", 12, true, 1, Aerolinea.clienteHistorial[15], Pasajero.CalcularPrecioVuelo(destino2, Aerolinea.vuelosActivos[1].Duracion, "Primera")));
            Aerolinea.clienteHistorial[15].CantidadVuelos++;
            Aerolinea.vuelosActivos[1].AsientosLibresP--;
            Aerolinea.vuelosActivos[1].ListaPasajero.Add(new Pasajero("Primera", 20, true, 2, Aerolinea.clienteHistorial[16], Pasajero.CalcularPrecioVuelo(destino2, Aerolinea.vuelosActivos[1].Duracion, "Primera")));
            Aerolinea.clienteHistorial[16].CantidadVuelos++;
            Aerolinea.vuelosActivos[1].AsientosLibresP--;
            Aerolinea.vuelosActivos[1].ListaPasajero.Add(new Pasajero("Primera", 19, true, 2, Aerolinea.clienteHistorial[17], Pasajero.CalcularPrecioVuelo(destino2, Aerolinea.vuelosActivos[1].Duracion, "Primera")));
            Aerolinea.clienteHistorial[17].CantidadVuelos++;
            Aerolinea.vuelosActivos[1].AsientosLibresP--;
            Aerolinea.vuelosActivos[1].ListaPasajero.Add(new Pasajero("Primera", 17, true, 1, Aerolinea.clienteHistorial[18], Pasajero.CalcularPrecioVuelo(destino2, Aerolinea.vuelosActivos[1].Duracion, "Primera")));
            Aerolinea.clienteHistorial[18].CantidadVuelos++;
            Aerolinea.vuelosActivos[1].AsientosLibresP--;
            Aerolinea.vuelosActivos[1].ListaPasajero.Add(new Pasajero("Turista", 16, true, 1, Aerolinea.clienteHistorial[19], Pasajero.CalcularPrecioVuelo(destino2, Aerolinea.vuelosActivos[1].Duracion, "Pri")));
            Aerolinea.clienteHistorial[19].CantidadVuelos++;
            Aerolinea.vuelosActivos[1].AsientosLibresT--;
            Aerolinea.vuelosActivos[1].ListaPasajero.Add(new Pasajero("Turista", 12, false, 1, Aerolinea.clienteHistorial[20], Pasajero.CalcularPrecioVuelo(destino2, Aerolinea.vuelosActivos[1].Duracion, "Pri")));
            Aerolinea.clienteHistorial[20].CantidadVuelos++;
            Aerolinea.vuelosActivos[1].AsientosLibresT--;
            Aerolinea.vuelosActivos[1].ListaPasajero.Add(new Pasajero("Turista", 9, true, 1, Aerolinea.clienteHistorial[21], Pasajero.CalcularPrecioVuelo(destino2, Aerolinea.vuelosActivos[1].Duracion, "Pri")));
            Aerolinea.clienteHistorial[21].CantidadVuelos++;
            Aerolinea.vuelosActivos[1].AsientosLibresT--;
            Aerolinea.vuelosActivos[1].ListaPasajero.Add(new Pasajero("Turista", 15, false, 1, Aerolinea.clienteHistorial[22], Pasajero.CalcularPrecioVuelo(destino2, Aerolinea.vuelosActivos[1].Duracion, "Pri")));
            Aerolinea.clienteHistorial[22].CantidadVuelos++;
            Aerolinea.vuelosActivos[1].AsientosLibresT--;
            Aerolinea.vuelosActivos[1].ListaPasajero.Add(new Pasajero("Turista", 20, true, 1, Aerolinea.clienteHistorial[23], Pasajero.CalcularPrecioVuelo(destino2, Aerolinea.vuelosActivos[1].Duracion, "Pri")));
            Aerolinea.clienteHistorial[23].CantidadVuelos++;
            Aerolinea.vuelosActivos[1].AsientosLibresT--;
            Aerolinea.vuelosActivos[1].ListaPasajero.Add(new Pasajero("Turista", 16, true, 1, Aerolinea.clienteHistorial[24], Pasajero.CalcularPrecioVuelo(destino2, Aerolinea.vuelosActivos[1].Duracion, "Prime")));
            Aerolinea.clienteHistorial[24].CantidadVuelos++;
            Aerolinea.vuelosActivos[1].AsientosLibresT--;
            Aerolinea.vuelosActivos[1].ListaPasajero.Add(new Pasajero("Turista", 18, false, 1, Aerolinea.clienteHistorial[25], Pasajero.CalcularPrecioVuelo(destino2, Aerolinea.vuelosActivos[1].Duracion, "Prim")));
            Aerolinea.clienteHistorial[25].CantidadVuelos++;
            Aerolinea.vuelosActivos[1].AsientosLibresT--;
            Aerolinea.vuelosActivos[1].ListaPasajero.Add(new Pasajero("Turista", 15, true, 1, Aerolinea.clienteHistorial[26], Pasajero.CalcularPrecioVuelo(destino2, Aerolinea.vuelosActivos[1].Duracion, "Prim")));
            Aerolinea.clienteHistorial[26].CantidadVuelos++;
            Aerolinea.vuelosActivos[1].AsientosLibresT--;
            Aerolinea.vuelosActivos[1].ListaPasajero.Add(new Pasajero("Turista", 13, true, 1, Aerolinea.clienteHistorial[27], Pasajero.CalcularPrecioVuelo(destino2, Aerolinea.vuelosActivos[1].Duracion, "Pri")));
            Aerolinea.clienteHistorial[27].CantidadVuelos++;
            Aerolinea.vuelosActivos[1].AsientosLibresT--;
            Aerolinea.vuelosActivos[1].ListaPasajero.Add(new Pasajero("Turista", 14, false, 1, Aerolinea.clienteHistorial[28], Pasajero.CalcularPrecioVuelo(destino2, Aerolinea.vuelosActivos[1].Duracion, "Prim")));
            Aerolinea.clienteHistorial[28].CantidadVuelos++;
            Aerolinea.vuelosActivos[1].AsientosLibresT--;

            Aerolinea.vuelosActivos[2].ListaPasajero.Add(new Pasajero("Turista", 16, true, 1, Aerolinea.clienteHistorial[29], Pasajero.CalcularPrecioVuelo(destino3, Aerolinea.vuelosActivos[2].Duracion, "Pri")));
            Aerolinea.clienteHistorial[29].CantidadVuelos++;
            Aerolinea.vuelosActivos[2].AsientosLibresT--;
            Aerolinea.vuelosActivos[2].ListaPasajero.Add(new Pasajero("Turista", 12, false, 1, Aerolinea.clienteHistorial[30], Pasajero.CalcularPrecioVuelo(destino3, Aerolinea.vuelosActivos[2].Duracion, "Pri")));
            Aerolinea.clienteHistorial[30].CantidadVuelos++;
            Aerolinea.vuelosActivos[2].AsientosLibresT--;
            Aerolinea.vuelosActivos[2].ListaPasajero.Add(new Pasajero("Turista", 22, false, 1, Aerolinea.clienteHistorial[31], Pasajero.CalcularPrecioVuelo(destino3, Aerolinea.vuelosActivos[2].Duracion, "Pri")));
            Aerolinea.clienteHistorial[31].CantidadVuelos++;
            Aerolinea.vuelosActivos[2].AsientosLibresT--;
            Aerolinea.vuelosActivos[2].ListaPasajero.Add(new Pasajero("Primera", 21, true, 2, Aerolinea.clienteHistorial[32], Pasajero.CalcularPrecioVuelo(destino3, Aerolinea.vuelosActivos[2].Duracion, "Primera")));
            Aerolinea.clienteHistorial[32].CantidadVuelos++;
            Aerolinea.vuelosActivos[2].AsientosLibresP--;
            Aerolinea.vuelosActivos[2].ListaPasajero.Add(new Pasajero("Turista", 10, false, 1, Aerolinea.clienteHistorial[33], Pasajero.CalcularPrecioVuelo(destino3, Aerolinea.vuelosActivos[2].Duracion, "Pri")));
            Aerolinea.clienteHistorial[33].CantidadVuelos++;
            Aerolinea.vuelosActivos[2].AsientosLibresT--;
            Aerolinea.vuelosActivos[2].ListaPasajero.Add(new Pasajero("Primera", 9, true, 1, Aerolinea.clienteHistorial[34], Pasajero.CalcularPrecioVuelo(destino3, Aerolinea.vuelosActivos[2].Duracion, "Primera")));
            Aerolinea.clienteHistorial[34].CantidadVuelos++;
            Aerolinea.vuelosActivos[2].AsientosLibresP--;
            Aerolinea.vuelosActivos[2].ListaPasajero.Add(new Pasajero("Turista", 12, false, 1, Aerolinea.clienteHistorial[35], Pasajero.CalcularPrecioVuelo(destino3, Aerolinea.vuelosActivos[2].Duracion, "Pri")));
            Aerolinea.clienteHistorial[35].CantidadVuelos++;
            Aerolinea.vuelosActivos[2].AsientosLibresT--;
            Aerolinea.vuelosActivos[2].ListaPasajero.Add(new Pasajero("Primera", 16, true, 1, Aerolinea.clienteHistorial[36], Pasajero.CalcularPrecioVuelo(destino3, Aerolinea.vuelosActivos[2].Duracion, "Primera")));
            Aerolinea.clienteHistorial[36].CantidadVuelos++;
            Aerolinea.vuelosActivos[2].AsientosLibresP--;
            Aerolinea.vuelosActivos[2].ListaPasajero.Add(new Pasajero("Turista", 11, true, 1, Aerolinea.clienteHistorial[37], Pasajero.CalcularPrecioVuelo(destino3, Aerolinea.vuelosActivos[2].Duracion, "Prim")));
            Aerolinea.clienteHistorial[37].CantidadVuelos++;
            Aerolinea.vuelosActivos[2].AsientosLibresT--;
            Aerolinea.vuelosActivos[2].ListaPasajero.Add(new Pasajero("Turista", 21, false, 1, Aerolinea.clienteHistorial[38], Pasajero.CalcularPrecioVuelo(destino3, Aerolinea.vuelosActivos[2].Duracion, "Prim")));
            Aerolinea.clienteHistorial[38].CantidadVuelos++;
            Aerolinea.vuelosActivos[2].AsientosLibresT--;
            Aerolinea.vuelosActivos[2].ListaPasajero.Add(new Pasajero("Turista", 19, true, 1, Aerolinea.clienteHistorial[39], Pasajero.CalcularPrecioVuelo(destino3, Aerolinea.vuelosActivos[2].Duracion, "Prim")));
            Aerolinea.clienteHistorial[39].CantidadVuelos++;
            Aerolinea.vuelosActivos[2].AsientosLibresT--;
            Aerolinea.vuelosActivos[2].ListaPasajero.Add(new Pasajero("Turista", 14, false, 1, Aerolinea.clienteHistorial[40], Pasajero.CalcularPrecioVuelo(destino3, Aerolinea.vuelosActivos[2].Duracion, "Pri")));
            Aerolinea.clienteHistorial[40].CantidadVuelos++;
            Aerolinea.vuelosActivos[2].AsientosLibresT--;
            Aerolinea.vuelosActivos[2].ListaPasajero.Add(new Pasajero("Turista", 9, true, 1, Aerolinea.clienteHistorial[41], Pasajero.CalcularPrecioVuelo(destino3, Aerolinea.vuelosActivos[2].Duracion, "Prim")));
            Aerolinea.clienteHistorial[41].CantidadVuelos++;
            Aerolinea.vuelosActivos[2].AsientosLibresT--;

            Aerolinea.vuelosActivos[3].ListaPasajero.Add(new Pasajero("Turista", 17, true, 1, Aerolinea.clienteHistorial[42], Pasajero.CalcularPrecioVuelo(destino4, Aerolinea.vuelosActivos[3].Duracion, "Prim")));
            Aerolinea.clienteHistorial[42].CantidadVuelos++;
            Aerolinea.vuelosActivos[3].AsientosLibresT--;
            Aerolinea.vuelosActivos[3].ListaPasajero.Add(new Pasajero("Turista", 15, true, 1, Aerolinea.clienteHistorial[43], Pasajero.CalcularPrecioVuelo(destino4, Aerolinea.vuelosActivos[3].Duracion, "Prim")));
            Aerolinea.clienteHistorial[43].CantidadVuelos++;
            Aerolinea.vuelosActivos[3].AsientosLibresT--;
            Aerolinea.vuelosActivos[3].ListaPasajero.Add(new Pasajero("Turista", 11, true, 1, Aerolinea.clienteHistorial[44], Pasajero.CalcularPrecioVuelo(destino4, Aerolinea.vuelosActivos[3].Duracion, "Pri")));
            Aerolinea.clienteHistorial[44].CantidadVuelos++;
            Aerolinea.vuelosActivos[3].AsientosLibresT--;
            Aerolinea.vuelosActivos[3].ListaPasajero.Add(new Pasajero("Turista", 9, true, 1, Aerolinea.clienteHistorial[45], Pasajero.CalcularPrecioVuelo(destino4, Aerolinea.vuelosActivos[3].Duracion, "Pri")));
            Aerolinea.clienteHistorial[45].CantidadVuelos++;
            Aerolinea.vuelosActivos[3].AsientosLibresT--;
            Aerolinea.vuelosActivos[3].ListaPasajero.Add(new Pasajero("Turista", 12, false, 1, Aerolinea.clienteHistorial[46], Pasajero.CalcularPrecioVuelo(destino4, Aerolinea.vuelosActivos[3].Duracion, "Prim")));
            Aerolinea.clienteHistorial[46].CantidadVuelos++;
            Aerolinea.vuelosActivos[3].AsientosLibresT--;
            Aerolinea.vuelosActivos[3].ListaPasajero.Add(new Pasajero("Turista", 18, true, 1, Aerolinea.clienteHistorial[47], Pasajero.CalcularPrecioVuelo(destino4, Aerolinea.vuelosActivos[3].Duracion, "Prim")));
            Aerolinea.clienteHistorial[47].CantidadVuelos++;
            Aerolinea.vuelosActivos[3].AsientosLibresT--;
            Aerolinea.vuelosActivos[3].ListaPasajero.Add(new Pasajero("Turista", 18, true, 1, Aerolinea.clienteHistorial[48], Pasajero.CalcularPrecioVuelo(destino4, Aerolinea.vuelosActivos[3].Duracion, "Pri")));
            Aerolinea.clienteHistorial[48].CantidadVuelos++;
            Aerolinea.vuelosActivos[3].AsientosLibresT--;
            Aerolinea.vuelosActivos[3].ListaPasajero.Add(new Pasajero("Turista", 12, false, 1, Aerolinea.clienteHistorial[49], Pasajero.CalcularPrecioVuelo(destino4, Aerolinea.vuelosActivos[3].Duracion, "Pri")));
            Aerolinea.clienteHistorial[49].CantidadVuelos++;
            Aerolinea.vuelosActivos[3].AsientosLibresT--;
            Aerolinea.vuelosActivos[3].ListaPasajero.Add(new Pasajero("Primera", 14, true, 1, Aerolinea.clienteHistorial[50], Pasajero.CalcularPrecioVuelo(destino4, Aerolinea.vuelosActivos[3].Duracion, "Primera")));
            Aerolinea.clienteHistorial[50].CantidadVuelos++;
            Aerolinea.vuelosActivos[3].ListaPasajero.Add(new Pasajero("Primera", 19, true, 1, Aerolinea.clienteHistorial[51], Pasajero.CalcularPrecioVuelo(destino4, Aerolinea.vuelosActivos[3].Duracion, "Primera")));
            Aerolinea.clienteHistorial[51].CantidadVuelos++;
            Aerolinea.vuelosActivos[3].AsientosLibresP--;
            Aerolinea.vuelosActivos[3].ListaPasajero.Add(new Pasajero("Primera", 14, true, 1, Aerolinea.clienteHistorial[52], Pasajero.CalcularPrecioVuelo(destino4, Aerolinea.vuelosActivos[3].Duracion, "Primera")));
            Aerolinea.clienteHistorial[52].CantidadVuelos++;
            Aerolinea.vuelosActivos[3].AsientosLibresP--;
            Aerolinea.vuelosActivos[3].ListaPasajero.Add(new Pasajero("Primera", 10, true, 1, Aerolinea.clienteHistorial[53], Pasajero.CalcularPrecioVuelo(destino4, Aerolinea.vuelosActivos[3].Duracion, "Primera")));
            Aerolinea.clienteHistorial[53].CantidadVuelos++;
            Aerolinea.vuelosActivos[3].AsientosLibresP--;

            Aerolinea.vuelosActivos[0].Ganancia = Vuelo.GananciasVuelo(Aerolinea.vuelosActivos[0].ListaPasajero);
            Aerolinea.vuelosActivos[1].Ganancia = Vuelo.GananciasVuelo(Aerolinea.vuelosActivos[1].ListaPasajero);
            Aerolinea.vuelosActivos[2].Ganancia = Vuelo.GananciasVuelo(Aerolinea.vuelosActivos[2].ListaPasajero);
            Aerolinea.vuelosActivos[3].Ganancia = Vuelo.GananciasVuelo(Aerolinea.vuelosActivos[3].ListaPasajero);
        }

        public static void InicializarDatos()
        {
            InicializarVendedores();
            InicializarAeronaves();
            InicializarVuelos();
            InicializarClientes();
            //InicializarClasesVuelo();
            InicializarDestinos();
            InicializarPasajeros();
        }
    }
}
