using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_With_Examples.Dependency_Inversion
{
    internal class GoodExample
    {

        // It should be depended on high-level classes
        public void foo(IDatabase db)
        {
            db.Insert();
            db.Update();
            db.Delete();
        }
    }
}
