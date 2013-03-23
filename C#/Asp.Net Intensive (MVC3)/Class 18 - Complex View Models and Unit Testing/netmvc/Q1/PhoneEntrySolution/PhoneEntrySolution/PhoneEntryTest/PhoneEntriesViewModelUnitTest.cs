using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using web.Models;

namespace PhoneEntryTest
{
    [TestClass]
    public class PhoneEntriesViewModelUnitTest
    {
        [TestMethod]
        public void ModelIsNotNull()
        {
            var model = new PhoneNumberEntriesViewModel {};
            Assert.IsNotNull(model);
        }

        [TestMethod]
        public void AllTypesMethodIsWorking()
        {
            var model = new PhoneNumberEntriesViewModel { };
            var count = Enum.GetValues(new PhoneNumberTypes().GetType()).Length;
            //var count = Enum.GetValues(typeof(PhoneNumberTypes)).Length;
            Assert.AreEqual(model.AllTypes().Count, count);
        }

        [TestMethod]
        public void UsedTypeMethodIsReturningCorrectValues()
        {
            var model = new PhoneNumberEntriesViewModel { };
            var totalCount = model.AllTypes().Count;

            Assert.AreEqual(model.UsedTypes().Count, 0);

            var car = new PhoneNumberEntry{PhoneNumberType = PhoneNumberTypes.Car};
            model.Entries.Add(car);

            Assert.AreEqual(model.UsedTypes().Count, 1);

            Assert.IsTrue(model.UsedTypes().Contains(car.PhoneNumberType));
        }

        [TestMethod]
        public void AvailableTypesIsWorking()
        {
            var model = new PhoneNumberEntriesViewModel();
            var count = model.AllTypes().Count;
            model.Entries.Add(new PhoneNumberEntry{PhoneNumberType = PhoneNumberTypes.Car});
            model.Entries.Add(new PhoneNumberEntry { PhoneNumberType = PhoneNumberTypes.Home });
            Assert.AreEqual(model.AvailableTypes().Count, count - 2);
            Assert.IsFalse(model.AvailableTypes().Contains(PhoneNumberTypes.Car));
            Assert.IsFalse(model.AvailableTypes().Contains(PhoneNumberTypes.Home));
            }

        [TestMethod]
        public void AvailableTypesForAPhoneEntryWorks()
        {
            var model = new PhoneNumberEntriesViewModel();
            var car = new PhoneNumberEntry {PhoneNumberType = PhoneNumberTypes.Car};
            var cell = new PhoneNumberEntry {PhoneNumberType = PhoneNumberTypes.Cell};
            model.Entries.Add(car);
            model.Entries.Add(cell);
            var count = model.AvailableTypes().Count;
            Assert.AreEqual(model.AvailableTypes(car).Count, count + 1);
            Assert.IsTrue(model.AvailableTypes(car).Contains(car.PhoneNumberType));
        }

        [TestMethod]
        public void SelectListItemsArePopulatedCorrectly()
        {
            var model = new PhoneNumberEntriesViewModel();
            var car = new PhoneNumberEntry {PhoneNumberType = PhoneNumberTypes.Car};
            var home = new PhoneNumberEntry {PhoneNumberType = PhoneNumberTypes.Home};
            model.Entries.Add(car);
            model.Entries.Add(home);
            var count = model.AvailableTypes().Count;
            Assert.AreEqual(model.SelectListItems(car).Count(), count + 1);
            Assert.IsTrue(model.SelectListItems(car).Where(item=> item.Selected).Single().Value == car.PhoneNumberType.ToString());
        }
    }
}
