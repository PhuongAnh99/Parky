using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ParkyWeb.Models.ViewModels
{
    public class TrailVM
    {
        [ValidateNever]
        public IEnumerable<SelectListItem> NationalParkList { get; set; }
        public Trail Trail { get; set; }
    }
}
