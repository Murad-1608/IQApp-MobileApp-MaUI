namespace IQApp.DataAccess.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string Content { get; set; }
        public string Answer { get; set; }
        public bool IsCompleted { get; set; }
    }
}
