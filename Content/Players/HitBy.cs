using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace Moreplugins.Content.Players
{
    public partial class PluginPlayer : ModPlayer
    {
        public override void OnHitByNPC(NPC npc, Player.HurtInfo hurtInfo)
        {
            if (thornEquipped)
            {
                // 敌人攻击时会受到3倍其造成的伤害
                NPC.HitInfo hitInfo = new NPC.HitInfo();
                hitInfo.Damage = hurtInfo.Damage * 3; // 3倍伤害
                npc.StrikeNPC(hitInfo);
            }
        }
        public override void OnHitByProjectile(Projectile projectile, Player.HurtInfo hurtInfo)
        {
            if (thornEquipped && projectile.hostile)
            {
                // 敌人攻击时会受到3倍其造成的伤害
                if (projectile.owner < 255) // 确保是敌怪发射的弹幕
                {
                    NPC npc = Main.npc[projectile.owner];
                    if (npc.active)
                    {
                        NPC.HitInfo hitInfo = new NPC.HitInfo();
                        hitInfo.Damage = hurtInfo.Damage * 3; // 3倍伤害
                        npc.StrikeNPC(hitInfo);
                    }
                }
            }
        }

    }
    }
