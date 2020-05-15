using System;
using System.Collections.Generic;
using System.Text;

namespace Partys.ApplicationServices.Ports
{
    public interface IOutputPort<in TUseCaseResponse>
    {
        void Handle(TUseCaseResponse response);
    }
}
