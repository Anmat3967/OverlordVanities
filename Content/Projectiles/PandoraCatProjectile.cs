using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using OverlordVanities.Content.Buffs;

namespace OverlordVanities.Content.Projectiles
{
    public class PandoraCatProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 11;
            Main.projPet[Projectile.type] = true;
            ProjectileID.Sets.TrailingMode[Projectile.type] = 319;
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.BlackCat);
            Projectile.width = 38;
            Projectile.height = 40;
            AIType = ProjectileID.BlackCat;
        }

        public override bool PreAI()
        {
            Player player = Main.player[Projectile.owner];
            player.blackCat = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            if (!player.dead && player.HasBuff(ModContent.BuffType<PandoraCatBuff>()))
            {
                Projectile.timeLeft = 2;
            }
        }
    }
}
