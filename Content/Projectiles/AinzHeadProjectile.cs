using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using OverlordVanities.Content.Buffs;

namespace OverlordVanities.Content.Projectiles
{
    public class AinzHeadProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 1;
            Main.projPet[Projectile.type] = true;
            ProjectileID.Sets.TrailingMode[Projectile.type] = 197;
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.BabySkeletronHead);
            Projectile.width = 42;
            Projectile.height = 60;
            AIType = ProjectileID.BabySkeletronHead;
        }

        public override bool PreAI()
        {
            Player player = Main.player[Projectile.owner];
            player.skeletron = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            if (!player.dead && player.HasBuff(ModContent.BuffType<AinzHeadBuff>()))
            {
                Projectile.timeLeft = 2;
            }
        }
    }
}
