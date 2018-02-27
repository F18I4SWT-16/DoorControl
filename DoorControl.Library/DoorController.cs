using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl.Library
{
    public class DoorController
    {
        private IDoor _door;
        private IUserValidation _validation;
        private IEntryNotification _entry;

        private DoorState _state;

        private enum DoorState
        {
            Open,
            Closed,
            Opening,
            Closing
        }

        public DoorController(IDoor door, IUserValidation validation, IEntryNotification entry)
        {
            _door = door;
            _validation = validation;
            _entry = entry;

            _state = DoorState.Closed;
        }

        public void RequestEntry(int id)
        {
            if (_validation.ValidateEntryReuest(id))
            {
                _door.Open();
                _state = DoorState.Opening;
                _entry.NotifyEntryGranted();
            }
        }
        public void DoorOpened()
        {
            _state = DoorState.Open;
            _door.Close();
            _state = DoorState.Closing;
        }

        public void DoorClosed()
        {
            _state = DoorState.Closed;
        }
    }
}
