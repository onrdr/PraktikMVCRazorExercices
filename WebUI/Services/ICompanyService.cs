using WebUI.Models;

namespace WebUI.Services;

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