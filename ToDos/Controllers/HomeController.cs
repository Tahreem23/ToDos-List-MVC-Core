using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDos.Models;

namespace ToDos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.lstToDos = TodoData.lstToDos;
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(ToDo model)
        {
            int maxId = 1;

            if (TodoData.lstToDos.Count > 0)
                maxId = TodoData.lstToDos.Max(x => x.id) + 1;

            TodoData.lstToDos.Add(new ToDo() { id = maxId, todo = model.todo, isComplete = false });

            ViewBag.lstToDos = TodoData.lstToDos;
            return View("Index");
        }

        public IActionResult DeleteToDo(int id)
        {
            TodoData.lstToDos.RemoveAll(x => x.id == id);

            ViewBag.lstToDos = TodoData.lstToDos;
            return View("Index");
        }

        [HttpPost]
        public IActionResult changeToDoStatus(int id, bool isComplete)
        {
            var obj = TodoData.lstToDos.FirstOrDefault(x => x.id == id);
            if (obj != null) obj.isComplete = isComplete;

            ViewBag.lstToDos = TodoData.lstToDos;
            return View("Index");
        }
    }
}
