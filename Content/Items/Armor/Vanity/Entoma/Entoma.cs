using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace OverlordVanities.Content.Items.Armor.Vanity.Entoma
{
	[AutoloadEquip(EquipType.Head)]
	public class EntomaHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Zeta Mask");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 30;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(gold: 1, silver: 50);
			Item.vanity = true;
			Item.maxStack = 1;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Amethyst, 1);
			recipe.AddIngredient(ItemID.Silk, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
	[AutoloadEquip(EquipType.Body)]
	public class EntomaBody : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Zeta Dress");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 26;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(gold: 1, silver: 50);
			Item.vanity = true;
			Item.maxStack = 1;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Amethyst, 1);
			recipe.AddIngredient(ItemID.Silk, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
	[AutoloadEquip(EquipType.Legs)]
	public class EntomaLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Zeta Stockings");
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
			recipe.AddIngredient(ItemID.Amethyst, 1);
			recipe.AddIngredient(ItemID.Silk, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}