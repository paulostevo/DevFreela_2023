using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext 
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu Primeiro projeto 1","Teste",1,1,2000),
                new Project("Meu Primeiro projeto 2","Teste 2",1,1,3000),
                new Project("Meu Primeiro projeto 3","Teste 3",1,1,3000)
            };

            Users = new List<User>
            {
                new User(1,"Paulo","teste@teste.com",new DateTime(1990,1,1)),
                new User(2,"Stevo","teste2@teste.com",new DateTime(1990,1,7)),
                new User(3,"Gomes","teste3@teste.com",new DateTime(1990,1,15))
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("SQL"),
                new Skill("C#")
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
