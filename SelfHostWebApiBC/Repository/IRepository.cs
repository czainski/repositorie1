using SelfHostWebApiBC.CompanyCriterions;
using SelfHostWebApiBC.Context;
using System.Threading.Tasks;

namespace SelfHostWebApiBC.Models
{
    public interface IRepository
    {
        Db Context();
     
        Task<object> GetCompany(long id);
        Task<object> GetCompanys();
        Task<string> CreateCompany(Company company);
        Task UpdateCompany(long id, Company company);
        Task DeleteCompany(int id);
        Task<object> CompanysSearcher(Criterion criterion);
    }
}
