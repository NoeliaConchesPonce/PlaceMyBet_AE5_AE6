using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AE5.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public DateTime Fecha { get; set; }

        /*un mercado va a tener varios eventos por eso hacemos una lista*/
        List<Mercado> mercados  { get; set; }

        /*hacemos constructores contrl . generar constructor primero sin mercado y luego vacio*/
        public Evento(int eventoId, string equipoLocal, string equipoVisitante, DateTime fecha)
        {
            EventoId = eventoId;
            EquipoLocal = equipoLocal;
            EquipoVisitante = equipoVisitante;
            Fecha = fecha;
        }

        public Evento()
        {
        }
    }
}