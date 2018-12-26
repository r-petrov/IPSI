namespace IPSI.Web.ViewModels.Settings
{
    using IPSI.Data.Models;
    using IPSI.Services.Mapping;

    public class SettingViewModel : IMapFrom<Setting>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}
