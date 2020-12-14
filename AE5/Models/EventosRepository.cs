using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AE5.Models
{
    public class EventosRepository
    {
        // recuperar todas las eventos
        public List<Evento> retrieve()
        {
            List<Evento> eventos;
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                eventos = context.Evento.ToList();

            }
            return eventos;
        }

        public void Save (Evento e)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            context.Evento.Add(e);
            context.SaveChanges();

        }

        public void updateEventos(int id, string eLocal, string eVisitante)
        {
            Evento evento;
            PlaceMyBetContext context = new PlaceMyBetContext();
            evento = context.Evento.FirstOrDefault(a => a.EventoId == id);

            evento.EquipoLocal = eLocal;
            evento.EquipoVisitante = eVisitante;

            context.SaveChanges();
        }

        public void deleteEventos (int id)
        {
            Evento evento;
            PlaceMyBetContext context = new PlaceMyBetContext();
            evento = context.Evento.FirstOrDefault(a => a.EventoId == id);

            context.Remove(evento);
            context.SaveChanges();
        }
     
    }
}