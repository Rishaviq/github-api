using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_api
{
    internal class pEvents
    {
        public int id;
        public string type;
        public Actor actor;
        public Repo repo;
        public Payload? payload;
        public bool isPublic;
        public string created_at;
        public Org org;
    }
}
