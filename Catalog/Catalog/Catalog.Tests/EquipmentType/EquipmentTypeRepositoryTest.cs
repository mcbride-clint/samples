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
    public class EquipmentTypeRepositoryTest
    {
        [TestMethod]
        public void GetAllEquipmentTypes() {
            var repo = new EquipmentTypeRepositoryInMemory();

            var items = repo.Find();

            Assert.IsTrue(items.Any());
        }
    }
}
