using Microsoft.AspNetCore.Identity;

namespace Fafnir.Data
{
    public class Settings
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Secret { get; set; }
        public string AssetToShow { get; set; }
        public IdentityUser User { get; set; }
    }
}
