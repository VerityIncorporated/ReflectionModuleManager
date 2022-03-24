using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReflectionModules.ModuleHandler
{
    public abstract class Module
    {
        public readonly string _modulename;
        public readonly string _categoryname;
        public readonly bool _moduleEnabled;
        public readonly Button button;
        public bool _enabled;
        public readonly bool _toggle;

        protected Module(string modulename, string categoryname, bool enabled, bool toggle)
        {
            _modulename = modulename;
            _categoryname = categoryname;
            _moduleEnabled = enabled;
            _toggle = toggle;

            button = new Button();
            button.Text = modulename;
            button.Name = modulename + "Button";
            button.Dock = DockStyle.Top;
            button.Click += Module_Click;
        }

        protected virtual void Enabled() { }

        protected virtual void Disabled() { }

        public void Toggle()
        {
            _enabled = !_enabled;

            if (_enabled)
            {
                if(!_toggle)
                {
                    Enabled();
                    Program.Log($"{_modulename} Enabled", Color.White);
                }
                else
                {
                    Enabled();
                    Disabled();
                    Program.Log($"{_modulename} Toggled", Color.White);
                    _enabled = false;
                }
            }
            else
            {
                Disabled();
                Program.Log($"{_modulename} Disabled", Color.White);
            }
        }

        private void Module_Click(object sender, EventArgs e)
        {
            Toggle();
        }
    }
}