using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using OverlordVanities.Content.Buffs;
using OverlordVanities.Content.Projectiles;

namespace OverlordVanities.Content.Pets
{
    public class CocytusItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.ZephyrFish);
            Item.width = 20;
            Item.height = 54;
            Item.rare = 3;
            Item.value = Item.sellPrice(gold: 3);
            Item.vanity = true;
            Item.maxStack = 1;
            Item.accessory = true;
            Item.buffType = ModContent.BuffType<CocytusBuff>();
            //Item.shoot = ModContent.ProjectileType<GinnungagapProjectile>();
            Item.hasVanityEffects = true;
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
            recipe.AddIngredient(ItemID.Bone, 10);
            recipe.AddIngredient(ItemID.SilverBar, 20);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}