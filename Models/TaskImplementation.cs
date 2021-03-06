namespace Bhoomika_Sadashiva_Sprint_I.Models
{
    public class TaskImplementation : ITaskRepository
    {
        private static List<TaskModel> taskModel = new List<TaskModel>();
        private int count = 2;

        public TaskImplementation()
        {
            taskModel.Add(new TaskModel() { TaskId = 1, AssignedUserId = 1, CreatedOn = DateTime.Now.ToUniversalTime(), Detail = "Task detail", ProjectId = 1, Status = 1 });
            taskModel.Add(new TaskModel() { TaskId = 2, AssignedUserId = 2, CreatedOn = DateTime.Now.ToUniversalTime(), Detail = "Task detail2", ProjectId = 2, Status = 2 });
        }
        public TaskModel AddTasks(TaskModel taskModels)
        {
            taskModels.ProjectId = ++count;
            taskModel.Add(taskModels);
            return taskModels;
        }

        public void DeleteTasks(int id)
        {
            var result = taskModel.FirstOrDefault(a => a.ProjectId == id);
            var deleted = taskModel.Remove(result);
        }

        public List<TaskModel> GetAllTasks()
        {
            return taskModel;
        }

        public TaskModel GetTasksById(int id)
        {
            return taskModel.FirstOrDefault(e => e.TaskId == id);
        }

        public void UpdateTasks(TaskModel taskModel)
        {
            var data = new TaskModel()
            {
                TaskId = taskModel.TaskId,
                AssignedUserId = taskModel.AssignedUserId,
                Status = taskModel.Status,
                CreatedOn = taskModel.CreatedOn
            };
        }
    }
}
