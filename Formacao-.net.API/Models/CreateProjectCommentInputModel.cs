namespace Formacao_.net.API.Models
{
    public class CreateProjectCommentInputModel
    {
        public string Content {  get; set; }
        public int IdProject {  get; set; }
        public int IdUsers {  get; set; }
    }
}