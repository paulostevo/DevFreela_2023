using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class ProjectComment : BaseEntity
    {
        public ProjectComment(string content, string idProject, string idUser)
        {
            Content = content;
            IdProject = idProject;
            IdUser = idUser;

        }

        public string Content { get; private set; }
        public string IdProject { get; set; }
        public string IdUser { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
