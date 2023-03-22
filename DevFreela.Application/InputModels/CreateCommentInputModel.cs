using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.InputModels
{
    public class CreateCommentInputModel
    {
        public string Content { get; private set; }
        public string IdProject { get; set; }
        public string IdUser { get; set; }
    }
}
