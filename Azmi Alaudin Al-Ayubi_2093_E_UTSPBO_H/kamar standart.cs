using System;
using System.Collections.Generic;
using System.Text;

namespace Azmi_Alaudin_Al_Ayubi_2093_E_UTSPBO_H
{
    public class kamarstandart : Reservasikamar
    {
        private double hargaPerMalam;
        private int lamaMalam;

        public kamarstandart(string namatamu, string idBooking, string TipeKamar, int lamaMalam, double hargaPerMalam) : base(namatamu, idBooking, TipeKamar)
        {
            this.hargaPerMalam = hargaPerMalam;
            this.lamaMalam = lamaMalam;
        }

        public double HargaPerMalam
        {
            get { return hargaPerMalam;}
            set {  hargaPerMalam = value;}
        }

        public int lamamalam
        {
            get { return lamaMalam; }
            set { lamaMalam = value;}
        }


        public override double HitungTotalBilling()
        {
            return lamaMalam * hargaPerMalam;
        }

      
        









    }

}

    

