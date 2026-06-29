using DispatchHub.Api.Enums;

namespace DispatchHub.Api.Models
{
    public class PhoneInfo
    {
        public string DDI { get; set; }
        public string DDD { get; set; }
        public string Number { get; set; }
        public PhoneTypeEnum Type { get; set; }
    }
}
