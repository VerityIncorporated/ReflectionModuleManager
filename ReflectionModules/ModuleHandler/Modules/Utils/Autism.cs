using System;

namespace ReflectionModules.ModuleHandler.Modules.Utils
{
    class Autism : Module
    {
        public Autism() : base("Clear Console Logs", "Utils", true, true) { }

        protected override void Enabled() 
        {
            Console.Clear();
        }
    }
}
