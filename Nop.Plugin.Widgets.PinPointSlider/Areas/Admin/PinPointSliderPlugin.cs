using System.Linq;
using Microsoft.AspNetCore.Routing;
using Nop.Core.Data;
using Nop.Plugin.Widgets.PinPointSlider.Data;
using Nop.Plugin.Widgets.PinPointSlider.Domains;
using Nop.Services.Plugins;
using Nop.Web.Framework.Menu;
using Nop.Core;

namespace Nop.Plugin.Widgets.PinPointSlider.Areas.Admin
{
    public class PinPointSliderPlugin : BasePlugin, IAdminMenuPlugin
    {

        private PinPointSliderObjectContext _context;
        private IRepository<PinPointSliderTable> _pinPointSliderRepo;
        private IWebHelper _webHelper;

        public PinPointSliderPlugin(
            PinPointSliderObjectContext context, 
            IRepository<PinPointSliderTable> pinPointSliderRepo,
            IWebHelper webHelper)
        {
            _context = context;
            _pinPointSliderRepo = pinPointSliderRepo;
            _webHelper = webHelper;
        }

        public void ManageSiteMap(SiteMapNode rootNode)
        {
            var menuItem = new SiteMapNode()
            {
                SystemName = "PinPointSlider",
                Title = "Pin Point Slider",
                ControllerName = "PinPointSliderController",
                ActionName = "List",
                Visible = true,
                RouteValues = new RouteValueDictionary() { { "area", null } },
            };
            var pluginNode = rootNode.ChildNodes.FirstOrDefault(x => x.SystemName == "Pin Point Slider");
            if (pluginNode != null)
                pluginNode.ChildNodes.Add(menuItem);
            else
                rootNode.ChildNodes.Add(menuItem);
        }

        public override void Install()
        {
            _context.Install();
            base.Install();
        }

        public override void Uninstall()
        {
            _context.Uninstall();
            base.Uninstall();
        }

        public override string GetConfigurationPageUrl()
        {
            return $"{_webHelper.GetStoreLocation()}Admin/PinPointSliderController/Configure";
        }
    }
}
