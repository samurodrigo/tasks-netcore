using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TasksApi.Models;

namespace TasksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksListController: ControllerBase{
        private readonly TaskContext _context;
        public TasksListController(TaskContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskList>>> GetTaskListAsync() {
            return await _context.TasksList.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskList>> GetTaskById(long id) {
            var taskList = await _context.TasksList.FindAsync(id);

            if(taskList == null){
                return NotFound();
            }
            await _context.Tasks.LoadAsync();
            return taskList;
        }

        [HttpPost]
        public async Task<ActionResult<TaskList>> PostTaskList(TaskList taskList){
            _context.TasksList.Add(taskList);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTaskById), new { ID = taskList.ID }, taskList);
        }
    }
}