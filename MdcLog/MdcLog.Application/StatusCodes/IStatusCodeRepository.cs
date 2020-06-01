using System;
using System.Collections.Generic;
using MdcLog.Domain.Entities;
using System.Text;



namespace MdcLog.Application.StatusCodes
{
    public interface IStatusCodeRepository
    {
        StatusCode InsertStatusCode(StatusCode entity);
        StatusCode SaveType(StatusCode entity);
        StatusCode EditStatusCode(StatusCode entity);
        StatusCode FindStatusCode(string StatusCode);
        ICollection<StatusCode> FindStatusCodeList();
        StatusCode DeleteStatusCode(StatusCode entity);
    }
}
