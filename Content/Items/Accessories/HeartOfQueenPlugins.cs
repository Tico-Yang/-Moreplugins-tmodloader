using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace Moreplugins.Content.Items.Accessories
{
    public class HeartOfQueenPlugins : BasicPlugins
    {
        public override void SetStaticDefaults()
        {
            Terraria.GameContent.Creative.CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.value = Item.sellPrice(gold: 1);
            Item.expert = true;
            base.SetDefaults();    
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            Lighting.AddLight(player.Center, Main.DiscoColor.ToVector3() / 2);
            Lighting.AddLight(player.Center, Color.White.ToVector3() / 5);
        }

        public override void UpdateVanity(Player player)
        {
            Lighting.AddLight(player.Center, Main.DiscoColor.ToVector3() / 2);
            Lighting.AddLight(player.Center, Color.White.ToVector3() / 5);
        }
    }
}
