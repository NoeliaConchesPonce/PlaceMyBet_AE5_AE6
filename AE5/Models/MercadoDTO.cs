namespace AE5.Models
{
    public class MercadoDTO
    {
        public double OverUnder { get; set; }
        public double CuotaOver { get; set; }
        public double CuotaUnder { get; set; }

        public MercadoDTO(double overUnder, double cuotaOver, double cuotaUnder)
        {
            OverUnder = overUnder;
            CuotaOver = cuotaOver;
            CuotaUnder = cuotaUnder;
        }

        public MercadoDTO()
        {
        }


    }
}