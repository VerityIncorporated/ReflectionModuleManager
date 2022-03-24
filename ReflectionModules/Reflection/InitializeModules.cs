using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace ReflectionModules.Reflection
{
    public static class InitializeModules
    {
        public static readonly List<string> CategoryList = new List<string>();
        public static readonly List<Object> ModulesList = new List<Object>();

        public static void Init()
        {
            Program.Log("", Color.White, true);
            Program.Log("Loading Modules ->", Color.DodgerBlue);
            var modules = Assembly.GetExecutingAssembly().GetTypes().Where(type => typeof(ModuleHandler.Module).IsAssignableFrom(type) && !type.IsAbstract);
            foreach (var module in modules)
            {
                var instance = Activator.CreateInstance(module, null);
                var moduleEnabled = instance?.GetType().BaseType?.GetField("_moduleEnabled", BindingFlags.Instance | BindingFlags.Public);
                if (moduleEnabled.GetValue(instance).Equals(true))
                {
                    ModulesList.Add(instance);
                    Program.Log("Module " + instance.GetType().Name + " Loaded", Color.DodgerBlue);

                    var categoryType = instance?.GetType().BaseType?.GetField("_categoryname", BindingFlags.Instance | BindingFlags.Public);
                    if (!CategoryList.Contains(categoryType.GetValue(instance)))
                    {
                        CategoryList.Add(categoryType.GetValue(instance).ToString());
                    }
                }
                else
                {
                    Program.Log("Module " + instance.GetType().Name + " Not Loaded", Color.Red);
                }
            }

            Program.Log("", Color.White, true);
            Program.Log("Loading Categories ->", Color.Yellow);
            foreach (var category in CategoryList)
            {
                Program.Log("Category " + category + " Created", Color.Yellow);
            }
        }
    }
}
