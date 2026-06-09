using System;
using System.Collections.Generic;
using System.Text;
using System;

namespace Azmi_Alaudin_Al_Ayubi_2093_E_UTSPBO_H
{
    public abstract class Reservasikamar
    {
        private string namatamu;
        private string idBooking;
        private string tipeKamar;

        public Reservasikamar(string namatamu, string idBooking, string tipeKamar)
        {
            this.namatamu = namatamu;
            this.idBooking = idBooking;
            this.tipeKamar = tipeKamar;
        }

        public string NamaTamu
        {
            get { return namatamu; }
            set { namatamu = value; }
        }

        public string IdBooking
        {
            get { return idBooking; }
            set { idBooking = value; }
        }

        public string TipeKamar
        {
            get { return tipeKamar; }
            set { tipeKamar = value; }
        }

        public void TampilInfo()
        {
            Console.WriteLine("Nama Tamu  : " + namatamu);
            Console.WriteLine("ID Booking : " + idBooking);
            Console.WriteLine("Tipe Kamar : " + tipeKamar);
        }

        public abstract double HitungTotalBilling();
    }
}
