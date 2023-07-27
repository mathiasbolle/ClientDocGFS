using ClientDocGFS.Shared.Client;
using Microsoft.EntityFrameworkCore;

namespace ClientDocGFS.Data.Models;

public class GfsContext: DbContext
{
    public DbSet<Client> Clients { get; set; }
    
    public string DbPath { get; } //path of sqllite

    public GfsContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "gfs.db");
    }
    
    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}