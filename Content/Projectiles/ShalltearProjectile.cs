using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using OverlordVanities.Content.Buffs;

namespace OverlordVanities.Content.Projectiles
{
    public class ShalltearProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 6;
            Main.projPet[Projectile.type] = true;
            ProjectileID.Sets.TrailingMode[Projectile.type] = 895;
            ProjectileID.Sets.LightPet[Projectile.type] = true;
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.FairyQueenPet);
            Projectile.width = 40;
            Projectile.height = 48;
            AIType = ProjectileID.FairyQueenPet;
        }

        public override bool PreAI()
        {
            Player player = Main.player[Projectile.owner];
            player.petFlagFairyQueenPet = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            if (!player.dead && player.HasBuff(ModContent.BuffType<ShalltearBuff>()))
            {
                Projectile.timeLeft = 2;
            }
        }
    }
}
