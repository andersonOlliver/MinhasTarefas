using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasTarefas.Model
{
    public class User
    {
        public string UserId { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public User()
        {

        }

        public User(string userId, string name, string image)
        {
            this.UserId = userId;
            this.Name = name;
            this.Image = image;
        }
    }
}
