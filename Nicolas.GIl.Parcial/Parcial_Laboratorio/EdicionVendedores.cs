using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial_Library;
using static System.Windows.Forms.ImageList;

namespace Parcial_Laboratorio
{
    public partial class EdicionVendedores : Form
    {       
        private static bool flagNivelAcceso = false;
        private static bool flagNombreUsuario = false;
        private static bool flagContraseña = false;
        public EdicionVendedores()
        {
            InitializeComponent();    
        }
        
        private void dtgVendedores_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Aerolinea.indexVendedor = e.RowIndex + 1;
            if (Aerolinea.indexVendedor != -1)
            {
                ReiniciarLabels();
                IniciarLabels();
                ReiniciarFoto();
                txtCambios.Text = "";
            }
        }

        private void EdicionVendedores_Load(object sender, EventArgs e)
        {
            InicializarFotos();
            dtgVendedores.DataSource = null;         
            dtgVendedores.DataSource = Aerolinea.Usuarios.Values.ToList();
        }
        
        private void IniciarLabels()
        {
            lblNombreVendedor.Text = Aerolinea.Usuarios[Aerolinea.indexVendedor].NombrePersona;
            lblDNI.Text = Aerolinea.Usuarios[Aerolinea.indexVendedor].DocumentoPersona.ToString();
            lblEdad.Text = Aerolinea.Usuarios[Aerolinea.indexVendedor].EdadPersona.ToString();
            lblUsuario.Text = Aerolinea.Usuarios[Aerolinea.indexVendedor].UsuarioLogin;
            lblPermiso.Text = Aerolinea.Usuarios[Aerolinea.indexVendedor].NivelAcceso;           
        }

        private void ReiniciarLabels()
        {
            lblNombreVendedor.Refresh();
            lblDNI.Refresh();
            lblEdad.Refresh();
            lblUsuario.Refresh();
            lblPermiso.Refresh();
        }

        private void InicializarFotos()
        {
            ptbEsteban.Visible = false;
            ptbNacho.Visible = false;
            ptbOrne.Visible = false;
            ptbLucas.Visible = false;
            ptbRaffi.Visible = false;
        }
        private void ReiniciarFoto()
        {
            switch(Aerolinea.indexVendedor)
            {
                case 1:
                    ptbEsteban.Visible = false;
                    ptbNacho.Visible = false;
                    ptbOrne.Visible = false;
                    ptbLucas.Visible = false;
                    ptbRaffi.Visible = true;
                    break;
                case 2:
                    ptbEsteban.Visible = false;
                    ptbNacho.Visible = false;
                    ptbOrne.Visible = false;                   
                    ptbRaffi.Visible = false;
                    ptbLucas.Visible = true;
                    break;
                case 3:
                    ptbEsteban.Visible = false;
                    ptbNacho.Visible = false;          
                    ptbLucas.Visible = false;
                    ptbRaffi.Visible = false;
                    ptbOrne.Visible=true;
                    break;
                case 4:
                    ptbNacho.Visible = false;
                    ptbOrne.Visible = false;
                    ptbLucas.Visible = false;
                    ptbRaffi.Visible = false;
                    ptbEsteban.Visible = true;
                    break;
                case 5:
                    ptbEsteban.Visible = false;                    
                    ptbOrne.Visible = false;
                    ptbLucas.Visible = false;
                    ptbRaffi.Visible = false;
                    ptbNacho.Visible = true;
                    break;
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (Aerolinea.indexVendedor != -1)
            {
                flagNombreUsuario = true;
                InicializarEdicion("Ingrese nuevo nombre de usuario:");
                txtCambios.Visible = true;
            }
            else
            {
                lblIndexVacio.Text = "DEBE ELEJIR UN USUARIO ANTES";
                lblIndexVacio.Visible = true;
            }
        }

        private void btnEditarPermiso_Click(object sender, EventArgs e)
        {
            if (Aerolinea.indexVendedor != -1)
            {
                if (Aerolinea.Usuarios[Aerolinea.indexVendedor].NivelAcceso == "Administrador")
                {
                    flagNivelAcceso = true;
                    cmbPermisos.Visible = true;
                    cmbPermisos.Items.Add("Administrador");
                    cmbPermisos.Items.Add("Regular");
                    InicializarEdicion("Elija el nuevo tipo de permiso");
                }
            }else
            {
                lblIndexVacio.Text = "DEBE ELEJIR UN USUARIO ANTES";
                lblIndexVacio.Visible = true;
            }
        }

        private void btnEditarContraseña_Click(object sender, EventArgs e)
        {
            if (Aerolinea.indexVendedor != -1)
            {
                flagContraseña = true;
                InicializarEdicion("Nueva comtraseña:");
                txtCambios.Visible = true;
            }
            else
            {
                lblIndexVacio.Text = "DEBE ELEJIR UN USUARIO ANTES";
                lblIndexVacio.Visible = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void InicializarEdicion(string mensaje)
        {
            lblCambios.Visible = true;
            lblCambios.Text = mensaje;            
            btnAceptarEditar.Visible = true;
            btnCancelarEditar.Visible = true;
        }

        private void FinalizarEdicion()
        {
            lblCambios.Visible = false;
            lblCambios.Text = "";
            btnAceptarEditar.Visible = false;
            btnCancelarEditar.Visible = false;
            txtCambios.Refresh();
            txtCambios.Visible = false;
            cmbPermisos.Visible = false;
        }

        private void btnAceptarEditar_Click(object sender, EventArgs e)
        {
            if(flagNivelAcceso == true)
            {
                Aerolinea.Usuarios[Aerolinea.indexVendedor].NivelAcceso = cmbPermisos.Text;
                FinalizarEdicion();
                flagNivelAcceso = false;
            }

            if(flagNombreUsuario == true)
            {
                if(String.IsNullOrEmpty(txtCambios.Text) && Validador.ValidadarIngresaString(txtCambios.Text))
                {
                    Aerolinea.Usuarios[Aerolinea.indexVendedor].UsuarioLogin = txtCambios.Text;
                    FinalizarEdicion();
                    flagNombreUsuario = false;
                    lblNombreVendedor.Refresh();
                    lblNombreVendedor.Text = Aerolinea.Usuarios[Aerolinea.indexVendedor].UsuarioLogin;
                }
            }

            if(flagContraseña == true)
            {
                if(String.IsNullOrEmpty (txtCambios.Text) && Validador.ValidarIngresoCodigo(txtCambios.Text))
                {
                    Aerolinea.Usuarios[Aerolinea.indexVendedor].UsuarioPassword = txtCambios.Text;
                    FinalizarEdicion();
                    flagContraseña = false;
                }
            }
        }

        private void btnCancelarEditar_Click(object sender, EventArgs e)
        {
            lblCambios.Visible = false;
            btnAceptarEditar.Visible = false;
            btnCancelarEditar.Visible = false;
            txtCambios.Visible = false;
            cmbPermisos.Visible = false;
            flagNombreUsuario = false;
            flagNivelAcceso = false;
            flagContraseña = false;
        }
    }
}
