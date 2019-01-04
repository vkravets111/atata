using Atata;

namespace PhpTravels.UITests.Components.Hotels
{
    using _ = RoomsEditPage;


   public class RoomsEditPage : Page<_>
    {
        [FindById("s2id_autogen1")]
        public AutoCompleteSelect<_> RoomType { get; private set; }

        [FindByPlaceholder]
        public NumberInput<_> Price { get; private set; }

        public ButtonDelegate<RoomsPage, _> Submit { get; private set; }
    }
}
