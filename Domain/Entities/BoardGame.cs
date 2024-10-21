namespace Domain;

public class BoardGame
{
    public String Name { get; set; }
    public String Description { get; set; }
    public Genre Genre;
    public bool Is18Plus { get; set; }
    public String Picture { get; set; }
    public TypeGame TypeGame; 
}