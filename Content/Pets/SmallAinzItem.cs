using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using OverlordVanities.Content.Buffs;
using OverlordVanities.Content.Projectiles;

namespace OverlordVanities.Content.Pets
{
	public class SmallAinzItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.ZephyrFish);
			Item.width = 18;
			Item.height = 18;
			Item.rare = ItemRarityID.Pink;
			Item.shoot = ModContent.ProjectileType<SmallAinzProjectile>();
			Item.buffType = ModContent.BuffType<SmallAinzBuff>();
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
			recipe.AddIngredient(ItemID.SoulofNight, 10);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddIngredient(ItemID.Ruby, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}

}