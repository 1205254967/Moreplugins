using Terraria;
using Terraria.ID;

namespace Moreplugins.Content.Items.Accessories
{
    internal class EnchantedPlusins : BasicPlugins
    {
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.maxStack = 1;
            Item.accessory = true;
            Item.rare = ItemRarityID.Green;
            Item.value = Item.sellPrice(gold: 20);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
        }
    }
}
