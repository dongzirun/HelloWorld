using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DZT.Authorization;

namespace DZT
{
    [DependsOn(
        typeof(DZTCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DZTApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DZTAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DZTApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
