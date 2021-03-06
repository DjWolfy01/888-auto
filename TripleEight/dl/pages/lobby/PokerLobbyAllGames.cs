﻿using com.tripleEigth.auto.dl.pages;
using com.tripleEigth.auto.infra.dl.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tripleEigth.auto.infra.dl.pages
{
    public class DnPokerLobbyAllGames : RanorexPageObject
    {
        public LobbyTabs tabs;
        public DnPokerLobbyAllGames(RanorexDriver driver) : base(driver)
        {
            rootLocator = getAppRefByName("MainWindowWin");
            tabs = new LobbyTabs(this);
        }
    }
}
