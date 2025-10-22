using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using System;
using OverlordVanities.Content.Buffs;
using OverlordVanities.Content.Projectiles;

namespace OverlordVanities.Content.Pets
{
	public class SOAOGItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 46;
			Item.rare = 3;
			Item.value = Item.sellPrice(gold: 10);
			Item.vanity = true;
			Item.maxStack = 1;
			Item.accessory = true;
			Item.buffType = ModContent.BuffType<SOAOGBuff>();
			//Item.shoot = ModContent.ProjectileType<SOAOGProjectile>();
		}
		public override void UpdateVanity(Player player)
        {
			if (player.whoAmI == Main.myPlayer)
			{
				player.AddBuff(Item.buffType, 2);
			}
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			if (!hideVisual)
            {
				if (player.whoAmI == Main.myPlayer)
				{
					player.AddBuff(Item.buffType, 2);
				}
			}
			else
            {
				player.ClearBuff(Item.buffType);
			}
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Topaz, 3);
			recipe.AddIngredient(ItemID.Ruby, 3);
			recipe.AddIngredient(ItemID.Amber, 3);
			recipe.AddIngredient(ItemID.Sapphire, 3);
			recipe.AddIngredient(ItemID.Amethyst, 3);
			recipe.AddIngredient(ItemID.Emerald, 3);
			recipe.AddIngredient(ItemID.GoldBar, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}