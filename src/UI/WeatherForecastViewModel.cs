using System.Windows.Controls;
using System.Windows.Input;
using Assignment.Application.Common.Interfaces;
using Assignment.Domain.Entities;
using Caliburn.Micro;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Assignment.UI;
public class WeatherForecastViewModel : Screen
{
    private readonly ISender _sender;
    private readonly IWindowManager _windowManager;
    private readonly IApplicationDbContext _context;

    #region properties
    private Country _country;

    public Country Country
    {
        get { return _country; }
        set
        {
            _country = value;

            NotifyOfPropertyChange(() => Country);
        }
    }
    private List<Country> _countries;

    public List<Country> Countries
    {
        get { return _countries; }
        set
        {
            _countries = value;

            NotifyOfPropertyChange(() => Countries);
        }
    }

    private City _city;

    public City City
    {
        get { return _city; }
        set
        {
            _city = value;

            NotifyOfPropertyChange(() => City);
        }
    }

    private List<City> _cities;

    public List<City> Cities
    {
        get { return _cities; }
        set
        {
            _cities = value;

            NotifyOfPropertyChange(() => Cities);
        }
    }

    private string _temperature;

    public string Temperature
    {
        get { return _temperature; }
        set
        {
            _temperature = value;

            NotifyOfPropertyChange(() => Temperature);
        }
    }
    #endregion

    public WeatherForecastViewModel(ISender sender, IWindowManager windowManager)
    {
        _sender = sender;
        _windowManager = windowManager;
        _context = Bootstrapper.ServiceProvider.GetService<IApplicationDbContext>();
        Initialize();
    }

    private void Initialize()
    {
        Countries = _context.Countries.ToList();
    }

    private void OnCountryChanged(object sender, SelectionChangedEventArgs e)
    {
    }

    private void OnCityChanged(object sender, SelectionChangedEventArgs e)
    {
    }
}
