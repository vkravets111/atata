using Atata;
using Atata.Bootstrap;

namespace PhpTravels.UITests.Components
{
    using _ = HotelEditPage;

    public class HotelEditPage : Page<_>
    {
        [FindByName(TermCase.LowerMerged)]
        [RandomizeStringSettings("Kravets123 {0}")]
        public TextInput<_> HotelName { get; private set; }

        public RichTextEditor<_> HotelDescription { get; private set; }

        [FindByName("hoteltype")]
        public Select<HotelType, _> HotelsTypeDropdown { get; private set; }

        [FindByName("hotelstars")]
        [Format("{0}")]
        public Select<int, _> Stars { get; private set; }

        [FindByName("ffrom")]
        public TextInput<_> FeaturedFrom { get; private set; }

        [FindByName("fto")]
        public TextInput<_> FeaturedTo { get; private set; }

        [FindById("s2id_searching")]
        public AutoCompleteSelect<_> Location { get; private set; }

        public ButtonDelegate<HotelsPage, _> Submit { get; private set; }


        public enum HotelType
        {
            [Term("Select")]
            Apartment,
            Hotel
        }
    }
}
