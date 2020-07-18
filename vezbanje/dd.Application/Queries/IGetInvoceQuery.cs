using dd.Application.DataTransfer;
using dd.Application.Searches;
using System;
using System.Collections.Generic;
using System.Text;

namespace dd.Application.Queries
{
    public interface IGetInvoceQuery : IQuery<InvoceSearch, PagedResponse<InvoceDto>>
    {
    }
}
