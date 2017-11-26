using System.Collections.Generic;
using System.Linq;
using Narrativia.Data.Entities;
using Narrativia.DTO;
using Narrativia.Repository.Data;

namespace Narrativia.Services
{
    public class PageService : IPageService
    {
        private readonly IRepository<Page> _pageRepository;

        public PageService(IRepository<Page> pageRepository)
        {
            _pageRepository = pageRepository;
        }
        
        public IEnumerable<Page> GetPages()
        {
            throw new System.NotImplementedException();
        }

        public PageDto GetPage(uint id)
        {
            var dbPage = _pageRepository.Get(1);
            return new PageDto(dbPage);
        }

        public PageDto GetPage(string title)
        {
            throw new System.NotImplementedException();
        }

        public void InsertPage(Page page)
        {
            throw new System.NotImplementedException();
        }

        public void UpdatePage(Page page)
        {
            throw new System.NotImplementedException();
        }

        public void DeletePAge(uint id)
        {
            throw new System.NotImplementedException();
        }
    }
}