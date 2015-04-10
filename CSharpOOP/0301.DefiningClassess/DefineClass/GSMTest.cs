
namespace GSM
{
    class GSMTest
    {
        public MobilePhone[] test = {new MobilePhone("iPhone 6 Plus", "Apple", 999.99M, "Not Me",
                                        new Battery("Normal", 10, 1, BatteryType.LiIon), new Display(4.3f, 16000000)), 
                                    new MobilePhone("One M8", "HTC", 899.99M, "Dentia",
                                        new Battery("Normal", 1000, 150, BatteryType.LiPoly), new Display(5f, 16000000)),
                                    new MobilePhone("Desire 500", "HTC", 399.99M, "Boris Stoyanov",
                                        new Battery("Normal", 500, 75, BatteryType.NiMH), new Display(4.7f, 16000000))};
        public void DisplayGSM()
        {
            for (int i = 0; i < test.Length; i++)
            {
                System.Console.WriteLine(test[i].ToString());
            }
            System.Console.WriteLine(MobilePhone.iPhone4S.ToString());
        }
    }
}
