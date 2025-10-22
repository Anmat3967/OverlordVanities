using System;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using OverlordVanities.Content.Buffs;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using ReLogic.Content;

namespace OverlordVanities.Content.Projectiles
{
    public class SOAOGProjectile : ModProjectile
    {
        private const int frameStart = 0;
        private const int frameDelay = 15;
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
            Projectile.height = 46;
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
            if (player.dead || !player.HasBuff(ModContent.BuffType<SOAOGBuff>()))
            {
                Projectile.Kill();
                Projectile.netUpdate = true;
                return;
            }
            Projectile.timeLeft = 2;
            int extraX = player.direction * 24;
            float bobY = (float)Math.Sin(Main.timeForVisualEffects / 20) * 4f;
            float extraY = 10 + bobY;
            Vector2 targetPosition = new Vector2(player.Center.X + extraX, player.Center.Y - extraY);
            Vector2 vectorToTarget = targetPosition - Projectile.position;
            float distance = vectorToTarget.Length();
            vectorToTarget.Normalize();
            float maxDistance = distance > 2000f ? 30f : 15f;
            vectorToTarget *= Math.Clamp(distance, 0f, maxDistance);
            Projectile.velocity = vectorToTarget;
            Projectile.spriteDirection = player.direction;
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
            Texture2D textureValue = texture.Value;
            int width = textureValue.Width;
            int rectHeight = textureValue.Height / Main.projFrames[Projectile.type];
            Vector2 origin = new Vector2(width, rectHeight) * 0.5f;
            Rectangle source = new Rectangle(0, rectHeight * Projectile.frame, textureValue.Width, rectHeight);
            SpriteEffects effects = SpriteEffects.None;
            if (Projectile.spriteDirection == -1)
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
