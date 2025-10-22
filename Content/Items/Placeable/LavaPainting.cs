using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace OverlordVanities.Content.Items.Placeable
{
	internal class LavaPainting : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("River of Lava");
			// Tooltip.SetDefault("'R.R 7693'");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.LavaPainting>());
			Item.width = 50;
			Item.height = 34;
			Item.maxStack = 99;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(0, 1);
		}
	}
}
