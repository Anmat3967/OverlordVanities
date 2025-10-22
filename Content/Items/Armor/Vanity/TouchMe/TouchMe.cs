using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;


namespace OverlordVanities.Content.Items.Armor.Vanity.TouchMe
{

	[AutoloadEquip(EquipType.Head)]
	public class TouchMeHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Helmet of the Law");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 24;
			Item.rare = ItemRarityID.Orange;
			Item.value = Item.sellPrice(gold: 1, silver: 50);
			Item.vanity = true;
			Item.maxStack = 1;
		}
		public override void DrawArmorColor(Player drawPlayer, float shadow, ref Color color, ref int glowMask, ref Color glowMaskColor)
		{
			color = drawPlayer.GetImmuneAlphaPure(Color.White, shadow);
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.PlatinumBar, 10);
			recipe.AddIngredient(ItemID.Sapphire, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}

	[AutoloadEquip(EquipType.Body)]
	public class TouchMeBody : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Breastplate of the Law");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults()
		{
			Item.width = 38;
			Item.height = 30;
			Item.rare = ItemRarityID.Orange;
			Item.value = Item.sellPrice(gold: 3);
			Item.vanity = true;
			Item.maxStack = 1;
		}
		public override void DrawArmorColor(Player drawPlayer, float shadow, ref Color color, ref int glowMask, ref Color glowMaskColor)
		{
			color = drawPlayer.GetImmuneAlphaPure(Color.White, shadow);
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.PlatinumBar, 10);
			recipe.AddIngredient(ItemID.LargeSapphire, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}

	[AutoloadEquip(EquipType.Legs)]
	public class TouchMeLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Leggings of the Law");
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
		public override void DrawArmorColor(Player drawPlayer, float shadow, ref Color color, ref int glowMask, ref Color glowMaskColor)
		{
			color = drawPlayer.GetImmuneAlphaPure(Color.White, shadow);
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.PlatinumBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}