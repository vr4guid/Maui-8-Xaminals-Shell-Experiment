using Xaminals.Models;

namespace Xaminals.Views
{
    [QueryProperty(nameof(Name), "name")]
    [QueryProperty(nameof(Fish), "Fish")]
    public partial class FishDetailPage : ContentPage
    {
        public string Name { get; set; }

        Animal fish;
        public Animal Fish
        {
            get => fish;
            set
            {
                fish = value;
                OnPropertyChanged();
            }
        }

        public FishDetailPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
