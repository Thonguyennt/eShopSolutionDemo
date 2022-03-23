﻿using System.Threading.Tasks;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;

namespace eShopSolutionAdminApp.Controllers.Components
{
    public class PagerViewComponent : ViewComponent
    {

        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {

            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}
