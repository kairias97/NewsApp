using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsApp.Models.DAL
{
    public interface INewsRepository
    {
        IEnumerable<News> GetFeatured();
        IEnumerable<News> GetRecents(int limit);
        IEnumerable<News> Search(string title, DateTime startDate, DateTime endDate);
    }
}
