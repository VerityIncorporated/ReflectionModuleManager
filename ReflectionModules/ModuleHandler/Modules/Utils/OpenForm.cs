using System.Windows.Forms;

namespace ReflectionModules.ModuleHandler.Modules.Utils
{
    class OpenForm : Module
    {
        public OpenForm() : base("OpenForm", "Utils", true, true) { }

        protected override void Enabled() 
        {
            var form = new Form();
            form.Show();
        }
    }
}
