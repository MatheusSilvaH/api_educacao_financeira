using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace educacao_financeira_api.Model.Base
{
    public class Entity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool Active { get; set; } = true;
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}