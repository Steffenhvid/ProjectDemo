using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bp.Shared.Guards
{
    public static class Guards
    {
        public static void ThrowIfInputIsNull(object objectUT)
        {
            if(objectUT== null) 
                throw new ArgumentNullException(nameof(objectUT));
        }
    }
}
