using Catalog.DataAccess.Repositories;
using Catalog.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catalog.Tests.Designator
{
    [TestClass]
    public class DesignatorServiceTest
    {
        private readonly DesignatorService _designatorService;

        public DesignatorServiceTest()
        {
            var designatorRepo = new DesignatorRepositoryInMemory();
            _designatorService = new DesignatorService(designatorRepo);
        }
        [TestMethod]
        public void GetAllDesignators()
        {
            var items = _designatorService.GetAll();

            Assert.IsTrue(items.Any());
        }
    }
}
