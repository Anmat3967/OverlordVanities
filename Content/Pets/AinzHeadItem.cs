using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using OverlordVanities.Content.Projectiles;
using OverlordVanities.Content.Buffs;

namespace OverlordVanities.Content.Pets
{
	public class AinzHeadItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.ZephyrFish);
			Item.width = 14;
			Item.height = 16;
			Item.rare = 3;
			Item.shoot = ModContent.ProjectileType<AinzHeadProjectile>();
			Item.buffType = ModContent.BuffType<AinzHeadBuff>();
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
			recipe.AddIngredient(ItemID.GoldCoin, 5);
			recipe.AddIngredient(ItemID.Bone, 50);
			recipe.AddTile(TileID.DemonAltar);
			recipe.Register();
		}
	}
}