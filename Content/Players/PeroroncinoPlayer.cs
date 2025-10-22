using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using OverlordVanities.Content.Dusts;
using System;
using OverlordVanities.Content.Projectiles;

namespace OverlordVanities.Content.Players
{
    public class PeroroncinoPlayer : ModPlayer
    {
        public bool IsActive;

        public override void ResetEffects()
        {
            IsActive = false;
        }
        public override void PostUpdate()
        {
            if (IsActive)
            {
                bool movingInYAxis = Math.Abs(Player.velocity.Y) > 0;
                bool movingInXAxis = Math.Abs(Player.velocity.X) > 0;
                if (!movingInYAxis && !movingInXAxis)
                {
                    return;
                }
                Vector2 position = Player.position;
                if (Player.velocity.Y < 0)
                {
                    position.Y += Player.height / 2f;
                }
                int width = movingInYAxis ? Player.width : 1;
                int height = movingInXAxis ? Player.height : 1;
                int type = ModContent.DustType<PeroDust>();
                Vector2 speed = Vector2.Zero;
                int alpha = 0;
                Color color = Color.White;
                float scale = 1.5f;
                Dust.NewDust(position, width, height, type, speed.X, speed.Y, alpha, color, scale);
            }
        }
    }
}
