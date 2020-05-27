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
        PriorityCodeVM InsertPriority(PriorityCodeVM ThisPriorityCode);
        PriorityCode SavePriority(PriorityCode entity);
        PriorityCodeVM EditPriority(PriorityCodeVM entity);
        PriorityCodeVM FindPriority(int Priority);
        IEnumerable<PriorityCode> FindPriorityList();
        //PriorityCode DeletePriority(string PriorityCode);
        int DeletePriority(int Priority);
    }
}
