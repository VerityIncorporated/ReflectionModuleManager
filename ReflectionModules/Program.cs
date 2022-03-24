using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ReflectionModules
{
    internal static class Program
    {
        private static void Main()
        {
            new Thread(() => {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();
                Application.Run(new GUI.Main());
            }).Start();

            Console.Title = @"Reflection Modules";
            Log("GUI Loaded", Color.White);

            Reflection.InitializeModules.Init();
        }

        public static void Log(string message, Color color, bool newLine = false)
        {
            if(!newLine)
            {
                Colorful.Console.WriteLine($" Reflection Modules @ {DateTime.Now}: {message}", color);
                Console.CursorVisible = false;
            }
            else
            {
                Console.WriteLine("");
                Console.CursorVisible = false;
            }
        }
    }
}
