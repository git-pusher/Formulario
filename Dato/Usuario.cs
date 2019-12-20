using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using videoFormulario.Modelo;

namespace videoFormulario.Dato
{
    public class Usuario
    {
        List<UsuarioModelo> lista = new List<UsuarioModelo>();
        /// <summary>
        /// Guarda los usuarios
        /// </summary>
        /// <param name="modelo">Datos del usuario</param>
        public void Guardar(UsuarioModelo modelo)
        {
            lista.Add(modelo);
        }
        /// <summary>
        /// Consulta todos los usuarios
        /// </summary>
        /// <returns>Datos de usuarios</returns>
        public List<UsuarioModelo> Consultar()
        {
            return lista;
        }
    }
}
