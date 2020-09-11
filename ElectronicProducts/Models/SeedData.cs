using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ElectronicProducts.Models {

    public static class SeedData {

        public static void EnsurePopulated(IApplicationBuilder app) {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any()) {
                context.Database.Migrate();
            }

            if (!context.Products.Any()) {
                context.Products.AddRange(
                    new Product {
                        Name = "PS4", Description = "Gaming Console made by Sony",
                        Category = "Gaming", Price = 200
                    },
                    new Product {
                        Name = "Xbox",
                        Description = "Gaming Console made by Microsoft",
                        Category = "Gaming", Price = 220
                    },
                    new Product {
                        Name = "Air Pod",
                        Description = "Truely wireless earpods made by Apple",
                        Category = "Music", Price = 199
                    },
                    new Product {
                        Name = "MSI Monitor",
                        Description = "A monitor that runs a 144hz",
                        Category = "Gaming", Price = 150
                    },
                    new Product {
                        Name = "Blu Microphone",
                        Description = "Great microphone for podcast",
                        Category = "Audio", Price = 120
                    },
                    new Product {
                        Name = "Logi tech webcam",
                        Description = "Look at your pretty face in High res",
                        Category = "Cameras", Price = 180
                    },
                    new Product {
                        Name = "Gaming Chair",
                        Description = "You are not gaming if you do not use a gaming chair. Even adds more FPS",
                        Category = "Furniture", Price = 29.95m
                    },
                    new Product {
                        Name = "RGB Keyboard",
                        Description = "RGB so the ladies know you are loyal",
                        Category = "Gaming", Price = 75
                    },
                    new Product {
                        Name = "RGB Gaming Mouse",
                        Description = "High speed low drag",
                        Category = "Gaming", Price = 120
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
