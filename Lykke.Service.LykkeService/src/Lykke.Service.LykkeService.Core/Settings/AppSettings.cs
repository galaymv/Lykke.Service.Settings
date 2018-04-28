using JetBrains.Annotations;
using Lykke.Service.LykkeService.Core.Settings.ServiceSettings;
using Lykke.Service.LykkeService.Core.Settings.SlackNotifications;

namespace Lykke.Service.LykkeService.Core.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class AppSettings
    {
        public LykkeServiceSettings LykkeServiceService { get; set; }
        public SlackNotificationsSettings SlackNotifications { get; set; }
    }
}
