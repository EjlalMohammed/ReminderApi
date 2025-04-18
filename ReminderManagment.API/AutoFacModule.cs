
using Application.Common;
using Autofac;
using Infrastructure.Data;
using System.Reflection;

namespace ReservePro.Managemant.Api
{
    public class AutoFacModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var asm = new[]
            {
                Assembly.GetExecutingAssembly(),
                Assembly.Load("Application"),
                Assembly.Load("Infrastructure"),
            };
            builder.RegisterInstance(MappingConfig.Configure());

            builder.RegisterAssemblyTypes(asm)
                .AsImplementedInterfaces()
                .PublicOnly();
           
            builder.RegisterType<ReminderDbContext>().AsSelf().InstancePerLifetimeScope();

        }
    }
}