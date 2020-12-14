using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AE5.Models
{
    public class Cuenta
    {
        /*cuenta sin relaciones*/
        public string CuentaId { get; set; }
        public string Nombre { get; set; }
        public double Saldo { get; set; }
        /*hasta aqui*/

        /*una cuenta va a tener un usuario*/
        public string UsuarioId { get; set; }
        public Usuario usuario { get; set; }
    }
}