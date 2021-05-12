using System.Collections.Generic;
using System.Linq;

namespace ToroChallenge.Domain
{
    public class Notification
    {
        public bool IsValid { get { return !_errors.Any(); } }
        public List<ErrorMessageResponse> Errors
        {
            get
            {
                List<ErrorMessageResponse> listagem = new List<ErrorMessageResponse>();
                foreach (var item in _errors)
                {
                    listagem.Add(new ErrorMessageResponse() { Propriedade = item.Key, MensagemErro = item.Value });
                }
                return listagem;
            }
        }
        public Notification()
        {
            _errors = new Dictionary<string, string>();
        }
        private Dictionary<string, string> _errors { get; set; }
        public void AddNotification(string property, string message)
        {
            _errors.Add(property, message);
        }
    }
}

