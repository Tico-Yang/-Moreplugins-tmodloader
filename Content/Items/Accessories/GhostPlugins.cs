using Terraria;
using Terraria.ID;
using Moreplugins.Content.Players;
using Moreplugins.Core.Utilities;


namespace Moreplugins.Content.Items.Accessories
{
    /// <summary>
    /// Ghost饰品 - 幽灵
    /// </summary>
    internal class GhostPlugins : BasicPlugins
    {
        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Pink;
            Item.value = Item.sellPrice(gold: 20);
            base.SetDefaults();    
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            player.MPPlayer().ghostEquipped = true;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.SpectreBar, 10)             // 10个幽灵锭
                .AddTile(TileID.MythrilAnvil)                    // 山铜/秘银砧合成
                .Register();
        }
    }
}