namespace ProductRegister.API.Settings.Models;

public class AppSettings
{
    public string? ConnectionString { get; set; }
    public string? AllowedHosts { get; set; }
    public string? MigrationAssembly { get; set; }
}