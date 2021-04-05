using System;

namespace Item20
{
    
    public class Consultant
    {

        public event Action<Consultant, EventArgs> LocationChanged;
        public event Action<Consultant, EventArgs> AvailabilityChanged;

        private string _current_location = "Home";
        private string Home = "Home";
        private bool _availableAtHome;

        public bool IsAvailable
        {
            get { return IsAvailableAt(_current_location); }
        }
        private bool IsAvailableAt(string location)
        {
            return (location == Home) ? _availableAtHome : true;
        }

        public void HandleMovement(MsgMovement movement)
        {
            if (_current_location != movement.Place)
            {
                if (LocationChanged != null) LocationChanged(this, EventArgs.Empty);
                if (IsAvailableAt(movement.Place) != IsAvailable)
                {
                    if (AvailabilityChanged != null) AvailabilityChanged(this, EventArgs.Empty);
                }
                _current_location = movement.Place;
            }
        }
    }

}