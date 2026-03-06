using Moreplugins.Content.Players;
using Moreplugins.Core.Utilities;
using Terraria;
using Terraria.ID;

namespace Moreplugins.Content.Items.Accessories
{
    internal class DetonatorPlugins : BasicPlugins
    {
        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.buyPrice(gold: 15);
            base.SetDefaults();
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            // 标记饰品已装备
            base.UpdateAccessory(player, hideVisual);
            player.MPPlayer().detonatorPluginsEquipped = true;
        }
    }
}