using Irimia_Ofelia_Lab2.Models;

namespace Irimia_Ofelia_Lab2.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }

        public IEnumerable<Book> Books { get; set; }
    }
}
