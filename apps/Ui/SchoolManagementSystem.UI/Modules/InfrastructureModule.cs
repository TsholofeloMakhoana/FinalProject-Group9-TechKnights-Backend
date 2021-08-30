using Autofac;
using SchoolManagementSystem.Feed;


namespace SchoolManagementSystem.UI.Modules
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RepositoryConnectionWrapper>().As<IRepositoryConnectionWrapper>();
            base.Load(builder);
        }
    }
}
