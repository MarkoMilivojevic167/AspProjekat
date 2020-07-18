using dd.Application;
using EfDataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace dd.Implementation.Logging
{
    public class DatabaseUseCaseLogger : IUseCaseLogger
    {
        private readonly ChinookContext _context;

        public DatabaseUseCaseLogger(ChinookContext context) => _context = context;

        public void Log(IUseCase useCase, IApplicationActor actor, object useCaseData)
        {
            //_context.UseCaseLogs.Add(new Domain.UseCaseLog
            //{
            //    Actor = actor.Identity,
            //    Data = JsonConvert.SerializeObject(useCaseData),
            //    Date = DateTime.UtcNow,
            //    UseCaseName = useCase.Name
            //});

            //_context.SaveChanges();
        }
    }
}
