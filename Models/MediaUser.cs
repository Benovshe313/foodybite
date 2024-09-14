
namespace Foody_bite.Models
{
    internal class MediaUser
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
