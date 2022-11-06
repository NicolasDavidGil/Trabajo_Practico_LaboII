using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial.Library;

namespace Parcial_Laboratorio
{
    public partial class frmReestablecerContraseña : Form
    {
        int index;
        public frmReestablecerContraseña()
        {
            InitializeComponent();
        }

        private void frmReestablecerContraseña_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<int, Usuario> i in Aerolinea.Usuarios)
            {
                cobUsuario.Items.Add(i.Value.NombrePersona);
                index = i.Key;
            }
        }

        private void cobUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRespuestaSecreta.Text = "";
            lblContraseña.Text = "";
            lblPregunta.Text = "";  
            AsignarPregunta(index);
        }

        private void AsignarPregunta(int key)
        {
            foreach (KeyValuePair<int, Usuario> i in Aerolinea.Usuarios)
            {
                if (cobUsuario.Text == i.Value.NombrePersona)
                {
                    index = i.Key;
                }
            }

            switch (index)
            {
                case 1:
                    lblPregunta.Text = "¿Cuál es el mejor equipo de argentina?";
                    break;
                case 2:
                    lblPregunta.Text = "¿Cuál es el pajaro mas bello?";
                    break;
                case 3:
                    lblPregunta.Text = "¿Qué aparato usan tus gatos para calentarse?";
                    break;
                case 4:
                    lblPregunta.Text = "¿Cuál es el dios nordico padre de todos?"; 
                    break;
                case 5:
                    lblPregunta.Text = "¿Qué saga tiene algo para gobernar a todos?";
                    break;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch(index)
            {
                case 1:
                    if(txtRespuestaSecreta.Text.ToLower() == "boca")
                    {
                        lblContraseña.Text = "Correcto, su contraseña es 12345";
                    }else
                    {
                        lblContraseña.Text = "Error, respuesta incorrecta";
                    }
                    break;
                case 2:
                    if (txtRespuestaSecreta.Text.ToLower() == "condor")
                    {
                        lblContraseña.Text = "Correcto, su contraseña es 12345";
                    }
                    else
                    {
                        lblContraseña.Text = "Error, respuesta incorrecta";
                    }
                    break;
                case 3:
                    if (txtRespuestaSecreta.Text.ToLower() == "modem")
                    {
                        lblContraseña.Text = "Correcto, su contraseña es 12345";
                    }
                    else
                    {
                        lblContraseña.Text = "Error, respuesta incorrecta";
                    }
                    break;
                case 4:
                    if (txtRespuestaSecreta.Text.ToLower() == "odin")
                    {
                        lblContraseña.Text = "Correcto, su contraseña es 12345";
                    }
                    else
                    {
                        lblContraseña.Text = "Error, respuesta incorrecta";
                    }
                    break;
                case 5:
                    if (txtRespuestaSecreta.Text.ToLower() == "señor de los anillos")
                    {
                        lblContraseña.Text = "Correcto, su contraseña es 12345";
                    }
                    else
                    {
                        lblContraseña.Text = "Error, respuesta incorrecta";
                    }
                    break;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
