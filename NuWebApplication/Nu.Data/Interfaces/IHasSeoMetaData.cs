namespace Nu.Data.Interfaces
{
    public interface IHasSeoMetaData
    {
        string SeoPageTitle { get; set; }
        string SeoAlias { get; set; }
        string SeoKeyWords { get; set; }
        string SeoDescription { get; set; }
    }
}