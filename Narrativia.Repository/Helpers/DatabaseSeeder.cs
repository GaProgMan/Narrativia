using System.Threading.Tasks;
using Narrativia.Repository.Data;

namespace Narrativia.Repository.Helpers
{
    public class DatabaseSeeder
    {
        private readonly DataContext _dataContext;

        public DatabaseSeeder(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<int> SeedBlogPosts()
        {
//            _dataContext.Books.Add(
//                new Book()
//                {
//                    BookName = "The Colour of Magic",
//                    BookOrdinal = 1,
//                    BookIsbn10 = "086140324X",
//                    BookIsbn13 = "9780552138932",
//                    BookDescription = "On a world supported on the back of a giant turtle (sex unknown), a gleeful, explosive, wickedly eccentric expedition sets out. There's an avaricious but inept wizard, a naive tourist whose luggage moves on hundreds of dear little legs, dragons who only exist if you believe in them, and of course THE EDGE of the planet ...",
//                    BookCoverImageUrl = "http://wiki.lspace.org/mediawiki/images/c/c9/Cover_The_Colour_Of_Magic.jpg"
//                });
            // TODO implement method
            return await _dataContext.SaveChangesAsync();
        }

        public async Task<int> SeedComments()
        {
//            _dataContext.Series.Add(new Series()
//            {
//                SeriesName = "Rincewind"
//            });
            // TODO implement method
            return await _dataContext.SaveChangesAsync();
        }
    }
}