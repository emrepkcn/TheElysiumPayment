using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elysium.Core.UnitOfWorks
{
    internal interface UnitOfWork
    {
        Task CommitAsync();
        void Commit();  
    }
}
