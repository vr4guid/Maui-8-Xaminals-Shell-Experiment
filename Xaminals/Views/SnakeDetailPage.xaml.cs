using Xaminals.Models;

namespace Xaminals.Views
{
    [QueryProperty(nameof(Name), "name")]
    [QueryProperty(nameof(Snake), "Snake")]
    public partial class SnakeDetailPage : ContentPage
    {
        public string Name { get; set; }

        Animal snake;
        public Animal Snake
        {
            get => snake;
            set
            {
                snake = value;
                OnPropertyChanged();
            }
        }

        public SnakeDetailPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
