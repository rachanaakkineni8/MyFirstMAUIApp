using CommunityToolkit.Mvvm.Messaging.Messages;
using MyFirstMAUIApp.Models.Entities;

namespace MyFirstMAUIApp.Models.Messages
{
    public class UpdateMovieMessages: ValueChangedMessage<(MarvelMoviesModel OldValue, MarvelMoviesModel NewValue)>
    {
        public UpdateMovieMessages((MarvelMoviesModel oldValue, MarvelMoviesModel newValue)
            : base((oldValue, newValue)) { }

        public MarvelMoviesModel OldValue => Value.OldValue;
        public MarvelMoviesModel NewValue => Value.NewValue;

    }
}
