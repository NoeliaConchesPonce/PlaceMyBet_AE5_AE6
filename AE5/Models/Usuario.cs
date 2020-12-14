using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AE5.Models
{
    public class Usuario
    {
        /*Tenemos al usuario sin relaciones*/
        public string UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        /*hasta aqui*/

        /*un usuario puede hacer muchas apuestas*/
        List<Apuesta> apuestas { get; set; }

        /*relacionar un usuario con una cuenta*/
        public Cuenta cuenta { get; set; }

        //constructor menos cuenta y apuestas
        public Usuario(string usuarioId, string nombre, string apellido, int edad)
        {
            UsuarioId = usuarioId;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public Usuario()
        {
        }
    }
}