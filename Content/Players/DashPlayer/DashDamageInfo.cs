using Terraria.ModLoader;

namespace Moreplugins.Content.Players.DashPlayer
{
    public struct DashDamageInfo(int damage, float knockBack, DamageClass dc)
    {
        public int Damage = damage;
        public float KnockBack = knockBack;
        public DamageClass damageClass = dc;
    }
}
