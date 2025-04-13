using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke() 
        {
            var values = portfolioContext.Features.ToList();
            //Portfoliocontext içindeki Features tablosunun içindeki verileri liste olarak getir.  
            return View(values);
        }
    }
}
