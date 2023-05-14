using Microsoft.AspNetCore.Mvc; 
using WebUI.Models;
using WebUI.Services;

namespace WebUI.Controllers;

public class CompanyController : Controller
{
    private readonly ICompanyService _companyService;

    public CompanyController(ICompanyService companyService) => _companyService = companyService;

    public IActionResult Index()
    { 
        var companies = _companyService.GetAllCompanies();

        return View(companies);
    }

    [HttpPost]
    public IActionResult ListPartial(List<Company> companies)
    {
        return PartialView("_CompanyTable", companies);  
    }

    #region Register
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Company company)
    {
        if (ModelState.IsValid)
        {
            _companyService.AddCompany(company);
        }

        return RedirectToAction("Index");
    }
    #endregion

    #region Edit
    public IActionResult Edit(Guid? companyId, string str, int num)
    {
        var company = _companyService.GetCompanyById(companyId);

        return View(company);
    }

    [HttpPost]
    public IActionResult Edit(Company company)
    {
        if (ModelState.IsValid)
        {
            _companyService.EditCompany(company);
        }

        return RedirectToAction("Index");
    }
    #endregion
}
