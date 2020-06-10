using System;
using System.Collections.Generic;
using MdcLog.Domain.Entities;
using System.Text;

namespace MdcLog.Application.HandlerCodes
{
    public interface IHandlerCodeRepository
    {
        HandlerCode InsertHandlerCode(HandlerCode entity);
        HandlerCode SaveType(HandlerCode entity);
        HandlerCode EditHandlerCode(HandlerCode entity);
        HandlerCode FindHandlerCode(string Code);
        ICollection<HandlerCode> FindHandlerCodeList();
        HandlerCode DeleteHandlerCode(HandlerCode entity);
    }
}
