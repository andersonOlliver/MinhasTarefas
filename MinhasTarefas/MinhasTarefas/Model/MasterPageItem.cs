using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasTarefas.Model
{
    public class MasterPageItem
    {

        public string Title { get; set; }

        public string Icon { get; set; }

        public Type TargetType { get; set; }

        public MasterPageItem() {}

        public MasterPageItem(string title)
        {
            Title = title;
        }

        public MasterPageItem(string title, string icon)
        {
            Title = title;
            Icon = icon;
        }

        public MasterPageItem(string title, string icon, Type type)
        {
            Title = title;
            Icon = icon;
            TargetType = type;
        }
    }
}
