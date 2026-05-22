using System;
using System.Collections.Generic;
using System.Text;

namespace Azmi_Alaudin_Al_Ayubi_2093_E_UTSPBO_H
{
    public class kamarstandart : Reservasi_kamar
    {
      private  int hargaPermalam;
    }

    public kamarstandart(int hargaPermalam, string namatamu, string idBooking, string TipeKamar, int tanggalChekin) : base (namatamu, idBooking, TipeKamar,tanggalChekin)
    {
            this.hargaPermalam = hargaPermalam;
    }

    public string gethargaPermalam()
    {
         return.hargaPermalam;
    } 


    public void sethargaPermalam()
    {
            this.hargaPermalam = hargaPermalam;
    }

    public string gettanggalChekin()
    {
            return.tanggalChekin;
    }

       
    




    
    
}
