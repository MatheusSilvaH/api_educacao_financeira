using System;

namespace Domain.Base
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DateAttribute : Attribute
    {
        public DateAttribute()
        {

        }
    }
}