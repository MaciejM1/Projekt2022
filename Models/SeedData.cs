using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Projekt2022.Data;
using System;
using System.Linq;

namespace Projekt2022.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new Projekt2022Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<Projekt2022Context>>()))
        {
            // Look for any movies.
            if (context.User.Any())
            {
                return;   // DB has been seeded
            }
            context.User.AddRange(
                new User
                {
                    Name = "Tomasz",
                    Surname = "Górski",
                    dateOfBirth = DateTime.Parse("1999-3-18"),
                    login = "tomgor@wp.pl",
                    isDeleted = false
                },
                new User
                {
                    Name = "Karol",
                    Surname = "Feral",
                    dateOfBirth = DateTime.Parse("2003-6-8"),
                    login = "karfer@gmail.com",
                    isDeleted = false
                },
                new User
                {
                    Name = "Alicja",
                    Surname = "Bogon",
                    dateOfBirth = DateTime.Parse("1989-12-12"),
                    login = "alibog@wp.pl",
                    isDeleted = false
                },
                new User
                {
                    Name = "Patryk",
                    Surname = "Podolski",
                    dateOfBirth = DateTime.Parse("1978-8-16"),
                    login = "patpod@wp.pl",
                    isDeleted = false
                }
            );
            context.SaveChanges();
        }
    }
}