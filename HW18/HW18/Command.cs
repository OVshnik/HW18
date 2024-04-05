using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18
{
    public abstract class Command
    {
        public virtual async Task Execute()
        {
            throw new NotImplementedException();
            
        }
    }
}
