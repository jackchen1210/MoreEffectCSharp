using System;

namespace Item20
{
    public class EventAggregator
    {
        public event Action<Consultant, EventArgs> ConsultantChanged;
        public event Action<Consultant, EventArgs> ConsultantLocationChanged;
        public event Action<Consultant, EventArgs> ConsultantAvailabilityChanged;

        private void HandleConsultantLocationChanged(Consultant consultant, EventArgs args)
        {
            if (ConsultantLocationChanged != null) ConsultantLocationChanged(consultant, args);
            if (ConsultantChanged != null) ConsultantChanged(consultant, args);
        }
        private void HandleConsultantAvailabilityChanged(Consultant consultant, EventArgs args)
        {
            if (ConsultantAvailabilityChanged != null) ConsultantAvailabilityChanged(consultant, args);
            if (ConsultantChanged != null) ConsultantChanged(consultant, args);
        }
        public void Listen(Consultant subject)
        {
            subject.LocationChanged += HandleConsultantLocationChanged;
            subject.AvailabilityChanged += HandleConsultantAvailabilityChanged;
        }
    }
}