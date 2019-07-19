using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iCSHD.Models
{
    public class EngineerProfile
    {
        private Guid engID;
        private string alias;
        private string manager;
        private string pod;
        private string name;
        private string email;
        
        public EngineerProfile(Guid engID, string alias, string manager, string pod, string name, string email)
        {
            this.engID = engID;
            this.alias = alias;
            this.manager = manager;
            this.pod = pod;
            this.name = name;
            this.email = email;
        }

        public string Alias
        {
            get { return alias; }
            set { alias = value; }
        }

        public string Manager
        {
            get { return manager; }
            set { manager = value; }
        }

        public string Pod
        {
            get { return pod; }
            set { pod = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Guid EngID
        {
            get { return engID; }
            set { engID = value; }
        }

    }
}