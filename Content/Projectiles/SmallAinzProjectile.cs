using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using OverlordVanities.Content.Buffs;

namespace OverlordVanities.Content.Projectiles
{
    public class SmallAinzProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 16;
            Main.projPet[Projectile.type] = true;
            ProjectileID.Sets.TrailingMode[Projectile.type] = 896;
            ProjectileID.Sets.LightPet[Projectile.type] = true;
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.PumpkingPet);
            Projectile.width = 36;
            Projectile.height = 52;
            AIType = ProjectileID.PumpkingPet;
        }

        public override bool PreAI()
        {
            Player player = Main.player[Projectile.owner];
            player.petFlagPumpkingPet = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            if (!player.dead && player.HasBuff(ModContent.BuffType<SmallAinzBuff>()))
            {
                Projectile.timeLeft = 2;
            }
        }
    }
}
