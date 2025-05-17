using VendingMachine.Persistence.Settings;

namespace VendingMachine.WebApplication.Configurations
{
    internal static class Connection
    {
        internal static string GetOptionConfiguration(string defaultConnection)
        {
            if (!string.IsNullOrEmpty(defaultConnection))
                return defaultConnection;

            string envString = Environment.GetEnvironmentVariable(DataBaseSet.Configuration);

            return envString;
        }
    }
}
