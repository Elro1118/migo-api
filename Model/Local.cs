using System.Collections.Generic;

namespace migo_api.Model
{
  public class Local
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Schedule { get; set; }

    //   Navegation properties
    public List<Volunteer> Volunteers { get; set; } = new List<Volunteer>();
    public List<Comment> Comments { get; set; } = new List<Comment>();
  }
}