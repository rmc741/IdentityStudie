using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityStudie.Application.QuestionSolicitation.Commands
{
    public class SolicitationUpdateCommand : QuestionSolicitationCommand
    {
        public int Id { get; set; }
    }
}
