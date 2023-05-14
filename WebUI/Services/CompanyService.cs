using WebUI.Data;
using WebUI.Models;

namespace WebUI.Services;

public class CompanyService : ICompanyService
{
    static readonly List<Company> Companies = DataSeeder.GetCompanies();

    public Company? GetCompanyById(Guid? id) => Companies.SingleOrDefault(c => c.Id == id);

    public List<Company> GetAllCompanies() => Companies;

    public List<Company> GetActiveCompanies() => Companies.Where(c => c.IsActive).ToList();

    public List<Company> GetInActiveCompanies() => Companies.Where(c => !c.IsActive).ToList();

    public List<Company> GetDeletedCompanies() => Companies.Where(c => c.IsDeleted).ToList();

    public List<Company> GetNotDeletedCompanies() => Companies.Where(c => !c.IsDeleted).ToList();

    public void EditCompany(Company newCompany)
    {
        var oldCompany = Companies.SingleOrDefault(a => a.Id == newCompany.Id);
        if (oldCompany is not null)
        {
            oldCompany.Name = newCompany.Name;
            oldCompany.BusinessRegistrationNumber = newCompany.BusinessRegistrationNumber;
            oldCompany.IsActive = newCompany.IsActive;
            oldCompany.IsDeleted = newCompany.IsDeleted; 
            oldCompany.CreatedAt = newCompany.CreatedAt;
            oldCompany.CreatedBy = newCompany.CreatedBy;
        }
    }

    public void AddCompany(Company model)
    {
        var company = new Company
        {
            Id = Guid.NewGuid(),
            Name = model.Name,
            BusinessRegistrationNumber = model.BusinessRegistrationNumber,
            IsActive = model.IsActive,
            IsDeleted = model.IsDeleted,
            CreatedAt = DateTimeOffset.UtcNow,
            CreatedBy = model.CreatedBy
        };

        Companies.Add(company);
    }
}

public interface ICompanyService
{
    Company? GetCompanyById(Guid? id);
    List<Company> GetAllCompanies();
    List<Company> GetActiveCompanies();
    List<Company> GetInActiveCompanies();
    List<Company> GetDeletedCompanies();
    List<Company> GetNotDeletedCompanies();
    void EditCompany(Company company);
    void AddCompany(Company company);
}