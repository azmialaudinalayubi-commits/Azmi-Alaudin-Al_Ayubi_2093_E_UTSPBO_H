using System;

using System;

namespace Azmi_Alaudin_Al_Ayubi_2093_E_UTSPBO_H
{
    class Program
    {
        static void Main(string[] args)
        {
            Reservasikamar standar =
                new kamarstandart(
                    "Azmi",
                    "BK001",
                    "Standard",
                    350000,
                    3);

            Console.WriteLine("===== KAMAR STANDARD =====");
            standar.TampilInfo();
            Console.WriteLine("Total Billing : Rp " +
                              standar.HitungTotalBilling());

            Console.WriteLine();

            Reservasikamar suite =
                new Kamarsuite(
                    "Azma",
                    "BK002",
                    "Suite",
                    750000,
                    500000,
                    2);

            Console.WriteLine("===== KAMAR SUITE =====");
            suite.TampilInfo();
            Console.WriteLine("Total Billing : Rp " +
                              suite.HitungTotalBilling());

            Console.ReadKey();
        }
    }
}
