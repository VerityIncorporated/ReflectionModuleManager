using System;
using System.Reflection;
using System.Windows.Forms;

namespace ReflectionModules.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Shown += Main_Shown;
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            foreach(var category in Reflection.InitializeModules.CategoryList)
            {
                Button CategoryButton = new Button();
                CategoryButton.Text = category;
                CategoryButton.Name = category + "Button";
                CategoryButton.Dock = DockStyle.Top;
                CategoryButton.Click += Categories_Click;
                categoryPanel.Controls.Add(CategoryButton);
            }

            foreach (var module in Reflection.InitializeModules.NoneActiveModulesList)
            {
                var field = module?.GetType().BaseType?.GetField("button", BindingFlags.Instance | BindingFlags.Public);
                var buttonField = field.GetValue(module);
                var button = buttonField as Button;
                derivedClassesPanel.Controls.Add(button);
            }
        }

        private void Categories_Click(object sender, EventArgs e)
        {
            modulesPanel.Controls.Clear();
            var categoryButton = sender as Button;
            foreach (var module in Reflection.InitializeModules.ActivatedModulesList) 
            {
                var categoryName = module?.GetType().BaseType?.GetField("_categoryname", BindingFlags.Instance | BindingFlags.Public);
                if (categoryButton.Text != categoryName.GetValue(module).ToString()) continue;
                var field = module?.GetType().BaseType?.GetField("button", BindingFlags.Instance | BindingFlags.Public);
                var buttonField = field.GetValue(module);
                var button = buttonField as Button;
                modulesPanel.Controls.Add(button);
            }
        }
    }
}
