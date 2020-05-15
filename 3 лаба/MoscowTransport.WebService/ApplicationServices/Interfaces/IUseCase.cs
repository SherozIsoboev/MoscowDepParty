using Partys.ApplicationServices.Ports;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Partys.ApplicationServices.Interfaces
{
    public interface IUseCase<in TUseCaseRequest, out TUseCaseResponse>
        where TUseCaseRequest : IUseCaseRequest<TUseCaseResponse>
    {
        Task<bool> Handle(TUseCaseRequest request, IOutputPort<TUseCaseResponse> outputPort);
    }
}
