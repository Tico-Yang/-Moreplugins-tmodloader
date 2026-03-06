using Moreplugins.Content.Players;
using Moreplugins.Core.Utilities;
using Terraria;
using Terraria.ID;

namespace Moreplugins.Content.Items.Accessories
{
    /// <summary>
    /// Meatball饰品 - 肉球
    /// </summary>
    public class MeatballPlugins : BasicPlugins
    {
        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Red;
            Item.value = Item.sellPrice(gold: 30);
            base.SetDefaults();    
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            player.MPPlayer().meatballEquipped = true;
        }
    }
}
