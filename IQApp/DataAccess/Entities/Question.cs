using SQLite;

namespace IQApp.DataAccess.Entities
{
    [Table("Questions")]
    public class Question
    {
        [Column("Id")]
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Column("Level")]
        public int Level { get; set; }
        [Column("Content")]
        public string Content { get; set; }
        [Column("Answer")]
        public string Answer { get; set; }
        [Column("IsCompleted")]
        public bool IsCompleted { get; set; }
    }
}
