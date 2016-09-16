namespace MobilePhoneDevice
{
    using System;

    class GSMCallHistoryTest
    {
        GSM testGSMCalls = new GSM("Note I", "Samsung", 200.00m
               , "Random Owner", new Battery("Samsung - China", 1000, 100, BatteryType.LiIon), new Display(1000, 1000, "16M"));

        public void AddCalls()
        {
            testGSMCalls.AddCall("0885111111", 67);
            testGSMCalls.AddCall("0885222222", 103);
            testGSMCalls.AddCall("0885333333", 15);
            testGSMCalls.AddCall("0885444444", 78);
            testGSMCalls.AddCall("0885555555", 43);
        }

        public void PrintAllCallHistory()
        {
            testGSMCalls.ShowCallHistory();
        }

        public void PrintTotalCallPrice()
        {
            Console.WriteLine("Total call price: " + testGSMCalls.TotalCallPrice() + "\n");
        }

        public void RemoveLongestCall()
        {
            testGSMCalls.DeleteCalls(1);
            Console.WriteLine("Longest Call is removed");
            Console.WriteLine("Total call price after the remove: " + testGSMCalls.TotalCallPrice() + "\n");
        }

        public void ClearCallHistory()
        {
            testGSMCalls.ClearAllCalls();
            Console.WriteLine("Call history is cleared\n");
            testGSMCalls.ShowCallHistory();
        }
    }
}
