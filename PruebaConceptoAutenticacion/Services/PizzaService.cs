using Infraestructures.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PizzaService
    {
        private UnitOfWork _unitOfWork { get; set; }

        public PizzaService()
        {
            _unitOfWork = new UnitOfWork();
        }


    }
}
