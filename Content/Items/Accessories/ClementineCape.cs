using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace OverlordVanities.Content.Items.Accessories
{
	[AutoloadEquip(EquipType.Back, EquipType.Front)]
	public class ClementineCape : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 30;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(silver: 75);
			Item.vanity = true;
			Item.maxStack = 1;
			Item.accessory = true;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.PurpleDye, 1);
			recipe.AddIngredient(ItemID.Silk, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}