using ClientDocGFS.Domain;
using ClientDocGFS.Shared.Client;
using Microsoft.EntityFrameworkCore;

namespace ClientDocGFS.Data;

public class GfsContext : DbContext
{
    public DbSet<ClientDto> Clients { get; set; }

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


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ClientDto>().HasKey(p => p.ClientId); //set primary key
        modelBuilder.Entity<ClientDto>().Property(x => x.ClientId).HasColumnName("client_id");
        modelBuilder.Entity<ClientDto>().Property(x => x.FirstName).HasColumnName("firstname").IsRequired(false);
        modelBuilder.Entity<ClientDto>().Property(x => x.LastName).HasColumnName("lastname").IsRequired(false);
        modelBuilder.Entity<ClientDto>().Property(x => x.LastnameParter).HasColumnName("lastname_partner")
            .IsRequired(false);
        modelBuilder.Entity<ClientDto>().Property(x => x.FirstNameParter).HasColumnName("firstname_partner")
            .IsRequired(false);

        modelBuilder.Entity<ClientDto>().Property(x => x.PhoneNumber).HasColumnName("phone_number").IsRequired(false);
        modelBuilder.Entity<ClientDto>().Property(x => x.MailAdress).HasColumnName("mail_address").IsRequired(false);
        modelBuilder.Entity<ClientDto>().Property(x => x.enterpriseNumber).HasColumnName("enterprise_number")
            .IsRequired(false);
        modelBuilder.Entity<ClientDto>().Property(x => x.nationalNumber).HasColumnName("national_number")
            .IsRequired(false);
        modelBuilder.Entity<ClientDto>().Property(x => x.kids).HasColumnName("amount_of_kids");
        modelBuilder.Entity<ClientDto>().Property(x => x.bankNumber).HasColumnName("bank_number").IsRequired(false);
        modelBuilder.Entity<ClientDto>().Property(x => x.bankNumberOtherCountry)
            .HasColumnName("bank_number_other_country").IsRequired(false);

        //move this in the future to another table? (address)
        modelBuilder.Entity<ClientDto>().Property(x => x.AdressStreetName).HasColumnName("address_street")
            .IsRequired(false);
        modelBuilder.Entity<ClientDto>().Property(x => x.CityNumber).HasColumnName("city_number");
        modelBuilder.Entity<ClientDto>().Property(x => x.CityName).HasColumnName("city_name").IsRequired(false);
        modelBuilder.Entity<ClientDto>().ToTable("client");
    }
}