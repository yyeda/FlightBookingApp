using System.Globalization;

namespace FlightBooking
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var c = CultureInfo.CreateSpecificCulture("tr-TR");
            CultureInfo.CurrentCulture = c;
            CultureInfo.CurrentUICulture = c;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}