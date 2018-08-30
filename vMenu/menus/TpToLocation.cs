using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;
using NativeUI;
using System.Drawing; //added by me
using CitizenFX.Core.UI; //added by me

namespace vMenuClient
{
    public class TpToLocation
    {
        // Variables
        private UIMenu menu;
        private readonly CommonFunctions cf = MainMenu.Cf;

        /// <summary>
        /// Creates the menu.
        /// </summary>
        private void CreateMenu()
        {
            menu = new UIMenu("TP to Location", "Teleport to specific location on the maps.", true)
            {
                ScaleWithSafezone = false,
                MouseControlsEnabled = false,
                MouseEdgeEnabled = false,
                ControlDisablingEnabled = false
            };
            UIMenuItem addonMapsSubmenuBtn = new UIMenuItem("TP To Specific Location", "TP to a custom map or location.");
            UIMenuItem gotoAkinaTop = new UIMenuItem("Akina (Top)", "TP to the top of Akina mountain");
            UIMenuItem gotoAkinaBottom = new UIMenuItem("Akina (Bottom)", "TP to the bottom of Akina mountain");
            UIMenuItem gotoEbisuMinami = new UIMenuItem("Ebisu Minami", "TP to Ebisu Minami");
            UIMenuItem gotoKagarasanTop = new UIMenuItem("Kagarasan (Top)", "TP to the top of Kagarasan");
            UIMenuItem gotoKagarasanBottom = new UIMenuItem("Kagarasan (Bottom)", "TP to the bottom of Kagarasan");
            UIMenuItem gotoLakeside = new UIMenuItem("Lakeside", "TP to Lakeside");
            UIMenuItem gotoLakeTouge = new UIMenuItem("Lake Touge", "TP to Lake Touge");
            UIMenuItem gotoLookoutPoint = new UIMenuItem("Lookout Point", "TP to Lookout Point");
            UIMenuItem gotoMeihan = new UIMenuItem("Meihan", "TP to Meihan");
            menu.AddItem(gotoAkinaTop);
            menu.AddItem(gotoAkinaBottom);
            menu.AddItem(gotoEbisuMinami);
            menu.AddItem(gotoKagarasanTop);
            menu.AddItem(gotoKagarasanBottom);
            // menu.AddItem(gotoLakeside);
            menu.AddItem(gotoLakeTouge);
            menu.AddItem(gotoLookoutPoint);
            menu.AddItem(gotoMeihan);

            MainMenu.Mp.Add(menu);
            menu.RefreshIndex();
            menu.UpdateScaleform();
            menu.BindMenuToItem(menu, addonMapsSubmenuBtn);

            menu.OnItemSelect += (sender, item, index) =>
            {
                if (item == gotoAkinaTop)
                {
                    SetPedCoordsKeepVehicle(PlayerPedId(), -3278.43f, 4819.87f, 418.50f);
                }
                else if (item == gotoAkinaBottom)
                {
                    SetPedCoordsKeepVehicle(PlayerPedId(), -1089.38f, 6971.88f, 36.00f);
                }
                else if (item == gotoEbisuMinami)
                {
                    SetPedCoordsKeepVehicle(PlayerPedId(), -3553.5f, -4542.5f, 297.0f);
                }
                else if (item == gotoKagarasanTop)
                {
                    SetPedCoordsKeepVehicle(PlayerPedId(), -4157.0f, 4657.0f, 373.0f);
                }
                else if (item == gotoKagarasanBottom)
                {
                    SetPedCoordsKeepVehicle(PlayerPedId(), -3707.5f, 3434.5f, 50.0f);
                }
                else if (item == gotoLakeside)
                {
                    SetPedCoordsKeepVehicle(PlayerPedId(), 3161.94f, -1669.01f, 7.50f);
                }
                else if (item == gotoLakeTouge)
                {
                    SetPedCoordsKeepVehicle(PlayerPedId(), 1953.0f, 419.0f, 130.0f);
                }
                else if (item == gotoLookoutPoint)
                {
                    SetPedCoordsKeepVehicle(PlayerPedId(), -4921.0f, -983.0f, 492.0f);
                }
                else if (item == gotoMeihan)
                {
                    SetPedCoordsKeepVehicle(PlayerPedId(), -3229.8f, 2114.0f, 13.60f);
                }
            };

            // menu.AddItem(addonMapsSubmenuBtn);
        }

        public UIMenu GetMenu()
        {
            if (menu == null)
            {
                CreateMenu();
            }
            return menu;
        }
    }

}