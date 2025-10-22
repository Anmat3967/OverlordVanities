using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace OverlordVanities.Content.Items.Placeable
{
	internal class BigShalltearPainting : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Shalltear Bloodfallen Portrait");
			// Tooltip.SetDefault("'R.R 7693'");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.BigShalltearPainting>());
			Item.width = 72;
			Item.height = 72;
			Item.maxStack = 99;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(0, 1);
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldBar, 25);
			recipe.AddIngredient(ItemID.RedPaint, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}
