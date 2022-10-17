
namespace DxDiary.Models
{
    public class UserProfile
    {
        public Guid UserId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string? AvatarUrl { get; set; }
    }
}
