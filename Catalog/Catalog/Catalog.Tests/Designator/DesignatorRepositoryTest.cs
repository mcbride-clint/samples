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
        [TestMethod]
        public void GetAllDesignators() {
            var designatorRepo = new DesignatorRepositoryInMemory();

            var items = designatorRepo.Find(new DesignatorFilter());

            Assert.IsTrue(items.Any());
        }
    }
}
