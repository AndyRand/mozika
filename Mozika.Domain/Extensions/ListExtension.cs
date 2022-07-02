using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mozika.Domain.Extensions
{
    public static class ListExtension
    {
        public static IList<T> ToListPaginate<T>(this IList<T> list, int currentPage, int RecordsPerPage = 20)
        {
            var listResult = new List<T>();
            int lengthPagination = currentPage * RecordsPerPage + RecordsPerPage;
            lengthPagination = lengthPagination > list.Count ? list.Count : lengthPagination;
            for (int i = currentPage * RecordsPerPage; i < lengthPagination; i++)
            {
                listResult.Add(list[i]);
            }

            return listResult;
        }
    }
}
