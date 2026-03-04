using Moreplugins.Content.Players;
using Terraria;

namespace Moreplugins.Core.Utilities
{
    public static partial class MPUtils
    {
        public static PluginsPlayer MPPlayer(this Player player)
        {
            return player.GetModPlayer<PluginsPlayer>();
        }
    }
}
