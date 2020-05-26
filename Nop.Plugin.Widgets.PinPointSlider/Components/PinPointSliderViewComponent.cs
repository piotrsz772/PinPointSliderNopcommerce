using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;
using System;

namespace Nop.Plugin.Widgets.PinPointSlider.Components
{
    [ViewComponent(Name = "PinPointSlider")]
    public class PinPointSliderViewComponent : NopViewComponent
    {
        public PinPointSliderViewComponent()
        {

        }

        public IViewComponentResult Invoke(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
