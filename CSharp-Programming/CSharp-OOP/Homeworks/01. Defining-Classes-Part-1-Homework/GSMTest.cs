namespace MobilePhoneDevice
{
    using System;
    using System.Collections.Generic;

    class GSMTest
    {
        GSM gsm1 = new GSM("Note I", "Samsung", 200.00m
                , "Random Owner", new Battery("Samsung - China", 900, 100, BatteryType.LiIon), new Display(1000, 1000, "16M"));
        GSM gsm2 = new GSM("Note II", "Samsung", 400.00m
                , "Random Owner", new Battery("Samsung - China", 1000, 150, BatteryType.NiCd), new Display(1000, 1000, "16M"));
        GSM gsm3 = new GSM("Note III", "Samsung", 600.00m
                , "Random Owner", new Battery("Samsung - China", 1100, 200, BatteryType.NiMH), new Display(1000, 1000, "16M"));      

        public void DisplayTheGSMArray()
        {
            List<GSM> gsmArray = new List<GSM>();

            gsmArray.Add(gsm1);
            gsmArray.Add(gsm2);
            gsmArray.Add(gsm3);
            gsmArray.Add(GSM.IPhone4S);

            foreach (var item in gsmArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
