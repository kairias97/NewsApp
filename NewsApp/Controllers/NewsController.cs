using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsApp.Models;
using NewsApp.Models.DAL;

namespace NewsApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsRepository _newsRepository;

        public NewsController(INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }

        // GET: api/News
        [Route("featured")]
        [HttpGet]
        public IEnumerable<News> GetFeatured()
        {
            var featuredNews = _newsRepository.GetFeatured().ToList();

            return featuredNews.ToList();
        }

        [Route("recent")]
        [HttpGet]
        public IEnumerable<News> GetRecents([FromQuery] int last = 5)
        {
            var recentNews = _newsRepository.GetRecents(last);
            return recentNews.ToList();
        }

        [Route("search")]
        [HttpGet]
        public IEnumerable<News> Search([FromQuery] string title,  
            [FromQuery] DateTime startDate,
            [FromQuery] DateTime endDate)
        {
            var foundNews = _newsRepository.Search(title, startDate, endDate);
            return foundNews.ToList();
        }

    }
}
