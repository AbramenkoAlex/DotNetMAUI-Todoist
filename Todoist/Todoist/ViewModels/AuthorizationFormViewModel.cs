using System.ComponentModel;
using System.Windows.Input;

namespace Todoist.ViewModels
{
    public class AuthorizationFormViewModel : INotifyPropertyChanged
    {
        private bool _isSubmitted;

        public string Email { get; set; }

        public string Password { get; set; }

        public ICommand TapFormCommand { get; set; }

        public ICommand CloseFormCommand { get; set; }

        public ICommand SubmitFormCommand { get; set; }

        public bool IsSubmitted 
        {
            get => _isSubmitted;
            set
            {
                _isSubmitted = value;
                RaisePropertyChanged(nameof(IsSubmitted));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
