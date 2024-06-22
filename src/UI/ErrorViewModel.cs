using System.Windows.Input;
using Caliburn.Micro;

namespace Assignment.UI;
public class ErrorViewModel : Screen
{
    private string _title;
    public string Title
    {
        get => _title;
        set
        {
            _title = value;
            NotifyOfPropertyChange(() => Title);
        }
    }
    private string _message;
    public string Message
    {
        get => _message;
        set
        {
            _message = value;
            NotifyOfPropertyChange(() => Message);
        }
    }
    public ICommand CloseCommand { get; }

    public ErrorViewModel(string errorTitle, string errorMessage)
    {
        Title = errorTitle;
        Message = errorMessage;
        CloseCommand = new RelayCommand(CloseExecute);
    }

    private async void CloseExecute(object parameter)
    {
        await TryCloseAsync(false);
    }
}
