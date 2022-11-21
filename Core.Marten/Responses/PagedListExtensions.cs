using Core.Responses;
using Marten.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Marten.Responses
{
    public static class PagedListExtensions
    {
        public static PagedListResponse<T> ToResponse<T>(this IPagedList<T> pagedList) =>
            new(pagedList, pagedList.TotalItemCount, pagedList.HasNextPage);
    }
}
