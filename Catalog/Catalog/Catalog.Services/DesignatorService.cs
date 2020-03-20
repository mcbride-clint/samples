using Catalog.Models.DomainModels;
using Catalog.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Services
{
    public class DesignatorService
    {
        private readonly IDesignatorRepository _designatorRepo;

        public DesignatorService(IDesignatorRepository designatorRepo)
        {
            _designatorRepo = designatorRepo;
        }

        public IEnumerable<Designator> GetAll()
        {
            return _designatorRepo.Find(new Models.Filters.DesignatorFilter());
        }

        public Designator Get(int designatorId)
        {
            return _designatorRepo.Find(designatorId);
        }
    }
}
