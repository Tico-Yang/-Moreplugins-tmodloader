using Terraria;
using Terraria.ID;
using Moreplugins.Content.Players;
using Moreplugins.Core.Utilities;

namespace Moreplugins.Content.Items.Accessories
{
    /// <summary>
    /// Shaman饰品 - 萨满
    /// </summary>
    internal class ShamanPlugins : BasicPlugins
    {
        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Purple;
            Item.value = Item.sellPrice(gold: 30);
            base.SetDefaults();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            player.MPPlayer().shamanEquipped = true;
        }
    }
}