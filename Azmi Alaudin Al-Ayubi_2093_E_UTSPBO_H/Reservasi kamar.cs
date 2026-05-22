using System;
using System.Collections.Generic;
using System.Text;

namespace Azmi_Alaudin_Al_Ayubi_2093_E_UTSPBO_H
{
    public class Reservasi_kamar
    {
        private string namatamu;
        private string idBooking;
        private string TipeKamar;
        protected int tanggalChekin;

        public string Tipekamar { get; private set; }    
    )
    public Reservasi_kamar(string namatamu, string idBooking, string tipeKamar,int tanggalChekin)
    {
            this.namatamu = namatamu;
            this.idBooking = idBooking; 
            this.TipeKamar = tipeKamar;
            this.tanggalChekin = tanggalChekin;
    }

     protected Reservasi_kamar(string namatamu, int tanggalChekin)
        {
            this.namatamu =namatamu; 
            this.tanggalChekin=tanggalChekin;
        }
    

    public string getnamatamu()
    {
            return namatamu;
    }

    public override double setnamatamu(string namatamu)
    {
        this.namatamu =namatamu;
    }

    public string getidBooking (string idBooking)
    {
        return idBooking;
    }

    public override setidBooking (string idBooking)
    {
        this.idBooking= idBooking;
    }

    public string getTipekamar (string Tipekamar)
    {
            return Tipekamar;
    }

    public void settanggalChekin(int tanggalChekin)
    {
            this.tanggalChekin = tanggalChekin;
    }


    public void Tampilaninfo()
    {
            Console.WriteLine("Nama Tamu : namatamu");
            Console.WriteLine("id Booking : idBooking");
            Console.WriteLine("Tipe kamar : TipeKamar");
            Console.WriteLine("Tanggal Chekin : TanggalChekin");
    }
    
}
