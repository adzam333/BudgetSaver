using System.Collections.ObjectModel;
using System.Windows.Input;
using BudgetSaver.Models;

namespace BudgetSaver.ViewModels;

public class AddEventViewModel : BaseViewModel
{
    private string name = string.Empty;
    private string description = string.Empty;
    private DateTime date = DateTime.Today;
    private Event? selectedEvent;

    public ObservableCollection<Event> Events { get; } = new();

    public string Name
    {
        get => name;
        set => SetProperty(ref name, value);
    }

    public string Description
    {
        get => description;
        set => SetProperty(ref description, value);
    }

    public DateTime Date
    {
        get => date;
        set => SetProperty(ref date, value);
    }

    public Event? SelectedEvent
    {
        get => selectedEvent;
        set => SetProperty(ref selectedEvent, value);
    }

    public ICommand AddEventCommand { get; }
    public ICommand EditEventCommand { get; }
    public ICommand DeleteEventCommand { get; }

    public AddEventViewModel()
    {
        AddEventCommand = new Command(OnAddEvent);
        EditEventCommand = new Command(OnEditEvent, () => SelectedEvent != null);
        DeleteEventCommand = new Command(OnDeleteEvent, () => SelectedEvent != null);
    }

    private void OnAddEvent()
    {
        var newEvent = new Event { Name = Name, Description = Description, Date = Date };
        Events.Add(newEvent);
        Name = string.Empty;
        Description = string.Empty;
        Date = DateTime.Today;
    }

    private void OnEditEvent()
    {
        if (SelectedEvent == null) return;
        SelectedEvent.Name = Name;
        SelectedEvent.Description = Description;
        SelectedEvent.Date = Date;
        OnPropertyChanged(nameof(Events));
    }

    private void OnDeleteEvent()
    {
        if (SelectedEvent == null) return;
        Events.Remove(SelectedEvent);
        SelectedEvent = null;
    }
}
