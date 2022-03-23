using System.Collections.Generic;
using eShopSolution.ViewModels.System.Languages;

namespace eShopSolutionAdminApp.Models
{
    public class NavigationViewModel
    {
        public List<LanguageVm> Languages { get; set; }
        public string CurrentLanguageId { get; set; }
    }
}
