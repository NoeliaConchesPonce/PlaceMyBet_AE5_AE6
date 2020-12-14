using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AE5.Models
{
    public class ApuestasRepository
    {
        // recuperar todas las apuestas
        public List<Apuesta> retrieve()
        {
            List<Apuesta> apuestas;
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                apuestas = context.Apuesta.ToList();

            }
            return apuestas;
        }
        //recuperar un apuesta a partir de su id
        public Apuesta retireveId(int id)
        {
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                var apuesta = context.Apuesta.FirstOrDefault(a => a.ApuestaId == id);
                return apuesta;
            }

        }
    }
}