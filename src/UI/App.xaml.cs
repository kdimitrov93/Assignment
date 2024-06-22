using System.Windows.Threading;
using Assignment.Application.Common.Exceptions;
using Caliburn.Micro;
using Microsoft.Extensions.DependencyInjection;

namespace Assignment.UI;

public partial class App : System.Windows.Application
{
    private readonly IWindowManager _windowManager;

    public App()
    {
        _windowManager = Bootstrapper.ServiceProvider.GetService<IWindowManager>();
    }
    void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
    {
        e.Handled = true;
        if (e.Exception is ValidationException)
        {
            var errors = ((ValidationException)e.Exception).Errors.SelectMany(err => err.Value).ToList();
            ErrorViewModel errorWindow = new ErrorViewModel(e.Exception.Message, string.Join(" \n\r", errors));
            _windowManager.ShowDialogAsync(errorWindow);
        }
        else
        {
            ErrorViewModel errorWindow = new ErrorViewModel(e.Exception.Message, e.Exception.InnerException?.Message);
            _windowManager.ShowDialogAsync(errorWindow);
        }
    }
}
