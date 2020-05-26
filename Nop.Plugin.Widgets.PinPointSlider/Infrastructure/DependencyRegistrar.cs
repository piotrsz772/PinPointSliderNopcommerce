using Autofac;
using Autofac.Core;
using Nop.Core.Configuration;
using Nop.Core.Data;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Data;
using Nop.Plugin.Widgets.PinPointSlider.Data;
using Nop.Plugin.Widgets.PinPointSlider.Domains;
using Nop.Web.Framework.Infrastructure.Extensions;

namespace Nop.Plugin.Widgets.PinPointSlider.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        private static string CONTEXT_NAME = "PinPointSlider_object_context";

        public void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            //builder.RegisterType<PinPointSliderService>().As<IPinPointSliderAttributeService>().InstancePerLifetimeScope();

            //builder.RegisterType<PinPointSliderModelFactory>().As<IPinPointSliderModelFactory>().InstancePerLifetimeScope();

            //data context
            builder.RegisterPluginDataContext<PinPointSliderObjectContext>(CONTEXT_NAME);

            //override required repository with our PinPointSlider context
            builder.RegisterType<EfRepository<PinPointSliderTable>>()
                .As<IRepository<PinPointSliderTable>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>(CONTEXT_NAME))
                .InstancePerLifetimeScope();
        }

        public int Order => 1;
    }
}
