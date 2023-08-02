using System.Text.Json;
using TargetWebApi.Objects;

namespace TargetWebApi.Functions
{
    public static class HelperFunctions
    {
        public static void ApendString(EngageUser user) { 
           using (var sw = File.AppendText("users.json")) {

                string jsonText = JsonSerializer.Serialize(user);
                
                sw.WriteLine(jsonText);
            
            }
        }
    }
}
