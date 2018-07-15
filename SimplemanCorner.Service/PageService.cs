using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimplemanCorner.Data.Infrastructure;
using SimplemanCorner.Data.Repositories;
using SimplemanCorner.Model.Models;
using System.Linq;

namespace SimplemanCorner.Service
{
    public interface IPageService
    {
        Page GetByAlias(string alias);
    }
    public class PageService : IPageService
    {
        IPageRepository _pageRepository;
        IUnitOfWork _unitOfWork;
        public PageService(IPageRepository pageRepository, IUnitOfWork unitOfWork)
        {
            this._pageRepository = pageRepository;
            this._unitOfWork = unitOfWork;
        }
        public Page GetByAlias(string alias)
        {
            return _pageRepository.GetSingleByCondition(x => x.Alias == alias);
        }
    }
}
