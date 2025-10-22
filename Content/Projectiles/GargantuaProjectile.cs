using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using OverlordVanities.Content.Buffs;

namespace OverlordVanities.Content.Projectiles
{
    public class GargantuaProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 15;
            Main.projPet[Projectile.type] = true;
            ProjectileID.Sets.LightPet[Projectile.type] = true;
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.GolemPet);
            Projectile.width = 36;
            Projectile.height = 38;
            AIType = ProjectileID.GolemPet;
        }
        public override bool PreAI()
        {
            Player player = Main.player[Projectile.owner];
            player.petFlagGolemPet = false;
            return true;
        }
        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            //AI_026();
            if (!player.dead && player.HasBuff(ModContent.BuffType<GargantuaBuff>()))
            {
                Projectile.timeLeft = 2;
            }
        }
 
        //private void AI_026()
        //{
        //    // all I could find relating to golempet ai, haven't made any changes as far as I remember.        
        //    if (!Main.player[Projectile.owner].active)
        //    {
        //        Projectile.active = false;
        //        return;
        //    }
        //    bool flag2 = false;
        //    bool flag3 = false;
        //    bool flag4 = false;
        //    bool flag5 = false;
        //    int num = 85;
        //    num = 95;
        //    bool flag7 = Projectile.ai[0] == -1f || Projectile.ai[0] == -2f;
        //    bool num2 = Projectile.ai[0] == -1f;
        //    bool flag8 = Projectile.ai[0] == -2f;
        //    if (Main.player[Projectile.owner].dead)
        //    {
        //        Main.player[Projectile.owner].petFlagGolemPet = false;
        //    }
        //    if (Main.player[Projectile.owner].petFlagGolemPet)
        //    {
        //        Projectile.timeLeft = 2;
        //    }
        //    if (flag7)
        //    {
        //        Projectile.timeLeft = 2;
        //    }
        //    num = 30;
        //    float num4 = -50 * -Main.player[Projectile.owner].direction;
        //    float num5 = Main.player[Projectile.owner].Center.X + num4;
        //    if (num5 < Projectile.position.X + (float)(Projectile.width / 2) - (float)num)
        //    {
        //        flag2 = true;
        //    }
        //    else if (num5 > Projectile.position.X + (float)(Projectile.width / 2) + (float)num)
        //    {
        //        flag3 = true;
        //    }
        //    else if (Main.player[Projectile.owner].position.X + (float)(Main.player[Projectile.owner].width / 2) < Projectile.position.X + (float)(Projectile.width / 2) - (float)num)
        //    {
        //        flag2 = true;
        //    }
        //    else if (Main.player[Projectile.owner].position.X + (float)(Main.player[Projectile.owner].width / 2) > Projectile.position.X + (float)(Projectile.width / 2) + (float)num)
        //    {
        //        flag3 = true;
        //    }
        //    if (num2)
        //    {
        //        flag2 = false;
        //        flag3 = true;
        //        num = 30;
        //    }
        //    if (flag8)
        //    {
        //        flag2 = false;
        //        flag3 = false;
        //    }
        //    bool flag10 = Projectile.ai[1] == 0f;
        //    if (flag10)
        //    {
        //        int num77 = 400;
        //        if (Main.player[Projectile.owner].rocketDelay2 > 0)
        //        {
        //            Projectile.ai[0] = 1f;
        //        }
        //        Vector2 vector7 = new Vector2(Projectile.position.X + (float)Projectile.width * 0.5f, Projectile.position.Y + (float)Projectile.height * 0.5f);
        //        float num78 = Main.player[Projectile.owner].position.X + (float)(Main.player[Projectile.owner].width / 2) - vector7.X;
        //        float num79 = Main.player[Projectile.owner].position.Y + (float)(Main.player[Projectile.owner].height / 2) - vector7.Y;
        //        float num80 = (float)Math.Sqrt(num78 * num78 + num79 * num79);
        //        if (!flag7)
        //        {
        //            if (num80 > 2000f)
        //            {
        //                Projectile.position.X = Main.player[Projectile.owner].position.X + (float)(Main.player[Projectile.owner].width / 2) - (float)(Projectile.width / 2);
        //                Projectile.position.Y = Main.player[Projectile.owner].position.Y + (float)(Main.player[Projectile.owner].height / 2) - (float)(Projectile.height / 2);
        //            }
        //            else if (num80 > (float)num77 || (Math.Abs(num79) > 300f && !(Projectile.localAI[0] > 0f)))
        //            {
        //                if (num79 > 0f && Projectile.velocity.Y < 0f)
        //                {
        //                    Projectile.velocity.Y = 0f;
        //                }
        //                if (num79 < 0f && Projectile.velocity.Y > 0f)
        //                {
        //                    Projectile.velocity.Y = 0f;
        //                }
        //                Projectile.ai[0] = 1f;
        //            }
        //        }
        //    }
        //    else if (Projectile.ai[0] != 0f && !flag7)
        //    {
        //        float num82 = 0.2f;
        //        int num83 = 200;
        //        Projectile.tileCollide = false;
        //        Vector2 vector8 = new Vector2(Projectile.position.X + (float)Projectile.width * 0.5f, Projectile.position.Y + (float)Projectile.height * 0.5f);
        //        float num84 = Main.player[Projectile.owner].position.X + (float)(Main.player[Projectile.owner].width / 2) - vector8.X;
        //        float num90 = Main.player[Projectile.owner].position.Y + (float)(Main.player[Projectile.owner].height / 2) - vector8.Y;
        //        float num91 = (float)Math.Sqrt(num84 * num84 + num90 * num90);
        //        float num92 = num91;
        //        float num93 = 10f;
        //        if (num91 < (float)num83 && Main.player[Projectile.owner].velocity.Y == 0f && Projectile.position.Y + (float)Projectile.height <= Main.player[Projectile.owner].position.Y + (float)Main.player[Projectile.owner].height && !Collision.SolidCollision(Projectile.position, Projectile.width, Projectile.height))
        //        {
        //            Projectile.ai[0] = 0f;
        //            if (Projectile.velocity.Y < -6f)
        //            {
        //                Projectile.velocity.Y = -6f;
        //            }
        //        }
        //        if (num91 < 60f)
        //        {
        //            num84 = Projectile.velocity.X;
        //            num90 = Projectile.velocity.Y;
        //        }
        //        else
        //        {
        //            num91 = num93 / num91;
        //            num84 *= num91;
        //            num90 *= num91;
        //        }
        //        if (Projectile.velocity.X < num84)
        //        {
        //            Projectile.velocity.X += num82;
        //            if (Projectile.velocity.X < 0f)
        //            {
        //                Projectile.velocity.X += num82 * 1.5f;
        //            }
        //        }
        //        if (Projectile.velocity.X > num84)
        //        {
        //            Projectile.velocity.X -= num82;
        //            if (Projectile.velocity.X > 0f)
        //            {
        //                Projectile.velocity.X -= num82 * 1.5f;
        //            }
        //        }
        //        if (Projectile.velocity.Y < num90)
        //        {
        //            Projectile.velocity.Y += num82;
        //            if (Projectile.velocity.Y < 0f)
        //            {
        //                Projectile.velocity.Y += num82 * 1.5f;
        //            }
        //        }
        //        if (Projectile.velocity.Y > num90)
        //        {
        //            Projectile.velocity.Y -= num82;
        //            if (Projectile.velocity.Y > 0f)
        //            {
        //                Projectile.velocity.Y -= num82 * 1.5f;
        //            }
        //        }
        //        if ((double)Projectile.velocity.X > 0.5)
        //        {
        //            Projectile.spriteDirection = -1;
        //        }
        //        else if ((double)Projectile.velocity.X < -0.5)
        //        {
        //            Projectile.spriteDirection = 1;
        //        }
        //        Projectile.spriteDirection = 1;
        //        Projectile.frameCounter++;
        //        if (Projectile.frame < 9)
        //        {
        //            Projectile.frame = 9;
        //            Projectile.frameCounter = 0;
        //        }
        //        if (Projectile.frameCounter > 3)
        //        {
        //            Projectile.frameCounter = 0;
        //            Projectile.frame++;
        //            if (Projectile.frame >= Main.projFrames[Projectile.type])
        //            {
        //                Projectile.frame = 9;
        //            }
        //        }
        //        Vector2 velocity3 = Projectile.velocity;
        //        velocity3.Normalize();
        //        Projectile.rotation = velocity3.ToRotation() + (float)Math.PI / 2f;
        //        if (Projectile.spriteDirection == -1)
        //        {
        //            Projectile.rotation = (float)Math.Atan2(Projectile.velocity.Y, Projectile.velocity.X);
        //        }
        //        else
        //        {
        //            Projectile.rotation = (float)Math.Atan2(Projectile.velocity.Y, Projectile.velocity.X) + 3.14f;
        //        }
        //    }
        //    else
        //    {
        //        Vector2 vector12 = Vector2.Zero;
        //        if (Projectile.ai[1] != 0f)
        //        {
        //            flag2 = false;
        //            flag3 = false;
        //        }
        //        Projectile.rotation = 0f;
        //        float num160 = 0.08f;
        //        float num161 = 6.5f;
        //        num161 = 6f;
        //        num160 = 0.2f;
        //        if (num161 < Math.Abs(Main.player[Projectile.owner].velocity.X) + Math.Abs(Main.player[Projectile.owner].velocity.Y))
        //        {
        //            num161 = Math.Abs(Main.player[Projectile.owner].velocity.X) + Math.Abs(Main.player[Projectile.owner].velocity.Y);
        //            num160 = 0.3f;
        //        }
        //        if (flag7)
        //        {
        //            num161 = 6f;
        //        }
        //        if (flag2)
        //        {
        //            if ((double)Projectile.velocity.X > -3.5)
        //            {
        //                Projectile.velocity.X -= num160;
        //            }
        //            else
        //            {
        //                Projectile.velocity.X -= num160 * 0.25f;
        //            }
        //        }
        //        else if (flag3)
        //        {
        //            if ((double)Projectile.velocity.X < 3.5)
        //            {
        //                Projectile.velocity.X += num160;
        //            }
        //            else
        //            {
        //                Projectile.velocity.X += num160 * 0.25f;
        //            }
        //        }
        //        else
        //        {
        //            Projectile.velocity.X *= 0.9f;
        //            if (Projectile.velocity.X >= 0f - num160 && Projectile.velocity.X <= num160)
        //            {
        //                Projectile.velocity.X = 0f;
        //            }
        //        }
        //        if (flag2 || flag3)
        //        {
        //            int num162 = (int)(Projectile.position.X + (float)(Projectile.width / 2)) / 16;
        //            int j2 = (int)(Projectile.position.Y + (float)(Projectile.height / 2)) / 16;
        //            if (flag2)
        //            {
        //                num162--;
        //            }
        //            if (flag3)
        //            {
        //                num162++;
        //            }
        //            num162 += (int)Projectile.velocity.X;
        //            if (WorldGen.SolidTile(num162, j2))
        //            {
        //                flag5 = true;
        //            }
        //        }
        //        if (Main.player[Projectile.owner].position.Y + (float)Main.player[Projectile.owner].height - 8f > Projectile.position.Y + (float)Projectile.height)
        //        {
        //            flag4 = true;
        //        }
        //        Collision.StepUp(ref Projectile.position, ref Projectile.velocity, Projectile.width, Projectile.height, ref Projectile.stepSpeed, ref Projectile.gfxOffY);
        //        if (Projectile.velocity.Y == 0f)
        //        {
        //            if (!flag4 && (Projectile.velocity.X < 0f || Projectile.velocity.X > 0f))
        //            {
        //                int num163 = (int)(Projectile.position.X + (float)(Projectile.width / 2)) / 16;
        //                int j3 = (int)(Projectile.position.Y + (float)(Projectile.height / 2)) / 16 + 1;
        //                if (flag2)
        //                {
        //                    num163--;
        //                }
        //                if (flag3)
        //                {
        //                    num163++;
        //                }
        //                WorldGen.SolidTile(num163, j3);
        //            }
        //            if (flag5)
        //            {
        //                int num164 = (int)(Projectile.position.X + (float)(Projectile.width / 2)) / 16;
        //                int num165 = (int)(Projectile.position.Y + (float)Projectile.height) / 16;
        //                if (WorldGen.SolidTileAllowBottomSlope(num164, num165))
        //                {
        //                    try
        //                    {
        //                        num164 = (int)(Projectile.position.X + (float)(Projectile.width / 2)) / 16;
        //                        num165 = (int)(Projectile.position.Y + (float)(Projectile.height / 2)) / 16;
        //                        if (flag2)
        //                        {
        //                            num164--;
        //                        }
        //                        if (flag3)
        //                        {
        //                            num164++;
        //                        }
        //                        num164 += (int)Projectile.velocity.X;
        //                        if (!WorldGen.SolidTile(num164, num165 - 1) && !WorldGen.SolidTile(num164, num165 - 2))
        //                        {
        //                            Projectile.velocity.Y = -5.1f;
        //                        }
        //                        else if (!WorldGen.SolidTile(num164, num165 - 2))
        //                        {
        //                            Projectile.velocity.Y = -7.1f;
        //                        }
        //                        else if (WorldGen.SolidTile(num164, num165 - 5))
        //                        {
        //                            Projectile.velocity.Y = -11.1f;
        //                        }
        //                        else if (WorldGen.SolidTile(num164, num165 - 4))
        //                        {
        //                            Projectile.velocity.Y = -10.1f;
        //                        }
        //                        else
        //                        {
        //                            Projectile.velocity.Y = -9.1f;
        //                        }
        //                    }
        //                    catch
        //                    {
        //                        Projectile.velocity.Y = -9.1f;
        //                    }
        //                }
        //            }
        //        }
        //        if (Projectile.velocity.X > num161)
        //        {
        //            Projectile.velocity.X = num161;
        //        }
        //        if (Projectile.velocity.X < 0f - num161)
        //        {
        //            Projectile.velocity.X = 0f - num161;
        //        }
        //        if (Projectile.velocity.X < 0f)
        //        {
        //            Projectile.direction = -1;
        //        }
        //        if (Projectile.velocity.X > 0f)
        //        {
        //            Projectile.direction = 1;
        //        }
        //        if (Projectile.velocity.X > num160 && flag3)
        //        {
        //            Projectile.direction = 1;
        //        }
        //        if (Projectile.velocity.X < 0f - num160 && flag2)
        //        {
        //            Projectile.direction = -1;
        //        }
        //        if (Projectile.direction == -1)
        //        {
        //            Projectile.spriteDirection = 1;
        //        }
        //        if (Projectile.direction == 1)
        //        {
        //            Projectile.spriteDirection = -1;
        //        }
        //        bool flag15 = Projectile.position.X - Projectile.oldPosition.X == 0f;
        //        Projectile.spriteDirection = Projectile.direction;
        //        if (Projectile.velocity.Y != 0f)
        //        {
        //            Projectile.frame = 1;
        //            Projectile.frameCounter = 0;
        //        }
        //        else if (flag15)
        //        {
        //            Projectile.spriteDirection = Main.player[Projectile.owner].direction;
        //            Projectile.frame = 0;
        //            Projectile.frameCounter = 0;
        //        }
        //        else
        //        {
        //            Projectile.frameCounter += 1 + (int)Math.Abs(Projectile.velocity.X * 0.3f);
        //            if (Projectile.frame < 2)
        //            {
        //                Projectile.frame = 2;
        //                Projectile.frameCounter = 0;
        //            }
        //            if (Projectile.frameCounter > 4)
        //            {
        //                Projectile.frame++;
        //                Projectile.frameCounter = 0;
        //            }
        //            if (Projectile.frame > 8)
        //            {
        //                Projectile.frame = 2;
        //            }
        //        }
        //        Projectile.velocity.Y += 0.4f;
        //        if (Projectile.velocity.Y > 10f)
        //        {
        //            Projectile.velocity.Y = 10f;
        //        }
        //    }
        //    _ = Main.player[Projectile.owner];
        //    DelegateMethods.v3_1 = new Vector3(1f, 0.61f, 0.16f) * 1.5f;
        //    Utils.PlotTileLine(Projectile.Center, Projectile.Center + Projectile.velocity * 6f, 20f, DelegateMethods.CastLightOpen);
        //    Utils.PlotTileLine(Projectile.Left, Projectile.Right, 20f, DelegateMethods.CastLightOpen);
        //}
    }
}
