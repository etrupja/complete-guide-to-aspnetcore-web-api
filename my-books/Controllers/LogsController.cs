using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_books.Data.Services;
using my_books.Data.ViewModels.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    [Route("api/[controller]")]
    [ApiController]
    public class LogsController : ControllerBase
    {
        private LogsService _logsService;
        public LogsController(LogsService logsService)
        {
            _logsService = logsService;
        }

        [HttpGet("get-all-logs-from-db")]
        public IActionResult GetAllLogsFromDB()
        {
            try
            {
                var allLogs = _logsService.GetAllLogsFromDB();
                return Ok(allLogs);
            }
            catch (Exception)
            {
                return BadRequest("Could not load logs from the database");
            }
        }
    }
}
