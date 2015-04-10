using System;
using System.Collections.Generic;
using System.Linq;

namespace GSM
{
    class CallHistoryTest
    {
        public void CallHistoryT()
        {
            MobilePhone Nokia6300 = new MobilePhone("6300", "Nokia");
            List<Call> durationHistory = new List<Call>();
            for (int i = 0; i < 6; i++)
            {
                durationHistory.Add(new Call(DateTime.Now, 35 + i * 5, "0888888888"));
            }
            foreach (var call in durationHistory)
            {
                Nokia6300.AddCalls(call);
            }
            foreach (var call in Nokia6300.CallHistory)
            {
                Console.WriteLine(@"Date and time of the call: {0}
Duration: {1}
Caller: {2}", call.DateAndTime, call.DurationInSeconds, call.PhoneNumber);
            }
            decimal cost = Nokia6300.CallsPrice(0.37M);
            Console.WriteLine("Total cost on calls for {0} is {1}", Nokia6300.Manufacturer + " " + Nokia6300.Model, cost);

            Call longestCall = Nokia6300.CallHistory.OrderBy(x => x.DurationInSeconds).LastOrDefault();

            Nokia6300.DeleteCalls(longestCall);

            decimal costWithoutLongest = Nokia6300.CallsPrice(0.37M);
            foreach (var call in Nokia6300.CallHistory)
            {
                Console.WriteLine(@"Date and time of the call: {0}
Duration: {1}
Caller: {2}", call.DateAndTime, call.DurationInSeconds, call.PhoneNumber);
            }
            Nokia6300.ClearCallHistory();

        }
    }
}