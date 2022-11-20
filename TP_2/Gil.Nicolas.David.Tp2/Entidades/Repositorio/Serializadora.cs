﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using Newtonsoft.Json;

namespace Entidades.Repositorio
{
    public static class Serializadora<T>
    {
        static string? ruta;

        static Serializadora()
        {
            ruta = ruta = AppDomain.CurrentDomain.BaseDirectory;
        }

        public static void EscribirJson(string nombreArchivo, T datoAGuardar)
        {
            string rutaCompleta = ruta + nombreArchivo + ".json";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    if (ruta is not null)
                        Directory.CreateDirectory(ruta);
                }
                //JsonSerializerOptions options = new JsonSerializerOptions();
                //options.WriteIndented = true;
                //string datoSerializado = JsonConvert.SerializeObject(datoAGuardar);
                string datoSerializado = System.Text.Json.JsonSerializer.Serialize(datoAGuardar);
                File.WriteAllText(rutaCompleta, datoSerializado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al escribir el archivo {rutaCompleta}", ex);
            }
        }

        public static T LeerJson(string nombreArchivo)
        {
            string archivo = String.Empty;
            string rutaCompleta = ruta + nombreArchivo + ".json";
            T? dato = default;

            try
            {
                if (Directory.Exists(ruta))
                {
                    string[] archivos = Directory.GetFiles(ruta);

                    foreach (string item in archivos)
                    {
                        if (item.Contains(nombreArchivo))
                        {
                            archivo = item;
                            break;
                        }
                    }
                    if (archivo != null)
                    {
                        string archivoJson = File.ReadAllText(archivo);
                        dato = JsonConvert.DeserializeObject<T>(archivoJson);
                    }
                }
                return dato;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al leer el archivo {rutaCompleta}", ex);
            }
        }
        public static void EscribirXml(string nombreArchivo, T datoAGuardar)
        {
            string rutaCompleta = ruta + nombreArchivo + ".xml";
            try
            {
                if (Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (XmlTextWriter tw = new XmlTextWriter(rutaCompleta, Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(T));
                    tw.Formatting = System.Xml.Formatting.Indented;
                    serializador.Serialize(tw, datoAGuardar);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al escribir el archivo {rutaCompleta}", ex);
            }
        }
        public static T LeerXml(string nombreArchivo)
        {
            string rutaCompleta = ruta + nombreArchivo + ".xml";
            string archivo = String.Empty;
            T? dato = default;
            try
            {
                if (Directory.Exists(ruta))
                {
                    string[] archivos = Directory.GetFiles(ruta);

                    foreach (string item in archivos)
                    {
                        if (item.Contains(nombreArchivo))
                        {
                            archivo = item;
                            break;
                        }
                    }
                }
                if (archivo != null)
                {
                    using (XmlTextReader sr = new XmlTextReader(rutaCompleta))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        dato = (T?)serializer.Deserialize(sr);
                    }
                }
                return dato;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al leer el archivo {rutaCompleta}", ex);
            }
        }
    }
}