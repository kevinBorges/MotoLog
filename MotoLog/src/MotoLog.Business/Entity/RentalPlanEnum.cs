using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoLog.Business.Entity
{
    public enum RentalPlanEnum
    {
        [Description("7 days")]
        SevenDays = 7,

        [Description("15 days")]
        FifteenDays = 15,

        [Description("30 days")]
        ThirtyDays = 30
    }
}
