using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise
{
    public class UserInput
    {
        private string _promptName;
        private string _prompt;
        private string _aiModel;
        private string _reason;
        private DateTime _date;
        private bool _changedAI;

        public UserInput(string promptName, string prompt, string aiModel, string reason, DateTime date, bool changedAi)
        {
            _promptName = promptName;
            _prompt = prompt;
            _aiModel = aiModel;
            _reason = reason;
            _date = date;
            _changedAI = changedAi;
        }
    }
}
