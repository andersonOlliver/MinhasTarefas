using Newtonsoft.Json;

namespace MinhasTarefas.Model
{
    public class User
    {

        [JsonProperty("userId")]
        public string UserId { get; set; }
        
        public string Name { get; set; }
        
        public string Password { get; set; }

        public string Profile { get; set; }

        public string Cover { get; set; }

        public User()
        { }

        public User(string userId, string name, string profile)
        {
            this.UserId = userId;
            this.Name = name;
            this.Profile = profile;
        }

        public User(string userId, string name, string profile, string cover)
        {
            this.UserId = userId;
            this.Name = name;
            this.Profile = profile;
            this.Cover = cover;
        }
    }
}
