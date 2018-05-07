using JetBrains.Annotations;

namespace Lykke.Service.LykkeService.Core.Settings.ServiceSettings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class LykkeServiceSettings
    {
        public DbSettings Db { get; set; }
    }
}
