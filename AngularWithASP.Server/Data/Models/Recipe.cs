namespace AngularWithASP.Server.Data.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public required string Title {get;set;}
        public string? Description {get;set;}
        public List<string> Ingredients {get; set;} = new List<string>();
        public List<string> Instructions {get;set;} = new List<string>();

    }

}

