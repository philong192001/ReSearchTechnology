using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Ids
{
    public class NulloIdGenerator : IIdGenerator
    {
        public Guid New() => Guid.NewGuid();
    }
}
