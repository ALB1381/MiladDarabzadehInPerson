using Microsoft.EntityFrameworkCore;
using MiladDarabzadeh.Data.Entities.Course;
using MiladDarabzadeh.Data.Entities.User;
using MiladDarabzadeh.Data.Entities.User.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Context
{
    public class MiladContext : DbContext
    {
        public MiladContext(DbContextOptions<MiladContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermissionConnection> RolePermissionConnections { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseGroup> CourseGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
        .SelectMany(t => t.GetForeignKeys())
        .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);
            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            modelBuilder.Entity<Role>().HasData(
                new Role() {RoleId = 1,RoleTitle= "Admin" },
                new Role() {RoleId = 2,RoleTitle= "Student" }
                );


            modelBuilder.Entity<Entities.User.User>().HasData(
             new Entities.User.User()
             {
                 UserId = 1,
                 UserAvatar = "Defult.jpg",
                 UserName = "MiladDarabzadeh",
                 UserEmail = "Milad.tutor@gmail.com",
                 UserPhoneNumber = "09139279581",
                 UserRegisterDate = DateTime.Now,
                 UserActiveCodeForEmail = "0569d3e33ac94bcc8c5ee4f93320db45",
                 UserActiveCodeForPhoneNumber = "0569d3e33ac94bcc8c5ee4f93320db45",
                 UserPassword = "62-D5-ED-C9-B0-AD-74-B5-AE-96-2E-5F-7F-C7-91-51",
                 IsActived = true,
                 RoleId = 1,
                 UserNandF = "Milad Darabzadeh"
             },
             new Entities.User.User()
             {
                 UserId = 2,
                 UserName = "AliBarzegar",
                 UserEmail = "alibarzegar013@gmail.com",
                 UserPhoneNumber = "09397894663",
                 UserRegisterDate = DateTime.Now,
                 UserAvatar = "cc4129b2b7db4c1ea499fa5a6208df5d.jpg",
                 UserActiveCodeForEmail = "c53eac7994034d13a36e475e1e00fcac",
                 UserActiveCodeForPhoneNumber = "c53eac7994034d13a36e475e1e00fcac",
                 UserPassword = "0C-0B-33-26-C9-5A-66-D7-37-7A-0A-2F-75-DA-AC-34",
                 IsActived = true,
                 RoleId = 1,
                 UserNandF = "Ali Barzegar"
             }
             );
        }
    }
}
