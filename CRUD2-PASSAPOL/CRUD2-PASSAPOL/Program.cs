namespace CRUD2_PASSAPOL
{
    internal static class Program
    {
        //DbShopRealContext db = new DbShopRealContext();
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new HomePage());
        }
    }
}