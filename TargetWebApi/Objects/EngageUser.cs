namespace TargetWebApi.Objects
{
    public class EngageUser
    {
        public string reference { get; set; }
        public string username { get; set; }
        public string first_name { get; set; }
        public int first_name_editable { get; set; }
        public string last_name { get; set; }
        public int lastName_editable { get; set; }
        public string department { get; set; }
        public int department_visible { get; set; }
        public int department_editable { get; set; }
        public string manager_ref { get; set; }
        public int manager_visible { get; set; }
        public string location_ref { get; set; }
        public string job_title { get; set; }
        public int job_title_visible { get; set; }
        public int job_title_editable { get; set; }
        public string email { get; set; }
        public int email_visible { get; set; }
        public int email_editable { get; set; }
        public string password { get; set; }
        public string date_of_birth { get; set; }
        public int date_of_birth_visible { get; set; }
        public int date_of_birth_editable { get; set; }
        public string start_date { get; set; }
        public int start_date_visible { get; set; }
        public int start_date_editable { get; set; }
        public string image { get; set; }
        public string bio { get; set; }
        public int bio_visible { get; set; }
        public int bio_editable { get; set; }
        public string pin { get; set; }
        public int status { get; set; }
        public List<EngageAttribute> attributes { get; set; }
        public List<string> groups { get; set; }
        public List<string> visible_to_groups { get; set; }
    }
}
