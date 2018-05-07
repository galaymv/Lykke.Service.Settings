using JetBrains.Annotations;
using Lykke.Service.Settings.Settings.ServiceSettings;
using Lykke.Service.Settings.Settings.SlackNotifications;

namespace Lykke.Service.Settings.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class AppSettings
    {
        public SettingsServiceSettings SettingsService { get; set; }
        public DbSettings Db { get; set; }
        public SlackNotificationsSettings SlackNotifications { get; set; }
    }
}
