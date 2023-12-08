using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace educacao_financeira_api.Model.Base
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DateAttribute : Attribute
    {
        public DateAttribute()
        {

        }
    }
}