namespace IPSI.Services.Data.Implementations
{
    using System.Linq;

    using IPSI.Data.Common.Repositories;
    using IPSI.Data.Models;
    using IPSI.Services.Data.Contracts;

    public class SettingsService : ISettingsService
    {
        private readonly IDeletableEntityRepository<Setting> settingsRepository;

        public SettingsService(IDeletableEntityRepository<Setting> settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        public int GetCount()
        {
            return this.settingsRepository.All().Count();
        }
    }
}
