using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_With_Examples.Dependency_Inversion
{
    internal class BadExample
    {
        // high level class shouldnt be depended on low-level classes
        public void foo(SQL db)
        {
            db.Insert();
            db.Update();
            db.Delete();
        }
    }
}
