using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoLog.Business.Entity
{
    public class Location : Base
    {

        public Guid MotoId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ExpectedEndDate { get; set; }

        public RentalPlanEnum RentalPlan { get; set; }
        public Moto Moto { get; set; }
    }
}
