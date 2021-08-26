using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.avaCloud.Entidades
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public DateTime ProductId { get; set; }
        public abstract bool Validate();
    }
}
