using DataAccessLayer.Models;

namespace DataAccessLayer.Contracts
{
    public interface IResultRepository
    {
        public List<Report> ViewReport();
    }
}
