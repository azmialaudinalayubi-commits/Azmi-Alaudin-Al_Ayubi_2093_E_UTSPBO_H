using System;
using System.Collections.Generic;
using System.Text;

namespace Azmi_Alaudin_Al_Ayubi_2093_E_UTSPBO_H
{
    public class Kamarsuite : Reservasikamar
    {
        private double hargaPerMalam;
        private double biayaFasilitasVIP;
        private int lamaMalam;
    

    public Kamarsuite(string namatamu, string idBooking, string Tipekamar, double hargaPerMalam, double biayaFasilitasVIP, int lamaMalam) : base(namatamu, idBooking, Tipekamar)
    {

            this.hargaPerMalam = hargaPerMalam;
        this.biayaFasilitasVIP = biayaFasilitasVIP;
        this.lamaMalam = lamaMalam;

    }
        public override double HitungTotalBilling()
        {
            return (lamaMalam * hargaPerMalam) + biayaFasilitasVIP;
        }
    }
}

   
   


