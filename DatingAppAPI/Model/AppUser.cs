using System.ComponentModel.DataAnnotations;

namespace DatingAppAPI.Model
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        


    }
}
