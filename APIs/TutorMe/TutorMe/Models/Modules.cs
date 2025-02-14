﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TutorMe.Models
{
    public partial class Module
    {
        public Module()
        {
            Connections = new HashSet<Connection>();
            Group = new HashSet<Group>();
            RequestModule = new HashSet<Request>();
            UserModule = new HashSet<UserModule>();
        }

        public Guid ModuleId { get; set; }
        public string Code { get; set; }
        public string ModuleName { get; set; }
        public Guid InstitutionId { get; set; }
        public string Faculty { get; set; }
        public string Year { get; set; }

        [JsonIgnore]
        public virtual Institution Institution { get; set; }
        [JsonIgnore]
        public virtual ICollection<Connection> Connections { get; set; }
        [JsonIgnore]
        public virtual ICollection<Group> Group { get; set; }
        [JsonIgnore]
        public virtual ICollection<Request> RequestModule { get; set; }
        [JsonIgnore]
        public virtual ICollection<UserModule> UserModule { get; set; }

    }
}