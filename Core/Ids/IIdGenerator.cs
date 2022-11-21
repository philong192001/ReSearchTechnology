using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Ids
{
    public interface IIdGenerator
    {
        Guid New();
    }
}

