public static class Utilities
{
    private static readonly Uri Uri = new Uri("postgres://mlejnzkw:H7IiG9FtqcSgAYe0WyhZkZMtHfIYtKMp@abul.db.elephantsql.com/mlejnzkw");

    public static readonly string
        ProperlyFormattedConnectionString = string.Format(
            "Server={0};Database={1};User Id={2};Password={3};Port={4};Pooling=true;MaxPoolSize=1;",
            Uri.Host,
            Uri.AbsolutePath.Trim('/'),
            Uri.UserInfo.Split(':')[0],
            Uri.UserInfo.Split(':')[1],
            Uri.Port > 0 ? Uri.Port : 5432);
}