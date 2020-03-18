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
    public class EquipmentSubTypeRepositoryTest
    {
        [TestMethod]
        public void GetAllEquipmentSubTypes() {
            var repo = new EquipmentSubTypeRepositoryInMemory();

            var items = repo.Find();

            Assert.IsTrue(items.Any());
        }
    }
}
