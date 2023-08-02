using Microsoft.AspNetCore.Mvc;
using TargetWebApi.Functions;
using TargetWebApi.Objects;


namespace TargetWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostUserListController : ControllerBase
    {
        private static List<SimpleUser> users = new List<SimpleUser>();

        [HttpPost]
        public IActionResult PostUsers(List<SimpleUser> userList)
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
    [ApiController]
    [Route("[controller]")]
    public class PostUserController : ControllerBase
    {
        [HttpPost]
        public IActionResult PostUser(EngageUser user)
        {
            // Perform validation if needed
            if (user == null)
            {
                return BadRequest("No user data received.");
            }

            // Add the list of users to the existing users (In a real-world scenario, this data would be saved in a database)

            // Return a success response
            HelperFunctions.ApendString(user);
            return Ok("User data posted successfully.");
        }
    }

}