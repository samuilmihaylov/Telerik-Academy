namespace MobilePhoneDevice
{
    using System;

    class Startup
    {
        static void Main(string[] args)
        {
            var gsmTest = new GSMTest();
            gsmTest.DisplayTheGSMArray();

            var gsmTestCalls = new GSMCallHistoryTest();
            gsmTestCalls.AddCalls();
            gsmTestCalls.PrintAllCallHistory();
            gsmTestCalls.PrintTotalCallPrice();
            gsmTestCalls.RemoveLongestCall();
            gsmTestCalls.ClearCallHistory();
        }
    }
}
