using System.Numerics;
using BlocktsVanities.Content.Items.Accessories;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace BlocktsVanities.Content.NPCs
{
    internal class BlocktGlobalTownNPC : GlobalNPC
    {
        public override void ModifyShop(NPCShop shop)
        {
            int type = shop.NpcType;

            if (type == NPCID.Clothier)
            {
                shop.Add(ModContent.ItemType<RedJordans>());
            }
        }
    }
}
