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

        //hacempos constrcutores sin mercado y usuario y uno vacio
        public Apuesta(int apuestaId, double overUnder, string tipoApuesta, double cuota, double dineroApuesta, DateTime fecha, int eventoId, int mercadoId, string usuarioId)
        {
            ApuestaId = apuestaId;
            OverUnder = overUnder;
            TipoApuesta = tipoApuesta;
            Cuota = cuota;
            DineroApuesta = dineroApuesta;
            Fecha = fecha;
            EventoId = eventoId;
            MercadoId = mercadoId;
            UsuarioId = usuarioId;
        }

        public Apuesta()
        {
        }

        public class ApuestasDTO
        {
            public string UsuarioId { get; set; }
            public int EventoId { get; set; }
            public string tipoApuesta { get; set; }
            public double cuota  { get; set; }
            public double dineroApuesta  { get; set; }
            public Mercado Mercado  { get; set; }

            public ApuestasDTO(string usuarioId, int eventoId, string tipoApuesta, double cuota, double dineroApuesta, Mercado mercado)
            {
                UsuarioId = usuarioId;
                EventoId = eventoId;
                this.tipoApuesta = tipoApuesta;
                this.cuota = cuota;
                this.dineroApuesta = dineroApuesta;
                Mercado = mercado;
            }

            public ApuestasDTO()
            {
            }
        }
    }
}