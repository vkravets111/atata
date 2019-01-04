﻿using Atata;
using Atata.Bootstrap;

namespace PhpTravels.UITests.Components
{
    using _ = HotelsPage;

    [Url("/hotels")]
    [WaitForElement(WaitBy.Css, "div.pace-active", Until.VisibleThenMissingOrHidden, TriggerEvents.Init)]
    public class HotelsPage : Page<_>
    {
        public Button<HotelEditPage, _> Add { get; private set; }

        



        [FindByClass("xcrud-list")]
        public Table<HotelRow, _> Hotels { get; private set; }

        public class HotelRow : TableRow<_>
        {
            public Text<_> Name { get; private set; }

            public Text<_> Location { get; private set; }

            [FindByClass("fa fa-edit")]
            public Clickable<HotelEditPage, _> Edit { get; private set; }

        }

       
    }
}
