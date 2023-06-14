using WebUI.Models;

namespace WebUI.Data;

public class DataSeeder
{
    public static List<Company> GetCompanies()
    {
        return new List<Company>
        {
            new Company
            {
                Id = Guid.NewGuid(), Name = "Praktik", BusinessRegistrationNumber = 111,
                IsActive = true, IsDeleted = true, CreatedAt = DateTime.Now, CreatedBy = "Team"
            },
            new Company
            {
                Id = Guid.NewGuid(), Name = "Elvin Company", BusinessRegistrationNumber = 222,
                IsActive = true, IsDeleted = true, CreatedAt = DateTime.Now, CreatedBy = "Elvin"
            },
            new Company
            {
                Id = Guid.NewGuid(), Name = "Yusuf Company", BusinessRegistrationNumber = 333,
                IsActive = true, IsDeleted = false, CreatedAt = DateTime.Now, CreatedBy = "Yusuf"
            },
            new Company
            {
                Id = Guid.NewGuid(), Name = "Murat Company", BusinessRegistrationNumber = 444,
                IsActive = true, IsDeleted = false, CreatedAt = DateTime.Now, CreatedBy = "Murat"
            },
            new Company
            {
                Id = Guid.NewGuid(), Name = "Dogukan Company", BusinessRegistrationNumber = 555,
                IsActive = false, IsDeleted = true, CreatedAt = DateTime.Now, CreatedBy = "Dogukan"
            },
            new Company
            {
                Id = Guid.NewGuid(), Name = "Ali Company", BusinessRegistrationNumber = 666,
                IsActive = false, IsDeleted = true, CreatedAt = DateTime.Now, CreatedBy = "Ali"
            },
            new Company
            {
                Id = Guid.NewGuid(), Name = "Cihan Company", BusinessRegistrationNumber = 777,
                IsActive = false, IsDeleted = false, CreatedAt = DateTime.Now, CreatedBy = "Cihan"
            },
            new Company
            {
                Id = Guid.NewGuid(), Name = "Furkan Company", BusinessRegistrationNumber = 888,
                IsActive = false, IsDeleted = false, CreatedAt = DateTime.Now, CreatedBy = "Furkan"
            },
            new Company
            {
                Id = Guid.NewGuid(), Name = "Onur Company", BusinessRegistrationNumber = 999,
                IsActive = true, IsDeleted = true, CreatedAt = DateTime.Now, CreatedBy = "Onur"
            },
        };
    }
}
