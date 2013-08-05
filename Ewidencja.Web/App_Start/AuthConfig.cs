using WebMatrix.WebData;

namespace Ewidencja
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            WebSecurity.InitializeDatabaseConnection(
               "Ewidencja.AspNet.UsersContext",
               "UserProfile",
               "UserId",
               "UserName", autoCreateTables: true);
        }
    }
}
