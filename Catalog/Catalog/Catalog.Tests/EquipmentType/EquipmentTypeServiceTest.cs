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
    public class EquipmentTypeServiceTest
    {
        private readonly EquipmentTypeService _equipmentTypeService;

        public EquipmentTypeServiceTest()
        {
            var equipmentTypeRepo = new EquipmentTypeRepositoryInMemory();
            var equipmentSubTypeRepo = new EquipmentSubTypeRepositoryInMemory();

            _equipmentTypeService = new EquipmentTypeService(equipmentTypeRepo,
                equipmentSubTypeRepo);
        }
        [TestMethod]
        public void GetAllDesignators()
        {
            var items = _equipmentTypeService.GetAll();

            Assert.IsTrue(items.Any());
        }
    }
}
