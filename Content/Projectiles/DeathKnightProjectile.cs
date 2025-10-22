using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using OverlordVanities.Content.Buffs;

namespace OverlordVanities.Content.Projectiles
{
    public class DeathKnightProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 10;
            Main.projPet[Projectile.type] = true;
            ProjectileID.Sets.TrailingMode[Projectile.type] = 398;
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.MiniMinotaur);
            Projectile.width = 34;
            Projectile.height = 46;
            AIType = ProjectileID.MiniMinotaur;
        }

        public override bool PreAI()
        {
            Player player = Main.player[Projectile.owner];
            player.miniMinotaur = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            if (!player.dead && player.HasBuff(ModContent.BuffType<DeathKnightBuff>()))
            {
                Projectile.timeLeft = 2;
            }
        }
    }
}
