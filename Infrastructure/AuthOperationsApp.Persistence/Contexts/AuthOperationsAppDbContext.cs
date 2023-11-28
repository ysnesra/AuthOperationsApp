using AuthOperationsApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace AuthOperationsApp.Persistence.Contexts
{
    public class AuthOperationsAppDbContext : DbContext
    {
        public AuthOperationsAppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<RoleGroup> RoleGroups { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = Guid.Parse("72305372-470f-4b15-8876-f61b72691841"),
                    FullName = "Esra Yaşın",
                    UserName = "esra",
                    Password = "Esra.1",
                    Email = "esra@gmail.com",
                    Phone = "05331545547"
                },
                new User
                {
                    Id = Guid.Parse("73305372-470f-4b15-8876-f61b72691843"),
                    FullName = "Mehmet Kutlu",
                    UserName = "mehmet",
                    Password = "Mehmet.1",
                    Email = "mehmet@gmail.com",
                    Phone = "05551545547"
                },
                 new User
                 {
                     Id = Guid.Parse("74605372-470f-4b15-8876-f61b72691846"),
                     FullName = "Aysel Aydınlık",
                     UserName = "aysel",
                     Password = "Aysel.1",
                     Email = "aysel@gmail.com",
                     Phone = "05351545343"
                 },
                    new User
                    {
                        Id = Guid.Parse("75005372-470f-4b15-8876-f61b72691849"),
                        FullName = "Melek Mutlu",
                        UserName = "melek",
                        Password = "Melek.1",
                        Email = "melek@gmail.com",
                        Phone = "05651547343"
                    });

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = Guid.Parse("22905372-470f-4b15-8876-f61b72691841"),
                    Name = "Taleplerim sayfasına girme yetki",                  
                },
                new Role
                {
                    Id = Guid.Parse("23905372-470f-4b15-8876-f61b72691842"),
                    Name = "Satışlarım sayfasına girme yetkisi",                 
                },
                new Role
                {
                    Id = Guid.Parse("24905372-470f-4b15-8876-f61b72691843"),
                    Name = "Dashboard yetkisi",                   
                },
                new Role
                {
                    Id = Guid.Parse("25905372-470f-4b15-8876-f61b72691844"),
                    Name = "Wallboard yetkisi",                   
                },
                 new Role
                 {
                     Id = Guid.Parse("26005372-470f-4b15-8876-f61b72691842"),
                     Name = "Wallboard yetkisi",
                 },
                new Role
                {
                    Id = Guid.Parse("27105372-470f-4b15-8876-f61b72691841"),
                    Name = "İlanlarım yetkisi",                   
                });

            modelBuilder.Entity<Group>().HasData(
               new Group
               {
                   Id = Guid.Parse("52005372-470f-4b15-8876-f61b72691841"),
                   Name = "Mağaza müdürleri grubu",
               },
               new Group
               {
                   Id = Guid.Parse("53005372-470f-4b15-8876-f61b72691842"),
                   Name = "Satış müdürleri grubu",
               },
               new Group
               {
                   Id = Guid.Parse("54905372-470f-4b15-8876-f61b72691843"),
                   Name = "IK çalışanları grubu",
               },
               new Group
               {
                   Id = Guid.Parse("55805372-470f-4b15-8876-f61b72691844"),
                   Name = "Raporlama grubu",
               },
                new Group
                {
                    Id = Guid.Parse("56005372-470f-4b15-8876-f61b72691842"),
                    Name = "IT destek grubu",
                },
               new Group
               {
                   Id = Guid.Parse("27105372-470f-4b15-8876-f61b72691841"),
                   Name = "Eğitim destek grubu",
               });

            base.OnModelCreating(modelBuilder);
        }
    }
}

