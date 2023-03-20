using Cooperchip.ITDeveloper.Domain.Models;
using Cooperchip.ITDeveloper.Mvc.Extensions.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Reflection;

namespace Cooperchip.ITDeveloper.Mvc.Extensions.ExtensionsMethods
{
    public static class ModelBuilderExtension
    {
        const string nomecompleto = "Alt Systems";
        const string apelido = "alts";
        //DateTime datanascimento = DateTime.Now;
        const string email = "altsystems@outlook.com.br";
        const string password = "Admin@123";
        const string roleName = "Admin";
        const string username = email;

        const string rolerId = "EDB90C0F-1CC4-4148-87C9-284256D89460";
        const string userId = "4AB3FFE5-8319-4C22-B097-3ABD7040697A";

        // Adiciona o  usuário Role default no projeto
        public static ModelBuilder AddUserAndRole(this ModelBuilder builder)
        {

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = rolerId,
                    Name = roleName,
                    NormalizedName = roleName.ToUpper()
                }
            );


            var phash = new PasswordHasher<ApplicationUser>();

            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = userId,
                    Apelido = apelido,
                    NomeCompleto = nomecompleto,
                    DataNascimento = DateTime.Now,
                    Email = email,
                    NormalizedEmail = email.ToUpper(),
                    UserName = username,
                    NormalizedUserName = username.ToUpper(),
                    PasswordHash = phash.HashPassword(null, password),
                    EmailConfirmed = true
                });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = rolerId,
                    UserId = userId

                });

            return builder;
        }

        // Lê o GenericosCsv, importa e grava.
        public static ModelBuilder AddGenericos(this ModelBuilder builder)
        {

            var k = 0;
            string line;

            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var csvPath = Path.Combine(outPutDirectory, "Csv\\Generico.CSV");
            string filePath = new Uri(csvPath).LocalPath;

            using (var fs = File.OpenRead(filePath))
            using (var reader = new StreamReader(fs))

                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(';');
                    var codigo = parts[0];
                    var generico = parts[1];
                    if (k > 0)
                    {
                        builder.Entity<Generico>().HasData(
                            new Generico
                            {
                                //Id = Guid.NewGuid(),
                                Codigo = Convert.ToInt32(codigo),
                                Nome = generico                                
                            });
                    }
                    k++;
                }

            return builder;
        }


    }

}
