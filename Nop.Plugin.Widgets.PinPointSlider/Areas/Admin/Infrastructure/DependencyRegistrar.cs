using Autofac;
using Nop.Core.Configuration;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;

namespace Nop.Plugin.Widgets.PinPointSlider.Areas.Admin.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public DependencyRegistrar()
        {

        }

        public void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            //builder.RegisterType<PinPointSliderModelFactory>().As<IPinPointSliderModelFactory>().InstancePerLifetimeScope();
        }

        public int Order => 1;
    }
}
