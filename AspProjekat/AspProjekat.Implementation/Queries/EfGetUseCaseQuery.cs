using AspProjekat.Application.DataTransfer;
using AspProjekat.Application.Queries;
using AspProjekat.Application.Searches;
using AspProjekat.EfDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspProjekat.Implementation.Queries
{
    public class EfGetUseCaseQuery : IGetUseCaseQuery
    {
        private readonly AspProjekatContext context;

        public EfGetUseCaseQuery(AspProjekatContext context)
        {
            this.context = context;
        }

        public int Id => 26;

        public string Name => "UseCase search.";

        public PageResponse<UseCaseLoggerDto> Execute(UseCaseSearch search)
        {
            var query = context.UseCaseLogs.AsQueryable();

            if (!string.IsNullOrEmpty(search.Name) || !string.IsNullOrWhiteSpace(search.Name))
            {
                query = query.Where(x => x.UseCaseName.ToLower().Contains(search.Name.ToLower()));
            }

            var skipCount = search.PerPage * (search.Page - 1);


            var reponse = new PageResponse<UseCaseLoggerDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new UseCaseLoggerDto
                {
                    UseCaseName = x.UseCaseName,
                    Date = x.Date,
                    Data=x.Data,
                    Actor=x.Actor

                    }).ToList()
            };

            return reponse;
        }
    }

}
