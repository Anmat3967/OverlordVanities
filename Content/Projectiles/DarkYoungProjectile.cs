using OverlordVanities.Content.Buffs;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace OverlordVanities.Content.Projectiles
{
    public class DarkYoungProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 14;
            Main.projPet[Projectile.type] = true;
            ProjectileID.Sets.TrailingMode[Projectile.type] = 900;
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.DD2OgrePet);
            Projectile.width = 58;
            Projectile.height = 74;
            AIType = ProjectileID.DD2OgrePet;
        }

        public override bool PreAI()
        {
            Player player = Main.player[Projectile.owner];
            player.petFlagDD2OgrePet = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            if (!player.dead && player.HasBuff(ModContent.BuffType<DarkYoungBuff>()))
            {
                Projectile.timeLeft = 2;
            }
        }
    }
}
