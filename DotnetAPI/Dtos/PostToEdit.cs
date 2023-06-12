namespace DotnetAPI.Dtos
{
  public partial class PostToEdit
  {
    
      public int PostId { get; set; }
      public string PostTitle { get; set; }
      public string PostContent { get; set; }
   
      
      public PostToEdit()
      {
        if(PostTitle == null)
        {
          PostTitle = "";
        }
        if(PostContent == null)
        {
          PostContent = "";
        }
      }
  }

}