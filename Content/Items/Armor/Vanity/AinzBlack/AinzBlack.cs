using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace OverlordVanities.Content.Items.Armor.Vanity.AinzBlack
{
	[AutoloadEquip(EquipType.Body)]
	public class AinzBlackBody : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults()
		{
			Item.width = 34;
			Item.height = 24;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(gold: 3);
			Item.vanity = true;
			Item.maxStack = 1;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Bone, 15);
			recipe.AddIngredient(ItemID.Silk, 15);
			recipe.AddIngredient(ItemID.BlackDye, 1);
			recipe.AddIngredient(ItemID.LargeRuby, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
	[AutoloadEquip(EquipType.Legs)]
	public class AinzBlackLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 18;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(gold: 1, silver: 50);
			Item.vanity = true;
			Item.maxStack = 1;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Bone, 15);
			recipe.AddIngredient(ItemID.Silk, 15);
			recipe.AddIngredient(ItemID.BlackDye, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}