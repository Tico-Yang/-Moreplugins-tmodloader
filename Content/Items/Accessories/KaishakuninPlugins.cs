using Terraria;
using Terraria.ID;
using Moreplugins.Content.Players;
using Moreplugins.Core.Utilities;

namespace Moreplugins.Content.Items.Accessories
{
    /// <summary>
    /// Kaishakunin饰品
    /// </summary>
    public class KaishakuninPlugins : BasicPlugins
    {
        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Orange; // 橙色稀有度
            Item.value = Item.sellPrice(gold: 2); // 售价2金币
            base.SetDefaults();    
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Muramasa, 1)       // 村正
                .AddIngredient(ItemID.GoldBar, 5)        // 5个金锭
                .AddTile(TileID.Anvils)                 // 铁砧/铅砧合成
                .Register();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            player.MPPlayer().kaishakuninEquipped = true;
        }
    }
}