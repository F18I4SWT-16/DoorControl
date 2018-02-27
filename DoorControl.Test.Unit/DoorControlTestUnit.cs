using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorControl.Library;
using NSubstitute;
using NUnit.Framework;

namespace DoorControl.Test.Unit
{
    [TestFixture]
    public class DoorControlTestUnit
    {
        private DoorController _uut;
        private IDoor _door;
        private IEntryNotification _entry;
        private IUserValidation _validation;

        [SetUp]
        public void Setup()
        {
            _door = Substitute.For<IDoor>();
            _entry = Substitute.For<IEntryNotification>();
            _validation = Substitute.For<IUserValidation>();
            _uut = new DoorController(_door,_validation, _entry);
        }

        [Test]
        public void RequestEntry_ValidateID_()
        {
            
        }


    }
}