using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace OverlordVanities.Content.Items.Accessories
{
	[AutoloadEquip(EquipType.Wings)]
	public class PeroroncinoWings : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
			ArmorIDs.Wing.Sets.Stats[Item.wingSlot] = new WingStats(25, 6f, 1f);
		}

		public override void SetDefaults()
		{
			Item.width = 38;
			Item.height = 32;
			Item.value = Item.sellPrice(gold: 8);
			Item.rare = ItemRarityID.Orange;
			Item.accessory = true;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f; // Falling glide speed
			ascentWhenRising = 0.15f; // Rising speed
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 1.5f;
			constantAscend = 0.135f;
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.CreativeWings, 1);
			recipe.AddIngredient(ItemID.BrownDye, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}