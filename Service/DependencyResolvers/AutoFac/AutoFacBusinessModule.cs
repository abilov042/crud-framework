using Autofac;
using Dao.Abstracts;
using Dao.Concretes;
using Service.Abstracts;
using Service.Concretes;

namespace Service.DependencyResolvers.AutoFac;

public class AutoFacBusinessModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
        builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
    }
}