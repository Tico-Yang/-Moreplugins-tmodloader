using Terraria;
using Terraria.ID;
using Moreplugins.Content.Players;
using Moreplugins.Core.Utilities;
namespace Moreplugins.Content.Items.Accessories
{
    /// <summary>
    /// Disco饰品 - 迪斯科棱晶
    /// </summary>
    internal class DiscoPlugins : BasicPlugins
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Red;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            player.MPPlayer().discoEquipped = true;
            player.maxTurrets += 1; // 增加一哨兵栏位
        }
    }
}