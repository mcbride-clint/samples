using Catalog.DataAccess.Repositories;
using Catalog.Models.Filters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catalog.Tests.Designator
{
    [TestClass]
    public class DesignatorRepositoryTest
    {
        private readonly DesignatorRepositoryInMemory _designatorRepo;

        public DesignatorRepositoryTest()
        {
            _designatorRepo = new DesignatorRepositoryInMemory();
        }

        [TestMethod]
        public void GetAllDesignators()
        {
            var items = _designatorRepo.Find(new DesignatorFilter());

            Assert.IsTrue(items.Any());
        }

        [TestMethod]
        public void InsertNewDesignator()
        {
            var newItem = new Models.DomainModels.Designator()
            {
                ActivityId = 1,
                SubActivityId = 1,
                EquipmentSubTypeId = 2,
                EquipmentTypeId = 1,
                IsAssembly = true,
                IsComponent = true,
                IsSpare = false,
                LeadTimeGroupId = 1,
                Nomenclature = "Test Object Insert",
                OwnerId = 1
            };

            newItem = _designatorRepo.Insert(newItem);

            var foundItem = _designatorRepo.Find(newItem.DesignatorId);

            Assert.AreEqual(newItem.Nomenclature,foundItem.Nomenclature);
        }

        [TestMethod]
        public void UpdateExistingDesignator()
        {
            InsertNewDesignator();

            var newestDesignatorId = _designatorRepo.Find(new DesignatorFilter()).Max(d => d.DesignatorId);
            var newestDesignator = _designatorRepo.Find(newestDesignatorId);

            var changedDesignator = Cloner.Clone(newestDesignator);

            changedDesignator.Nomenclature = "Changing the Name";

            _designatorRepo.Update(changedDesignator);

            Assert.AreNotEqual(newestDesignator.Nomenclature, changedDesignator.Nomenclature);
        }
    }
}
