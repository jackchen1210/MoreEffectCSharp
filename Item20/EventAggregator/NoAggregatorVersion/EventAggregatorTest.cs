using System;

namespace Item20
{
      public class EventAggregatorTest
    {
        public static void Test()
        {
            var consultantA = new Consultant();
            consultantA.LocationChanged += OnLocationChanged;
            consultantA.AvailabilityChanged += OnAvailabilityChanged;
            consultantA.HandleMovement(new MsgMovement
            {
                Place = "Company"
            });
            consultantA.HandleMovement(new MsgMovement
            {
                Place = "Company1"
            });
        }

        public static void OnLocationChanged(object sender, EventArgs args)
        {
            System.Console.WriteLine("OnLocationChanged");
        }
        public static void OnAvailabilityChanged(object sender, EventArgs args)
        {
            System.Console.WriteLine("OnAvailabilityChanged");
        }
    }

}