using Xamarin.Forms;

namespace Locus.Data.Models;
public class InsuranceInformation : BindableObject
{
    public string? Title { get; set; }
    public string? Description { get; set; }

    private bool _isDescriptionVisible;
    public bool IsDescriptionVisible
    {
        get => _isDescriptionVisible;
        set
        {
            _isDescriptionVisible = value;
            OnPropertyChanged();
        }
    }
}

