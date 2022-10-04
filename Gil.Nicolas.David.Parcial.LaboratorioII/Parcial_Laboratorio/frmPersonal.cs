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
    public partial class frmPersonal : Form
    {
        private int index;
        private int auxModificacion;
        public frmPersonal()
        {
            InitializeComponent();
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {            
            foreach (KeyValuePair<int, Usuario> i in Aerolinea.Usuarios)
            {
                cobVendedores.Items.Add(i.Value.NombrePersona);
            }
            pnlModificacion.Visible = false;
            auxModificacion = 0;
            index = -1;
        }

        private void cobVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {            
            IniciarLabels();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            pnlModificacion.Visible = true;
            lblModificacion.Text = "Ingrese nuevo nombre de usuario:";
            auxModificacion = 1;
        }

        private void btnEditarNombre_Click(object sender, EventArgs e)
        {
            pnlModificacion.Visible = true;
            lblModificacion.Text = "Ingrese nuevo nombre de vendedor:";
            auxModificacion = 2;
        }

        private void btnEditarDni_Click(object sender, EventArgs e)
        {
            pnlModificacion.Visible = true;
            lblModificacion.Text = "Ingrese nuevo dni de vendedor:";
            auxModificacion = 3;
        }
        private void btnEditarEdad_Click(object sender, EventArgs e)
        {
            pnlModificacion.Visible = true;
            lblModificacion.Text = "Ingrese nuevo edad de vendedor:";
            auxModificacion = 4;
        }

        private void btnConfirmarEdicion_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtModificacion.Text))
            {
                if(VerificarModificacion())
                {
                    AsignarModificacion();
                    pnlModificacion.Visible = false;                    
                    IniciarLabels();
                }
            }
        }

        private void btnCancelarEdicion_Click(object sender, EventArgs e)
        {
            pnlModificacion.Visible = false;
            auxModificacion = 0;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

      

        private void IniciarLabels()
        {
            foreach (KeyValuePair<int, Usuario> i in Aerolinea.Usuarios)
            {
                if (i.Value.NombrePersona == cobVendedores.Text)
                {
                    lblClienteElegido.Refresh();
                    lblClienteElegido.Text = Aerolinea.Usuarios[i.Key].ToString();
                    AsignarImagen(i.Key);
                    index = i.Key;
                }
            }
        }
        private void AsignarImagen(int key)
        {
            switch (key)
            {
                case 1:
                    ptbUsuario.Image = Image.FromFile("Raffi.jpg");
                    break;
                case 2:
                    ptbUsuario.Image = Image.FromFile("Lucas.jpg");
                    break;
                case 3:
                    ptbUsuario.Image = Image.FromFile("Orne.jpg");
                    break;
                case 4:
                    ptbUsuario.Image = Image.FromFile("Esteban.jpg");
                    break;
                case 5:
                    ptbUsuario.Image = Image.FromFile("Nacho.jpg");
                    break;
            }
        }

        private bool VerificarModificacion()
        {
            bool retorno = false;

            switch (auxModificacion)
            {
                case 1:
                    if(Validador.ValidarIngresoCodigo(txtModificacion.Text))
                    {
                        retorno = true;
                    }
                    break;
                case 2:
                    if(Validador.ValidadarIngresaString(txtModificacion.Text))
                    {
                        retorno = true;
                    }
                    break;
                case 3:
                    if(Validador.ValidarIngresoNumero(txtModificacion.Text) && txtModificacion.Text.Length < 8
                        && txtModificacion.Text.Length > 6)
                    {
                        retorno = true;    
                    }
                    break;
                case 4:
                    if(Validador.ValidarIngresoNumero(txtModificacion.Text) && int.Parse(txtModificacion.Text) > 18
                        && int.Parse(txtModificacion.Text) < 70)
                    {
                        retorno = true;
                    }
                    break;

            }
            return retorno;
        }

        private void AsignarModificacion()
        {
            switch (auxModificacion)
            {
                case 1:
                    Aerolinea.Usuarios[index].UsuarioLogin = txtModificacion.Text;
                    break;
                case 2:
                    Aerolinea.Usuarios[index].NombrePersona = txtModificacion.Text;    
                    break;
                case 3:
                    Aerolinea.Usuarios[index].DocumentoPersona = int.Parse(txtModificacion.Text);
                    break;
                case 4:
                    Aerolinea.Usuarios[index].EdadPersona = int.Parse(txtModificacion.Text);
                    break;

            }
                      
        }
    }
}
