using Nu.Data.Enums;

namespace Nu.Data.Interfaces
{
    public interface ISwitchable
    {
        StatusEnum Status { get; set; }
    }
}