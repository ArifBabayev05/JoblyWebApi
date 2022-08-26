using System;
using Autofac;
using Business.Abstract;
using Business.Concrete;

namespace Business.DependencyResolvers.AutoFac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<VacancyManager>().As<IVacancyService>();
        }
    }
}

