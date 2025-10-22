using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace OverlordVanities.Content.Items.Placeable
{
	public class ShallChair : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Vampire Chair");
			// Tooltip.SetDefault("A chair for the supreme.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.ShallChair>());
			Item.value = Item.sellPrice(gold: 1, silver: 50);
			Item.maxStack = 99;
			Item.width = 48;
			Item.height = 32;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.BrightPurpleDye, 1);
			recipe.AddIngredient(ItemID.Silk, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}