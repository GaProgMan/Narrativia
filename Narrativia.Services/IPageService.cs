using System.Collections.Generic;
using Narrativia.Data.Entities;
using Narrativia.DTO;

namespace Narrativia.Services
{
    public interface IPageService
    {
        IEnumerable<Page> GetPages();
        PageDto GetPage(uint id);
        PageDto GetPage(string title);
        void InsertPage(Page page);
        void UpdatePage(Page page);
        void DeletePAge(uint id);
    }
}