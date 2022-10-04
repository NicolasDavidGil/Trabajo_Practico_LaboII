using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Library
{
    public class Usuario : Persona
    {
        private string usuarioLogin;
        private string usuarioPassword;
        private string nivelAcceso;
        private float sueldoBruto;
        private float comision;

        public Usuario(string usuarioLogin, string usuarioPassword, string nombreVendedor, int documentoVendedor, int edad, string nivelAcceso, float sueldoBruto)
                        : base(nombreVendedor, documentoVendedor, edad)
        {
            this.usuarioLogin = usuarioLogin;
            this.usuarioPassword = usuarioPassword;
            this.nivelAcceso = nivelAcceso;
            this.sueldoBruto = sueldoBruto;
        }

        public Usuario(string usuarioLogin, string usuarioPassword, string nombreVendedor, int documentoVendedor, int edad, string nivelAcceso, float sueldoBruto, float comision)
                : this(usuarioLogin, usuarioPassword, nombreVendedor, documentoVendedor, edad, nivelAcceso, sueldoBruto)
        {
            this.comision = comision;
        }

        public string UsuarioLogin
        {
            get { return usuarioLogin; }
            set { usuarioLogin = value; }
        }
        public string UsuarioPassword
        {
            get { return usuarioPassword; }
        }
        public string NivelAcceso
        {
            get { return nivelAcceso; }      
        }
        public float Sueldo
        {
            get { return sueldoBruto; }
            set { sueldoBruto = value; }
        }
        public float Comision
        {
            get { return comision; }
            set { comision = value; }
        }
        public override string ToString()
        {
            return ("Nombre: " + NombrePersona + "\nDocumento: " + DocumentoPersona + "\nEdad: " + EdadPersona + "\nNombre usuario: " + 
                    UsuarioLogin + "\nNivel de acceso: " + NivelAcceso + "\nSueldo: " + Sueldo);
        }

        public override void RealizarCalculos(float valor)
        {
            this.Comision = valor * 0.20f;
            this.Sueldo += this.Comision;
        }
    }
}
