using Terraria;
using Terraria.ID;

namespace Moreplugins.Content.Items.Accessories
{
    public class HandPlugins : BasicPlugins
    {

        public override void SetStaticDefaults()
        {
            // In tModLoader, display names and tooltips are set through localization files
            // For simplicity, we'll leave this empty and let the game use default names
        }

        public override void SetDefaults()
        {
            Item.value = Item.sellPrice(gold: 5);
            Item.rare = ItemRarityID.Pink;
            base.SetDefaults();    
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);

            if (Main.dayTime)
            {
                player.GetDamage(Terraria.ModLoader.DamageClass.Generic) += 0.5f; // Increase ALL player damage by 100%
            }
        }
    }
}