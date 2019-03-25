namespace migo_api.Model
{
  public class Comment
  {
    public int Id { get; set; }

    public string Description { get; set; }


    //   Navegation properties
    public int localId { get; set; }

    public Local Local { get; set; }
  }

}