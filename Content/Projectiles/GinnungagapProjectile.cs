using System;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using OverlordVanities.Content.Buffs;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using ReLogic.Content;

namespace OverlordVanities.Content.Projectiles
{
    public class GinnungagapProjectile : ModProjectile
    {
        private const int frameStart = 0;
        private const int frameDelay = 8;
        private static Asset<Texture2D> texture;
        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 4;
            Main.projPet[Projectile.type] = true;
            texture = ModContent.Request<Texture2D>(Texture);
        }

        public override void SetDefaults()
        {
            Projectile.width = 20;
            Projectile.height = 54;
            Projectile.aiStyle = 0;
            Projectile.noEnchantmentVisuals = true;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.ignoreWater = true;
            Projectile.timeLeft = 10;
            Projectile.scale = 1f;
            Projectile.light = 0f;
            Projectile.penetrate = -1;
            //Projectile.CloneDefaults(ProjectileID.ZephyrFish);
            Projectile.tileCollide = false;
            AIType = 0;
        }

        public override bool PreAI()
        {
            return true;
        }
        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            if (player.dead || !player.HasBuff(ModContent.BuffType<GinnungagapBuff>()))
            {
                Projectile.Kill();
                Projectile.netUpdate = true;
                return;
            }
            Projectile.timeLeft = 2;
            int xDistance = 24;
            if (player.HasBuff(ModContent.BuffType<SOAOGBuff>()))
            {
                if (player.HasBuff(BuffID.StardustGuardianMinion) || player.HasBuff(ModContent.BuffType<CocytusBuff>()))
                {
                    xDistance = 48;
                }
                else
                {
                    xDistance = -30;
                }
            }
            int extraX = player.direction * xDistance;
            float bobY = (float)Math.Sin(Main.timeForVisualEffects / 20d + Math.PI) * 4f;
            float extraY = 16 + bobY;
            Vector2 targetPosition = new Vector2(player.Center.X + extraX, player.Center.Y - extraY);
            Vector2 vectorToTarget = targetPosition - Projectile.position;
            float distance = vectorToTarget.Length();
            vectorToTarget.Normalize();
            float maxDistance = distance > 2000f ? 30f : 15f;
            vectorToTarget *= Math.Clamp(distance, 0f, maxDistance);
            Projectile.velocity = vectorToTarget;

            Projectile.frameCounter++;
            if (Projectile.frameCounter > frameDelay)
            {
                Projectile.frameCounter = 0;
                Projectile.frame++;
            }
            if (Projectile.frame < frameStart || Projectile.frame >= frameStart + Main.projFrames[Projectile.type])
            {
                Projectile.frame = frameStart;
            }
            Projectile.rotation = 0f;
            Projectile.netUpdate = true;
        }
        public override bool PreDraw(ref Color lightColor)
        {
            Player player = Main.player[Projectile.owner];
            Texture2D textureValue = texture.Value;
            int width = textureValue.Width;
            int rectHeight = textureValue.Height / Main.projFrames[Projectile.type];
            Vector2 origin = new Vector2(width, rectHeight) * 0.5f;
            Rectangle source = new Rectangle(0, rectHeight * Projectile.frame, textureValue.Width, rectHeight);
            SpriteEffects effects = SpriteEffects.None;
            if (player.direction == -1)
            {
                effects |= SpriteEffects.FlipHorizontally;
            }
            DrawData drawData = new DrawData(textureValue,
                Projectile.position - Main.screenPosition,
                source,
                Color.White,
                Projectile.rotation,
                origin,
                Projectile.scale,
                effects,
                0);
            Main.EntitySpriteDraw(drawData);
            return false;
        }
    }
}
