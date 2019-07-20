using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDos.Models
{
    public class ToDo
    {
        public int id { get; set; }
        public string todo { get; set; }
        public bool isComplete { get; set; }
    }

    public class TodoData
    {
        public static List<ToDo> lstToDos = new List<ToDo>()
        {
            new ToDo() { id = 1, todo = "get groceries", isComplete = false },
            new ToDo() { id = 2, todo = "go shopping", isComplete = false },
            new ToDo() { id = 3, todo = "write report", isComplete = false },
            new ToDo() { id = 4, todo = "do laundary", isComplete = false },
            new ToDo() { id = 5, todo = "do homework", isComplete = false }
        };
    }
}
