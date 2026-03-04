using Terraria;
using Terraria.ID;
using Moreplugins.Content.Players;
using Moreplugins.Core.Utilities;


namespace Moreplugins.Content.Items.Accessories
{
    /// <summary>
    /// Bud饰品 - 花苞
    /// </summary>
    internal class BudPlugins : BasicPlugins

    {
        public override void SetDefaults()
        { 
            Item.rare = ItemRarityID.Pink; // 粉色稀有度
            Item.value = Item.sellPrice(gold: 15); // 售价15金币
            base.SetDefaults();
        }
        public override void AddRecipes()
        {
            // 可以添加合成配方，或者只作为掉落物品
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            // 标记饰品已装备
            player.MPPlayer().budEquipped = true;
        }
    }
}