using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BlocktsVanities.Content.Items.Accessories
{
    [AutoloadEquip(EquipType.Shoes)]
    public class RedJordans : ModItem
    {
        public override void SetDefaults() {
            Item.width = 22;
            Item.height = 22;

            Item.accessory = true;
            Item.vanity = true;
            Item.rare = ItemRarityID.Orange;
            Item.value = Item.buyPrice(0, 5, 0, 0);
        }
    }
}
