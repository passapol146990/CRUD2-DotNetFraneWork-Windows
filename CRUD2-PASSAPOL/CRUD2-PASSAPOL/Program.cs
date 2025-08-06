namespace CRUD2_PASSAPOL
{
    internal static class Program
    {
        DbShopRealContext db = new DbShopRealContext();
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new HomePage());
        }
    }
}