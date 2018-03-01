namespace Narrativia.Data.Entities
{
    public class Page : ContentPage
    {
        public string DisplayName { get; set; }
        public string IconIdentifier { get; set; }
        public bool VisibleInHeader { get; set; }
    }
}