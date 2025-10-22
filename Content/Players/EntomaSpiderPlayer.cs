using OverlordVanities.Content.Items.Armor.Vanity.EntomaSpider;
using Terraria.ModLoader;
using Terraria;

namespace OverlordVanities.Content.Players
{
    public class EntomaSpiderPlayer : ModPlayer
    {
        public bool EntomaHideVanity;
        public bool EntomaForceVanity;

        public override void ResetEffects()
        {
            EntomaHideVanity = EntomaForceVanity = false;
        }

        public override void UpdateVisibleVanityAccessories()
        {
            for (int n = 13; n < 18 + Player.GetAmountOfExtraAccessorySlotsToShow(); n++)
            {
                Item item = Player.armor[n];
                if (item.type == ModContent.ItemType<EntomaSpider>())
                {
                    EntomaHideVanity = false;
                    EntomaForceVanity = true;
                }
            }
        }
        public override void FrameEffects()
        {
            // TODO: Need new hook, FrameEffects doesn't run while paused.
            if (EntomaForceVanity && !EntomaHideVanity)
            {
                var entomaCostume = ModContent.GetInstance<EntomaSpider>();
                Player.head = EquipLoader.GetEquipSlot(Mod, entomaCostume.Name, EquipType.Head);
                Player.body = EquipLoader.GetEquipSlot(Mod, entomaCostume.Name, EquipType.Body);
                Player.legs = EquipLoader.GetEquipSlot(Mod, entomaCostume.Name, EquipType.Legs);
            }
        }
    }
}
