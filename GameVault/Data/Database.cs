using Microsoft.Extensions.Configuration;

namespace GameVault.Data;

public static class Database
{
    public static string ConnectionString { get; } = Load();

    private static string Load()
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false)
            .Build();

        return config.GetConnectionString("GameVault")
            ?? throw new InvalidOperationException("Connection string 'GameVault' not found.");
    }
}