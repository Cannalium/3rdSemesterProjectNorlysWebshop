namespace WebshopRestService.Logging
{
    public static class Logger
    {
        public static void LogError(Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
