using Microsoft.Xna.Framework;
using Moreplugins.Content.Players;
using Moreplugins.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace Moreplugins.Content.Items.Accessories
{
    public class GingerbreadmanPlugins : BasicPlugins
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.value = Item.sellPrice(gold: 2);
            Item.rare = ItemRarityID.Pink;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            player.MPPlayer().gingerbreadmanPluginsEquipped = true;
        }
    }
}