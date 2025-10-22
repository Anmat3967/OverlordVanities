using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using OverlordVanities.Content.Players;

namespace OverlordVanities.Content.Items.Armor.Vanity.Peroroncino
{
	[AutoloadEquip(EquipType.Head)]
	public class PeroroncinoHead : ModItem
	{
		public override bool IsVanitySet(int head, int body, int legs)
		{
			return head == EquipLoader.GetEquipSlot(Mod, nameof(PeroroncinoHead), EquipType.Head)
				&& body == EquipLoader.GetEquipSlot(Mod, nameof(PeroroncinoBody), EquipType.Body)
				&& legs == EquipLoader.GetEquipSlot(Mod, nameof(PeroroncinoLegs), EquipType.Legs);
		}
		public override void UpdateVanitySet(Player player)
		{
			player.GetModPlayer<PeroroncinoPlayer>().IsActive = true;
		}
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Winged King Helmet");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
			ArmorIDs.Head.Sets.DrawHead[Item.headSlot] = false;
		}
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 26;
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
			recipe.AddIngredient(ItemID.GoldBar, 10);
			recipe.AddIngredient(ItemID.Feather, 3);
			recipe.AddIngredient(ItemID.Emerald, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
	[AutoloadEquip(EquipType.Body)]
	public class PeroroncinoBody : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Winged King Breastplate");
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
		public override void DrawArmorColor(Player drawPlayer, float shadow, ref Color color, ref int glowMask, ref Color glowMaskColor)
		{
			color = drawPlayer.GetImmuneAlphaPure(Color.White, shadow);
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldBar, 10);
			recipe.AddIngredient(ItemID.Feather, 3);
			recipe.AddIngredient(ItemID.LargeEmerald, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
	[AutoloadEquip(EquipType.Legs)]
	public class PeroroncinoLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Winged King Leggings");
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
			recipe.AddIngredient(ItemID.GoldBar, 10);
			recipe.AddIngredient(ItemID.Feather, 3);
			recipe.AddIngredient(ItemID.Emerald, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}