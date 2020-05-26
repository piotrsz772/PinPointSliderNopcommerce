using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Core.Data;
using Nop.Plugin.Widgets.PinPointSlider.Domains;
using Nop.Services.Localization;
using Nop.Services.Messages;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;

namespace Nop.Plugin.Widgets.PinPointSlider.Controllers
{
    [AuthorizeAdmin] //confirms access to the admin panel
    [Area(AreaNames.Admin)] //specifies the area containing a controller or action
    public class PinPointSliderController : BasePluginController
    {
        private IRepository<PinPointSliderTable> _pinPointSliderRepository;
        private readonly ILocalizationService _localizationService;
        private readonly INotificationService _notificationService;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="pinPointSliderRepository"></param>
        public PinPointSliderController(IRepository<PinPointSliderTable> pinPointSliderRepository, 
            ILocalizationService localizationService,
            INotificationService notificationService)
        {
            _pinPointSliderRepository = pinPointSliderRepository;
            _localizationService = localizationService;
            _notificationService = notificationService;
        }

        public ActionResult Configure()
        {
            return View();
        }
    }
}
