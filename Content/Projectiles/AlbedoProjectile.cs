using OverlordVanities.Content.Buffs;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace OverlordVanities.Content.Projectiles
{
    public class AlbedoProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 16;
            Main.projPet[Projectile.type] = true;
            ProjectileID.Sets.TrailingMode[Projectile.type] = 898;
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.IceQueenPet);
            Projectile.width = 58;
            Projectile.height = 74;
            AIType = ProjectileID.IceQueenPet;
        }

        public override bool PreAI()
        {
            Player player = Main.player[Projectile.owner];
            player.petFlagIceQueenPet = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            if (!player.dead && player.HasBuff(ModContent.BuffType<AlbedoBuff>()))
            {
                Projectile.timeLeft = 2;
            }
        }
    }
}
