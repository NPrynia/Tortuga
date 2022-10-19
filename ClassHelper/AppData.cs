using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tortuga.EF;

namespace Tortuga.ClassHelper
{
    class AppData
    {
        public static TortugaPrianiKaraulEntities1 Context { get; set; } = new TortugaPrianiKaraulEntities1();

    }
}
