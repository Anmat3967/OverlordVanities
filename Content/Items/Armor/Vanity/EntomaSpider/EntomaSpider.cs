using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OverlordVanities.Content.Players;

namespace OverlordVanities.Content.Items.Armor.Vanity.EntomaSpider
{
	[AutoloadEquip(EquipType.Back)]
	public class EntomaSpider : ModItem
	{
		public override void Load()
		{
			if (Main.netMode == NetmodeID.Server)
			{
                return;
            }
			EquipLoader.AddEquipTexture(Mod, $"{Texture}_{EquipType.Head}", EquipType.Head, this);
			EquipLoader.AddEquipTexture(Mod, $"{Texture}_{EquipType.Body}", EquipType.Body, this);
			EquipLoader.AddEquipTexture(Mod, $"{Texture}_{EquipType.Legs}", EquipType.Legs, this);
		}
		public override void SetStaticDefaults()
		{
            if (Main.netMode == NetmodeID.Server)
            {
                return;
            }

            int equipSlotHead = EquipLoader.GetEquipSlot(Mod, Name, EquipType.Head);
            int equipSlotBody = EquipLoader.GetEquipSlot(Mod, Name, EquipType.Body);
            int equipSlotLegs = EquipLoader.GetEquipSlot(Mod, Name, EquipType.Legs);

            ArmorIDs.Head.Sets.DrawHead[equipSlotHead] = false;
            ArmorIDs.Body.Sets.HidesTopSkin[equipSlotBody] = true;
            ArmorIDs.Body.Sets.HidesArms[equipSlotBody] = true;
            ArmorIDs.Legs.Sets.HidesBottomSkin[equipSlotLegs] = true;
        }

		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 38;
			Item.accessory = true;
			Item.value = Item.sellPrice(gold: 3);
			Item.rare = ItemRarityID.Blue;
			Item.hasVanityEffects = true;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Cobweb, 100);
			recipe.AddIngredient(ItemID.Silk, 30);
			recipe.AddIngredient(ItemID.BrownDye, 3);
			recipe.AddIngredient(ItemID.Amethyst, 5);
			recipe.AddTile(TileID.DemonAltar);
			recipe.Register();
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            EntomaSpiderPlayer spiderPlayer = player.GetModPlayer<EntomaSpiderPlayer>();
            spiderPlayer.EntomaHideVanity = hideVisual;
		}
		public override bool IsVanitySet(int head, int body, int legs) => true;
	}
}