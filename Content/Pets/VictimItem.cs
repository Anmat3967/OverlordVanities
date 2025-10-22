using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using OverlordVanities.Content.Buffs;
using OverlordVanities.Content.Projectiles;

namespace OverlordVanities.Content.Pets
{
	public class VictimItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.ZephyrFish);
			Item.width = 20;
			Item.height = 16;
			Item.rare = 3;
			Item.value = Item.sellPrice(gold: 3);
			Item.shoot = ModContent.ProjectileType<VictimProjectile>();
			Item.buffType = ModContent.BuffType<VictimBuff>();
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
			recipe.AddIngredient(ItemID.Wood, 15);
			recipe.AddIngredient(ItemID.BrightSilverDye, 1);
			recipe.AddIngredient(ItemID.TissueSample, 15);
			recipe.AddIngredient(ItemID.CrimsonHeart, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.Register();
		}
	}

}