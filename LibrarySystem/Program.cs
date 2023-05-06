/*
 *  Group: The Libarbarians
 *  Project: Librarian Assistant
 * 
 * Authors:
 *  Sarah Hoppe
 *  Boaz Glassberg
 *  Grace Covarrubias
 *  Tywin Cary
 *  David Hofsetz
 *  
 */

namespace LibrarySystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());
        }
    }
}