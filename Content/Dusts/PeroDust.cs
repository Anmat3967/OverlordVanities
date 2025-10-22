using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace OverlordVanities.Content.Dusts
{	
	public class PeroDust : ModDust
	{
		public override void OnSpawn(Dust dust)
		{
			dust.noGravity = true;
			dust.noLight = true;
		}

		public override bool Update(Dust dust)
		{
			dust.position += dust.velocity;
			dust.rotation += 0.1f;
			dust.velocity *= 0.84f;
			dust.alpha += 5;
			ReduceScale(dust);
			GetAlpha(dust, dust.color * 0.5f);
			return false;
		}

		protected virtual void ReduceScale(Dust dust)
		{
			dust.scale *= 0.98f;
			if (dust.scale < 0.5f)
			{
				dust.active = false;
			}
		}

		public override Color? GetAlpha(Dust dust, Color lightColor)
		{
			return dust.color * ((255 - dust.alpha) / 255f);
		}
	}
}
