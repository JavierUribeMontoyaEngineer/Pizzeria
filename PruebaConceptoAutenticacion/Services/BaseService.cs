using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BaseService : IDisposable
    {
        readonly IDisposable _dispose;
        public BaseService(IDisposable dispose)
        {
            _dispose = dispose;
        }

        public void Dispose()
        {
            _dispose.Dispose();
        }
    }
}
