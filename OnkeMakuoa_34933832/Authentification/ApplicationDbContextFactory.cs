using JWTAuthentication.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace OnkeMakuoa_34933832.Authentification
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // Replace with your actual connection string
            optionsBuilder.UseSqlServer("Server=tcp:onke.database.windows.net,1433;Initial Catalog=NWUTechTrends;Persist Security Info=False;User ID=Playmer;Password=Onke@5343082;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}