using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AE5.Models
{
    public class Apuesta
    {
        /*Tenemos la apuesta sin relaciones*/
        public int ApuestaId { get; set; }
        public double OverUnder  { get; set; }
        public string TipoApuesta { get; set; }
        public double Cuota  { get; set; }
        public double DineroApuesta { get; set; }
        public DateTime Fecha  { get; set; }

        /*hasta aqui*/

        /*relacionamos una apuesta con un evento*/
        public int EventoId { get; set; }

        /*una apuesta solo va a guardar un mercado*/
        public int MercadoId { get; set; }
        public Mercado mercado { get; set; }

        /*una apuesta tiene que estar hecha por un usuario, es decir, relacionamos una apuesta con un usuario*/
        public string UsuarioId { get; set; }

        public Usuario usuario { get; set; }

    }
}