namespace Narrativia.Data.Entities
{
    public abstract class ContentPage : BaseAuditClass
    {
        public string Title { get; set; }
        public string HeaderImageUrl { get; set; }
        public string BodyText { get; set; }
    }
}