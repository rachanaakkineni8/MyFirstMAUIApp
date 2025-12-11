using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Model.Titles;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class CollectionGOGwImagesViewModel : ObservableObject
    {
        private List<Models.Entities.GOGCharacters> _gogCharacters;

        // This will be bound to the Page Title
        public string Title => TitleGOG.Title;

        // ItemsSource for the CollectionView
        public ObservableCollection<Models.Entities.GOGCharacters> GOGCharactersCollection { get; } = new();

        public CollectionGOGwImagesViewModel()
        {
            _gogCharacters = Models.Entities.GOGCharacters.GetCharacter();
            LoadCharacters();
        }

        private void LoadCharacters()
        {
            try
            {
                GOGCharactersCollection.Clear();

                foreach (var character in _gogCharacters)
                {
                    // Copy over properties (you *could* also add character directly)
                    GOGCharactersCollection.Add(new Models.Entities.GOGCharacters
                    {
                        NameofCharacter = character.NameofCharacter,
                        NameofActor = character.NameofActor,
                        ImagePath = character.ImagePath
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}

