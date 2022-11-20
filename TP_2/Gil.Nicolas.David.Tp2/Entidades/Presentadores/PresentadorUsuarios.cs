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
        IUsuarios _usuarios;
        List<Usuario> _usuariosList;

        public PresentadorUsuarios(IUsuarios usuarios)
        {
            _usuariosList = new List<Usuario>();
            this._usuarios = usuarios;
            this._usuarios.FiltrarDataGridEvento += RealizarBusqueda;
        }

        public IUsuarios IUsuarios
        {
            get => default;
            set
            {
            }
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
            _usuarios.SetDataGridList(_usuariosList);    
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

        public bool VerificarDatos(int aux, Usuario modificar)
        {
            bool retorno = false;
            bool existe = false;
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
                        _usuariosList.ForEach(usuarios =>
                        {
                            if(usuarios.Documento == auxJug.Documento || usuarios.Nombre == auxJug.Nombre || usuarios.NombreUsuario == auxJug.NombreUsuario)
                            {
                                existe = true;                                
                            }
                        });

                        if(existe == false)
                        {
                            _usuarios.AddUser(auxJug);
                            retorno = true;
                        }                      
                    }
                    break;
                case 2:
                    if (!String.IsNullOrWhiteSpace(_usuarios.ApodoNuevo) && !String.IsNullOrWhiteSpace(_usuarios.AccesoNuevo) &&
                       !String.IsNullOrWhiteSpace(_usuarios.NacionNuevo))
                    {
                        Usuario auxJug = new Usuario(modificar.Nombre, modificar.Edad, modificar.Documento, _usuarios.NacionEditar,
                                               _usuarios.NombreEditar, modificar.Contraseña, _usuarios.AccesoEditar, modificar.Puntaje, modificar.Victorias, 
                                               modificar.Derrotas, modificar.EstadoCuenta);
                        _usuarios.EditUser(auxJug);
                        retorno = true;
                    }
                    break;
                case 3:
                    if (!String.IsNullOrWhiteSpace(_usuarios.ApodoBorrar) && !String.IsNullOrWhiteSpace(_usuarios.EdadBorrar) &&
                        !String.IsNullOrWhiteSpace(_usuarios.NombreBorrar) && !String.IsNullOrWhiteSpace(_usuarios.DniBorrar) && 
                        !String.IsNullOrWhiteSpace(_usuarios.RazonEliminacion))
                    {
                        Usuario auxJug = new Usuario(modificar.Nombre, modificar.Edad, modificar.Documento, modificar.Nacionalidad,
                                           modificar.NombreUsuario, modificar.Contraseña, modificar.NivelAcceso, modificar.Puntaje = 0, modificar.Victorias = 0,
                                           modificar.Derrotas = 0, modificar.EstadoCuenta = -1);
                        _usuarios.DeleteUser(auxJug);
                        retorno = true;
                    }
                    break;
            }
            return retorno;
        }       
    }
}
