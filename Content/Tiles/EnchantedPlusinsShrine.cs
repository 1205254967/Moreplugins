using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Moreplugins.Content.Tiles;

public class EnchantedPlusinsShrine : ModTile
{
    public override void SetStaticDefaults()
    {
        base.SetStaticDefaults();
        Main.tileFrameImportant[Type] = true;
        Main.tileSpelunker[Type] = true;

        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
        TileObjectData.newTile.DrawYOffset = 2;
        TileObjectData.addTile(Type);

        RegisterItemDrop(ModContent.ItemType<Items.Accessories.EnchantedPlusins>());
        AddMapEntry(new Color(144, 148, 190), Language.GetText("Mods.Moreplugins.MapObject.EnchantedPlusinsShrine"));
    }
}