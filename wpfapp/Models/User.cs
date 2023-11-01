//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace wpfapp.Models
{
  //public class User
  //{
  //  public int Id { get; set; }
  //  public string FirstName { get; set; } = string.Empty;
  //  public string LastName { get; set; } = string.Empty;
  //}

  public record class User
  {
    public int Id { get; } // {get; init; }
    public string FirstName { get; }
    public string LastName { get; }

    public User(int id, string first, string last) => (Id, FirstName, LastName) = (id, first, last);
  }
}
