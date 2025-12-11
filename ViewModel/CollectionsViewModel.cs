using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class CollectionsMenuViewModel : ObservableObject
    {
        // Title shown at the top
        public string Title => "Collections Menu";

        // Button Text Properties
        public string Collection => "Collection";
        public string Images => "Images";
        public string Buttons => "Buttons";
        public string Icons => "Icons";
        public string Extras => "Extras";

        // Commands
        public IRelayCommand CollectionClickedCommand { get; }
        public IRelayCommand ImagesClickedCommand { get; }
        public IRelayCommand ButtonsClickedCommand { get; }
        public IRelayCommand IconsClickedCommand { get; }
        public IRelayCommand ExtrasClickedCommand { get; }

        public CollectionsMenuViewModel()
        {
            CollectionClickedCommand = new RelayCommand(OnCollectionClicked);
            ImagesClickedCommand = new RelayCommand(OnImagesClicked);
            ButtonsClickedCommand = new RelayCommand(OnButtonsClicked);
            IconsClickedCommand = new RelayCommand(OnIconsClicked);
            ExtrasClickedCommand = new RelayCommand(OnExtrasClicked);
        }

        void OnCollectionClicked() { }
        void OnImagesClicked() { }
        void OnButtonsClicked() { }
        void OnIconsClicked() { }
        void OnExtrasClicked() { }
    }
}
