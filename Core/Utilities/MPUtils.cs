using Moreplugins.Content.Players;
using Terraria;
using Terraria.ModLoader;

namespace Moreplugins.Core.Utilities
{
    public static partial class MPUtils
    {
        public static PluginPlayer MPPlayer(this Player player)
        {
            return player.GetModPlayer<PluginPlayer>();
        }
        public static bool HasProj<T>(this Player player, int count = 1) where T : ModProjectile => HasProj(player, ProjectileType<T>(), count);
        public static bool HasProj(this Player player, int type, int count = 1) => player.ownedProjectileCounts[type] >= count;
    }
}
