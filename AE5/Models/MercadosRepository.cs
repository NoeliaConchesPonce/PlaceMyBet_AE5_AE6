﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AE5.Models
{
    public class MercadosRepository
    {
        // recuperar todas las mercados
        public List<Mercado> retrieve()
        {
            List<Mercado> mercados;
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                mercados = context.Mercado.ToList();

            }
            return mercados;
        }

        //recuperar un mercado a partir de su id
        public Mercado retireveId(int id)
        {
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                var mercado = context.Mercado.FirstOrDefault(m => m.MercadoId == id);
                return mercado;
            }
                 
        }
    }
}