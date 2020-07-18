using System;
using System.Collections.Generic;
using System.Text;

namespace dd.Application
{
    public interface IUseCaseLogger
    {
        void Log(IUseCase userCase, IApplicationActor actor, object useCaseData);
    }
}
