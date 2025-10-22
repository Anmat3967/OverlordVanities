using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace OverlordVanities.Content.Items.Armor.Vanity.Ulbert
{
	[AutoloadEquip(EquipType.Head)]
	public class UlbertHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Demon Mask");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 26;
			Item.rare = ItemRarityID.Orange;
			Item.value = Item.sellPrice(gold: 1, silver: 50);
			Item.vanity = true;
			Item.maxStack = 1;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.BlackThread, 3);
			recipe.AddIngredient(ItemID.Topaz, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
	[AutoloadEquip(EquipType.Body)]
	public class UlbertBody : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Demon Suit");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults()
		{
			Item.width = 34;
			Item.height = 24;
			Item.rare = ItemRarityID.Orange;
			Item.value = Item.sellPrice(gold: 3);
			Item.vanity = true;
			Item.maxStack = 1;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.BlackThread, 3);
			recipe.AddIngredient(ItemID.Topaz, 2);
			recipe.AddIngredient(ItemID.LargeTopaz, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
	[AutoloadEquip(EquipType.Legs)]
	public class UlbertLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Demon Hooves");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 18;
			Item.rare = ItemRarityID.Orange;
			Item.value = Item.sellPrice(gold: 1, silver: 50);
			Item.vanity = true;
			Item.maxStack = 1;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.BlackThread, 3);
			recipe.AddIngredient(ItemID.Topaz, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}