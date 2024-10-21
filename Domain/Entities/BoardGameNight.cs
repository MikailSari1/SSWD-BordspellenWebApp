using System.ComponentModel.DataAnnotations;
/*using Microsoft.EntityFrameworkCore;*/

namespace Domain;

public class BoardGameNight
{
    /*[Key]*/
    public int Id { get; set; }
    
    public User Organizer { get; set; }
    public Address Address { get; set; }
    public List<User> Participants { get; set; } = new List<User>();

    public int MaxParticipants { get; set; }
    public DateTime DateTime { get; set; }
    
    public string Snacks { get; set; }
}