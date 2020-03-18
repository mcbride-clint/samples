using Catalog.DataAccess.Repositories;
using Catalog.Models.DomainModels;
using Catalog.Models.Filters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catalog.Tests.Designator
{
    [TestClass]
    public class EquipmentTypeRepositoryTest
    {
        private EquipmentType testingEquipmentType { get; set; }
        private EquipmentTypeRepositoryInMemory repo { get; set; }

        public EquipmentTypeRepositoryTest()
        {
            repo = new EquipmentTypeRepositoryInMemory();

            testingEquipmentType = new EquipmentType()
            {
                Name = "Quick Test",
                Description = "Will be used for testing mainpulation of Repo"
            };
        }


        [TestMethod]
        public void GetAllEquipmentTypes()
        {
            var items = repo.Find();

            Assert.IsTrue(items.Any());
        }

        [TestMethod]
        public void InsertEquipmentTypeToRepo()
        {
            var insertedType = repo.Insert(testingEquipmentType);

            var foundType = repo.Find(insertedType.EquipmentTypeId);

            Assert.AreEqual(insertedType, foundType);
        }

        [TestMethod]
        public void UpdateEquipmentTypeToRepo()
        {
            var insertedType = repo.Insert(testingEquipmentType);
            insertedType = repo.Find(insertedType.EquipmentTypeId);

            var updatingType = new EquipmentType()
            {
                EquipmentTypeId = insertedType.EquipmentTypeId,
                Name = "Updated Name",
                Description = "Updated Description"
            };

            repo.Update(updatingType);

            var foundType = repo.Find(insertedType.EquipmentTypeId);

            Assert.AreEqual(updatingType, foundType);
            Assert.AreEqual(updatingType.EquipmentTypeId, foundType.EquipmentTypeId);
            Assert.AreEqual(updatingType.Name, foundType.Name);
            Assert.AreEqual(updatingType.Description, foundType.Description);

            Assert.AreEqual(foundType.EquipmentTypeId, insertedType.EquipmentTypeId);
            Assert.AreNotEqual(foundType.Name, insertedType.Name);
            Assert.AreNotEqual(foundType.Description, insertedType.Description);
        }

        [TestMethod]
        public void DeleteEquipmentTypeFromRepo()
        {
            var insertedType = repo.Insert(testingEquipmentType);
            insertedType = repo.Find(insertedType.EquipmentTypeId);

            repo.Delete(insertedType);

            Assert.ThrowsException<InvalidOperationException>(() => repo.Find(insertedType.EquipmentTypeId));
        }
    }
}
