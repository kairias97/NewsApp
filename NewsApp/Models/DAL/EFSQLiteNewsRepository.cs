using NewsApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsApp.Models.DAL
{
    class EFSQLiteNewsRepository : INewsRepository
    {
        private readonly NewsDbContext _context;
        private readonly IRandom _random;

        public EFSQLiteNewsRepository(NewsDbContext context,
            IRandom randomGenerator)
        {
            this._context = context;
            this._random = randomGenerator;
        }

        public IEnumerable<News> GetFeatured()
        {
            //int newsCount = _context.News.Count();
            int featuredCount = 3;
            //int skippableCount = newsCount - featuredCount;
            //int rowsToSkip = _random.GetNextIntInclusive(0, skippableCount);
            return _context.News.OrderBy(n => Guid.NewGuid()).Take(featuredCount);
            //return _context.News.Skip(rowsToSkip).Take(featuredCount);
        }

        public IEnumerable<News> GetRecents(int limit)
        {
            return _context.News
                .OrderByDescending(n => n.PublishedDate)
                .Take(limit);
        }

        public IEnumerable<News> Search(string title, DateTime startDate, DateTime endDate)
        {
            Func<News, bool> filter = news =>
                (news.PublishedDate >= startDate 
                && news.PublishedDate <= endDate 
                && (String.IsNullOrEmpty(title) || news.Title.Contains(title, StringComparison.InvariantCultureIgnoreCase)));
            return _context.News
                .Where(filter);
        }
    }
}
