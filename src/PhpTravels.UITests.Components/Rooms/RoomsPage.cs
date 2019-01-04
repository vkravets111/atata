﻿using Atata;

namespace PhpTravels.UITests.Components.Hotels
{
    using _ = RoomsPage;


    [Url("/hotels/rooms")]
    [WaitForElement(WaitBy.Css, "div.pace-active", Until.VisibleThenMissingOrHidden, TriggerEvents.Init)]
    public class RoomsPage : Page<_>
    {
        public Button<RoomsEditPage, _> Add { get; private set; }

        [FindByClass("xcrud-list")]
        public Table<RoomsRow, _> Rooms { get; private set; }

        public class RoomsRow : TableRow<_>
        {
            public Text<_> RoomType { get; private set; }

            public Text<_> Hotel { get; private set; }

            public Text<_> Price { get; private set; }




        }
    }
}
