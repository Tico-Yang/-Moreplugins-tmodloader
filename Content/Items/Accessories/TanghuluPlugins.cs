using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Moreplugins.Content.Players;

namespace Moreplugins.Content.Items.Accessories
{
    /// <summary>
    /// Tanghulu饰品 - 冰糖葫芦
    /// </summary>
    internal class TanghuluPlugins : BasicPlugins
    {

        #region 基础属性配置
        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Red; // 红色稀有度
            Item.value = Item.sellPrice(gold: 25); // 售价25金币
            base.SetDefaults();
        }
        #endregion

        #region 核心饰品效果
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            player.statLifeMax2 += 400;
            player.statDefense /= 2;
        }
        #endregion
    }
}