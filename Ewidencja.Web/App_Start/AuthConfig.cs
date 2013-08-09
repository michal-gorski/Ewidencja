using WebMatrix.WebData;

namespace Ewidencja
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            if (!WebSecurity.Initialized)
            {
                WebSecurity.InitializeDatabaseConnection(
                    "Ewidencja.AspNet.UsersContext",
                    "UserProfile",
                    "UserId",
                    "UserName", autoCreateTables: true);
            }
        }
    }
}
