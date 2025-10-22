using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace OverlordVanities.Content.Items.Placeable
{
	internal class SurfacePainting : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Mausoleum");
			// Tooltip.SetDefault("'R.R 7693'");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.SurfacePainting>());
			Item.width = 50;
			Item.height = 32;
			Item.maxStack = 99;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(0, 1);
		}
	}
}
