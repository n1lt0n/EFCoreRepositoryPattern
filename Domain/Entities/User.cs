using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Domain.Entities
{
    public class User : IIdentityEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        private ICollection<TaskToDo> TaskToDo { get; set; }
        public User()
        {
            this.TaskToDo = new Collection<TaskToDo>();
        }
        public void AddItemTodo(TaskToDo toDo)
        {
            TaskToDo.Add(toDo);
        }
    }
}
