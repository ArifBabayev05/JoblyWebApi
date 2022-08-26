using System;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.AutoFac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<VacancyManager>().As<IVacancyService>();
            builder.RegisterType<EfVacancyDal>().As<IVacancyDal>();

        }
    }
}

