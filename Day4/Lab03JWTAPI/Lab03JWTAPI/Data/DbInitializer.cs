using Lab03JWTAPI.Domain;

namespace Lab03JWTAPI.Data
{
    public class DbInitializer
    {
        public static void Seed(KlineAppDbContext context)
        {
            if (!context.AppUsers.Any())
            {
                context.AppUsers.AddRange(
                    new AppUser { UserName = "pinghui", PasswordHash = "pinghui", Role = "admin" },
                    new AppUser { UserName = "kannan", PasswordHash = "kannan", Role = "normal" }
                );
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee { Name = "Alice Johnson", Position = "Software Engineer" },
                    new Employee { Name = "Bob Smith", Position = "Product Manager" },
                    new Employee { Name = "Carol Williams", Position = "QA Analyst" }
                );
            }

            context.SaveChanges();
        }
    }
}
