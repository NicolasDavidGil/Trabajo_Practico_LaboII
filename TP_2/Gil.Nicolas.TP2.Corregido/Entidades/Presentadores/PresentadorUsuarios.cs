using Entidades.Interfaces;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Repositorio;
using System.Numerics;

namespace Entidades.Presentadores
{
    public class PresentadorUsuarios
    {
        IVistaUsuarios _usuarios;
        List<Usuario> _usuariosList;

        public PresentadorUsuarios(IVistaUsuarios usuarios)
        {
            _usuariosList = new List<Usuario>();
            this._usuarios = usuarios;
            this._usuarios.FiltrarDataGridEvento += RealizarBusqueda;
        }  

        public void RealizarBusqueda()
        {
            bool verificado = String.IsNullOrWhiteSpace(_usuarios.ValorBusqueda);
            if (verificado == false)
            {
                _usuariosList = new RepositorioDeAcceso().ObtenerUsuariosPorValor(_usuarios.ValorBusqueda);
            }
            else
            {
                _usuariosList = new RepositorioDeAcceso().ObtenerUsuarios();
            }
            _usuarios.LlenarDataGridView();    
        }
        public List<Usuario> TraerUsuariosDesdeBase()
        {
            List<Usuario> usuarios = new RepositorioDeAcceso().ObtenerUsuarios();

            return usuarios;
        }
        public List<string> TraerPaisesDesdeBase()
        {
            return new RepositorioDeAcceso().ObtenerPaises();
        }

        public bool EditarBaseDeUsuarios(int aux, Usuario edicion)
        {
            bool retorno = false;
            switch(aux)
            {
                case 1:
                    retorno = new RepositorioDeAcceso().AgregarUsuarioNuevo(edicion);
                    break;
                case 2:
                    retorno = new RepositorioDeAcceso().EditarUsuario(edicion);
                    break;
                case 3:
                    retorno = new RepositorioDeAcceso().BorrarUsuarioDeLaBase(edicion);
                    break;
            }
            return retorno;
        }

        public List<Usuario> TraerUsuariosActivos()
        {
            List<Usuario> aux = new List<Usuario>();

            foreach(Usuario x in TraerUsuariosDesdeBase())
            {
                if(x.EstadoCuenta == 1)
                    aux.Add(x);
            }

            return aux;
        }

        public string VerificarDatos(int aux, Usuario modificar)
        {            
            bool existe = false;
            string retorno = "vacio";
            switch(aux)
            {
                case 1:
                    if (!String.IsNullOrWhiteSpace(_usuarios.NombreNuevo) && !String.IsNullOrWhiteSpace(_usuarios.EdadNuevo) &&
                        !String.IsNullOrWhiteSpace(_usuarios.DniNuevo) && !String.IsNullOrWhiteSpace(_usuarios.ApodoNuevo) && 
                        !String.IsNullOrWhiteSpace(_usuarios.ContraseñaNuevo) && !String.IsNullOrWhiteSpace(_usuarios.AccesoNuevo) &&
                        !String.IsNullOrWhiteSpace(_usuarios.NacionNuevo))
                    {
                        Usuario auxJug = new Usuario(_usuarios.NombreNuevo, int.Parse(_usuarios.EdadNuevo), int.Parse(_usuarios.DniNuevo), _usuarios.NacionNuevo,
                                               _usuarios.ApodoNuevo, _usuarios.ContraseñaNuevo, _usuarios.AccesoNuevo, 0, 0, 0, 1);
                        foreach(Usuario usuarios in TraerUsuariosDesdeBase())
                        {
                            if(usuarios.Documento == auxJug.Documento)
                            {
                                existe = true;
                                retorno = "dni";
                            }
                            if(usuarios.Nombre == auxJug.Nombre)
                            {
                                existe = true;
                                retorno = "nombre";
                            }
                            if(usuarios.NombreUsuario == auxJug.NombreUsuario)
                            {
                                existe = true;
                                retorno = "usuario";
                            }
                        }

                        if(existe == false)
                        {
                            if (EditarBaseDeUsuarios(1, auxJug))
                                retorno = "ok";
                            else
                                retorno = "fallo";
                        }
                    }               
                    break;
                case 2:
                    if (!String.IsNullOrWhiteSpace(_usuarios.NombreEditar) && !String.IsNullOrWhiteSpace(_usuarios.AccesoEditar) &&
                       !String.IsNullOrWhiteSpace(_usuarios.NacionEditar))
                    {
                        Usuario auxJug = new Usuario(modificar.Nombre, modificar.Edad, modificar.Documento, _usuarios.NacionEditar,
                                               _usuarios.NombreEditar, modificar.Contraseña, _usuarios.AccesoEditar, modificar.Puntaje, modificar.Victorias, 
                                               modificar.Derrotas, modificar.EstadoCuenta);
                        if (EditarBaseDeUsuarios(2, auxJug))
                            retorno = "ok";
                        else
                            retorno = "fallo";
                    }
                    break;
                case 3:
                    if (!String.IsNullOrWhiteSpace(_usuarios.ApodoBorrar) && !String.IsNullOrWhiteSpace(_usuarios.EdadBorrar) &&
                        !String.IsNullOrWhiteSpace(_usuarios.NombreBorrar) && !String.IsNullOrWhiteSpace(_usuarios.DniBorrar) &&
                        !String.IsNullOrWhiteSpace(_usuarios.RazonEliminacion))
                    {
                        modificar.Puntaje = 0;
                        modificar.Victorias = 0;
                        modificar.Derrotas = 0;
                        modificar.EstadoCuenta = 0;
                        if (EditarBaseDeUsuarios(3, modificar))
                            retorno = "ok";
                        else
                            retorno = "fallo";                        
                    }
                    break;
            }
            return retorno;
        }       
    }
}
