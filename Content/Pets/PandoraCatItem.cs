using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using OverlordVanities.Content.Buffs;
using OverlordVanities.Content.Projectiles;

namespace OverlordVanities.Content.Pets
{
	public class PandoraCatItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.ZephyrFish);
			Item.width = 20;
			Item.height = 32;
			Item.rare = 3;
			Item.shoot = ModContent.ProjectileType<PandoraCatProjectile>();
			Item.buffType = ModContent.BuffType<PandoraCatBuff>();
		}

		public override void UseStyle(Player player, Rectangle heldItemFrame)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(Item.buffType, 3600);
			}
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.RedAdmiralButterfly, 1);
			recipe.AddIngredient(ItemID.GoldBar, 15);
			recipe.AddIngredient(ItemID.Silk, 15);
			recipe.AddTile(TileID.DemonAltar);
			recipe.Register();
		}
	}
}