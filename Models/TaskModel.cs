namespace Bhoomika_Sadashiva_Sprint_I.Models
{
    public class TaskModel
    {
        public int TaskId { get; set; }

        public int ProjectId { get; set; }

        public int Status { get; set; }
        public int AssignedUserId { get; set; }

        public string Detail { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
