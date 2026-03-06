using Terraria;
using Terraria.ID;

namespace Moreplugins.Content.Items.Accessories
{
    internal class EyePlugins : BasicPlugins
    {
        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.sellPrice(gold: 5);
            base.SetDefaults();    
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            player.AddBuff(BuffID.NightOwl, 2);
            Lighting.AddLight(player.Center, TorchID.UltraBright);
        }
    }
}
