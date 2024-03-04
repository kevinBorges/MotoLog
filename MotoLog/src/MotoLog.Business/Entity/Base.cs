using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoLog.Business.Entity
{
    public abstract class Base
    {
        protected Base() 
        { 
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
