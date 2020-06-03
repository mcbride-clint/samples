using MdcLog.Application.Priorties.Models;
using MdcLog.Application.Priorties;
using MdcLog.Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MdcLog.Application.Priorties
{
    public interface IPriorityRepository
    {
        PriorityCode InsertPriorityCode(PriorityCode entity);
        PriorityCode SavePriorityCode(PriorityCode entity);
        PriorityCode EditPriorityCode(PriorityCode entity);
        PriorityCode FindPriorityCode(int Priority);
        IEnumerable<PriorityCode> FindPriorityCodeList();
        PriorityCode DeletePriorityCode(PriorityCode entity);

    }
}
