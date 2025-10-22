using OverlordVanities.Content.Projectiles;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace OverlordVanities.Content.Buffs
{
    public class SOAOGBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoTimeDisplay[Type] = true;
            //Main.projPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            int projType = ModContent.ProjectileType<SOAOGProjectile>();

            if (player.whoAmI == Main.myPlayer && player.ownedProjectileCounts[projType] <= 0)
            {
                var entitySource = player.GetSource_Buff(buffIndex);

                Projectile.NewProjectile(entitySource, player.Center, Vector2.Zero, projType, 0, 0f, player.whoAmI);
            }
        }
    }
}
