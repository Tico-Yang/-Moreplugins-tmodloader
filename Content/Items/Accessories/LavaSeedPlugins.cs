using Terraria;
using Terraria.ID;
using Moreplugins.Content.Players;
using Moreplugins.Core.Utilities;

namespace Moreplugins.Content.Items.Accessories
{
    /// <summary>
    /// LavaSeed饰品
    /// </summary>
    public class LavaSeedPlugins : BasicPlugins
    {
        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Orange; // 橙色稀有度
            Item.value = Item.sellPrice(gold: 3); // 售价3金币
            base.SetDefaults();    
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.HellstoneBar, 10)        // 10个狱石锭
                .AddIngredient(ItemID.LavaBucket, 1)          // 1个岩浆桶
                .AddIngredient(ItemID.Fireblossom, 5)         // 5个火焰花
                .AddTile(TileID.Anvils)                      // 铁砧/铅砧合成
                .Register();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            // 提升5点防御
            player.statDefense += 5;

            // 提升5%的伤害减免
            player.endurance += 0.05f;

            // 标记饰品已装备
            player.MPPlayer().lavaSeedEquipped = true;
        }
    }
}