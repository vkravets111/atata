using Atata;
using NUnit.Framework;
using PhpTravels.UITests.Components;
using PhpTravels.UITests.Components.Hotels;

namespace PhpTravels.UITests
{
    public class HotelTests : UITestFixture
    {
        [Test]
        public void Hotel_Add()
        {
            LoginAsAdmin();

            Go.To<HotelsPage>().
                Add.ClickAndGo().
                    HotelName.SetRandom(out string name).
                    HotelDescription.SetRandom(out string description).
                    Location.Set("London").
                    Stars.Set(3).
                    HotelsTypeDropdown.Set(HotelEditPage.HotelType.Hotel).
                    FeaturedFrom.Set("02/02/2002").
                    FeaturedTo.Set("03/03/2003").
                    Submit().
                Hotels.Rows[x => x.Name == name].Should.BeVisible();
        }

        [Test]
        public void Hotel_Edit()
        {
            LoginAsAdmin();

            Go.To<HotelsPage>().
                Add.ClickAndGo().
                    HotelName.SetRandom(out string hotelName).
                    HotelDescription.SetRandom(out string description).
                    Location.Set("London").
                    Stars.Set(3).
                    HotelsTypeDropdown.Set(HotelEditPage.HotelType.Hotel).
                    FeaturedFrom.Set("02/02/2002").
                    FeaturedTo.Set("03/03/2003").
                    Submit().
                    Hotels.Rows[x => x.Name == hotelName].Edit.ClickAndGo().
                    Location.Set("Gawahati").
                    Submit().
                    Hotels.Rows[x => x.Name == hotelName].Location.Should.Contain("Gawahati");
        }

        [Test]
        public void Hotel_Room_Add()
        {
            LoginAsAdmin();

            Go.To<HotelsPage>().
                Add.ClickAndGo().
                    HotelName.SetRandom(out string hotelName).
                    HotelDescription.SetRandom(out string description).
                    Location.Set("London").
                    Stars.Set(3).
                    HotelsTypeDropdown.Set(HotelEditPage.HotelType.Hotel).
                    FeaturedFrom.Set("02/02/2002").
                    FeaturedTo.Set("03/03/2003").
                    Submit();

            Go.To<RoomsPage>().
                 Add.ClickAndGo().
                 RoomType.Set("Triple Rooms").
                 Price.Set(10).
                 Submit().
                Rooms.Rows[x => x.Hotel == hotelName].Price.Should.Contain("10").
                Rooms.Rows[x => x.Hotel == hotelName].RoomType.Should.Contain("Triple Rooms");

        }
    }
}
