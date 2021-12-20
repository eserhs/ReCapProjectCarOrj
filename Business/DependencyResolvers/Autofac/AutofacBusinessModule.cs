using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Corcretes;
using Castle.DynamicProxy;
using Core.Utilites.İnterceptars;
using DataAccess.Abstract;
using DataAccess.Corcretes.EntityFrameWord;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
  public  class AutofacBusinessModule:Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            builder.RegisterType<CarDal>().As<ICarDal>().SingleInstance();

            builder.RegisterType<BrandManager>().As<IBrandService>().SingleInstance();
            builder.RegisterType<BrandDal>().As<IBrandDal>().SingleInstance();

            builder.RegisterType<ColorManager>().As<IColorService>().SingleInstance();
            builder.RegisterType<ColorDal>().As<IColorDal>().SingleInstance();

            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<CustomerDal>().As<ICustomerDal>().SingleInstance();


            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<UserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<RentalManager>().As<IRentalService>().SingleInstance();
            builder.RegisterType<RentalDal>().As<IRentalDal>().SingleInstance();

            builder.RegisterType<ImageManager>().As<IImageService>().SingleInstance();
            builder.RegisterType<ImageDal>().As<IImageCarDal>().SingleInstance();




            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();



        }
    }
}
