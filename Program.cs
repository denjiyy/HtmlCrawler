using HTML.Models.Windows;
using HtmlCrawl;

namespace HTML
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            HtmlTreeNode root = new HtmlTreeNode("root", null!);

            Application.Run(new BuildHtmlTreeWindow(root));
        }
    }
}