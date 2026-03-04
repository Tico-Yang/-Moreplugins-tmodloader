using Terraria;
using Terraria.ID;
using Moreplugins.Content.Players;
using Moreplugins.Core.Utilities;

namespace Moreplugins.Content.Items.Accessories
{
    /// <summary>
    /// Giantfist饰品 - 巨人之拳
    /// </summary>
    internal class GiantfistPlugins : BasicPlugins
    {
        public override void SetDefaults()
        { 
            Item.rare = ItemRarityID.Red;
            Item.value = Item.sellPrice(gold: 50);
            base.SetDefaults();    
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            player.MPPlayer().giantfistEquipped = true;
        }
    }
}