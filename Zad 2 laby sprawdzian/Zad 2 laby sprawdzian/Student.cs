using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2_laby_sprawdzian
{
    internal class Student : Person, IEquatable<Student>
    {
        protected string group;
        protected List<Task> tasks = new List<Task>();

        public string Group { get => this.group; set => this.group = value;}

        public Student(string name, int age, string group) : base(name, age)
        {
            this.group = group;
        }

        public Student(string name, int age, string group, List<Task> task) : base(name, age)
        {
            this.group = group;
            this.tasks = task;
        }

        public void AddTask(string taskName, TaskStatus taskStatus)
        {
            Task task = new Task(taskName, taskStatus);
            tasks.Add(task);
        }

        public void RemoveTask(int index)
        {
            this.tasks.RemoveAt(index);
        }

        public void UpdateTask(int index, TaskStatus taskStatus)
        {
            Task task = tasks[index];
            task.Status = taskStatus;

            this.tasks.RemoveAt(index);
            this.tasks.Insert(index, task);
        }

        public string RenderTasks(string prefix = "\t")
        {
            string result = "";
            for (int i = 0; i < tasks.Count; i++)
            {
                result += $"{prefix}{i}." + tasks[i].ToString();
            }
            return result;
        }

        public override string ToString()
        {
            return $"Student: " + base.ToString() + $"\nGroup: {this.Group}\nTasks: " + this.RenderTasks();
        }


    }
}
