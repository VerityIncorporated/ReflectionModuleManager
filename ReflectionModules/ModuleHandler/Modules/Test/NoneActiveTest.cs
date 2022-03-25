using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionModules.ModuleHandler.Modules.Test
{
    class NoneActiveTest : Module
    {
        public NoneActiveTest() : base("NoneActiveTest", "Test", false, true) {}
    }
}
