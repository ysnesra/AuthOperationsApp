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
                    Id = Guid.Parse("9e70e434-e56f-4679-8d80-f471c914ddb4"),
                    Name = "Taleplerim sayfasına girme yetkisi",                  
                },
                new Role
                {
                    Id = Guid.Parse("679dddf8-37e9-4012-9f8b-e0c5ebb747b8"),
                    Name = "Satışlarım sayfasına girme yetkisi",                 
                },
                new Role
                {
                    Id = Guid.Parse("c2d99a10-0427-4afc-8300-246b985128ec"),
                    Name = "Dashboard yetkisi",                   
                },
                new Role
                {
                    Id = Guid.Parse("8da091a4-959f-4a89-aca9-fd50d6c4a836"),
                    Name = "Taleplerim yetkisi",                   
                },
                 new Role
                 {
                     Id = Guid.Parse("23e2e4b5-415f-4087-afea-4c36bfa02dec"),
                     Name = "Wallboard yetkisi",
                 },
                new Role
                {
                    Id = Guid.Parse("5c9c718f-61fa-4d5b-8924-7d5a8e559df5"),
                    Name = "İlanlarım yetkisi",                   
                });

            modelBuilder.Entity<Group>().HasData(
               new Group
               {
                   Id = Guid.Parse("2538688c-3339-428c-8197-dab8e3d8842b"),
                   Name = "Mağaza müdürleri grubu",
               },
               new Group
               {
                   Id = Guid.Parse("a00eb1f5-a62f-4be6-ad58-9d910f6f2948"),
                   Name = "Satış müdürleri grubu",
               },
               new Group
               {
                   Id = Guid.Parse("73335711-f124-418c-95bf-107bdfca4d90"),
                   Name = "IK çalışanları grubu",
               },
               new Group
               {
                   Id = Guid.Parse("03be5560-b263-43d2-ab28-0206b58098f1"),
                   Name = "Raporlama grubu",
               },
                new Group
                {
                    Id = Guid.Parse("449f4f14-ffb6-4ff7-ab32-93d0fb430602"),
                    Name = "IT destek grubu",
                },
               new Group
               {
                   Id = Guid.Parse("02c551e4-d201-41ce-ba11-98c218d91bcf"),
                   Name = "Eğitim destek grubu",
               });

            base.OnModelCreating(modelBuilder);
        }
    }
}

