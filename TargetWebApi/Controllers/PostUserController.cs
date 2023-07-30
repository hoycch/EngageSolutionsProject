using Microsoft.AspNetCore.Mvc;
using TargetWebApi.Objects;

namespace TargetWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostUserController : ControllerBase
    {
        private static List<User> users = new List<User>();

        [HttpPost]
        public IActionResult PostUsers(List<User> userList)
        {
            // Perform validation if needed
            if (userList == null || userList.Count == 0)
            {
                return BadRequest("No user data received.");
            }

            // Add the list of users to the existing users (In a real-world scenario, this data would be saved in a database)
            users.AddRange(userList);

            // Return a success response
            return Ok($"User data posted successfully. {userList.Count} user records received.");
        }
    }

}