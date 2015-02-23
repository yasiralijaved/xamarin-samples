using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expensometer.Core.ViewModels
{
    class MainPageViewModel : BaseViewModel
    {
        private string message;

        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                OnPropertyChanged(message);
            }
        }

        public MainPageViewModel()
        {
            Message = "Hello World!";
        }
    }
}
