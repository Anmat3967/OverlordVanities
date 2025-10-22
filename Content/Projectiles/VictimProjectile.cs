using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using OverlordVanities.Content.Buffs;

namespace OverlordVanities.Content.Projectiles
{
    public class VictimProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Angel");
            Main.projFrames[Projectile.type] = 8;
            Main.projPet[Projectile.type] = true;
            ProjectileID.Sets.TrailingMode[Projectile.type] = 702;
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.DD2PetGato);
            Projectile.width = 32;
            Projectile.height = 42;
            AIType = ProjectileID.DD2PetGato;
        }

        public override bool PreAI()
        {
            Player player = Main.player[Projectile.owner];
            player.petFlagDD2Gato = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            if (!player.dead && player.HasBuff(ModContent.BuffType<VictimBuff>()))
            {
                Projectile.timeLeft = 2;
            }
        }
    }
}
