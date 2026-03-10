using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Moreplugins.Core.Utilities;
using Moreplugins.Core.GlobalInstance.Items;
using Terraria.Localization;

namespace Moreplugins.Content.Items.Accessories
{
    /// <summary>
    /// Night饰品 - 夜晚饰品
    /// </summary>
    public class NightPlugins : BasicPlugins
    {
        private int FlatDamageAndCrits = 5;
        private float DamageAndDR = 0.05f;
        private float SummonCrit = 0.30f;
        private float SummonCritDamage = 1.5f;
        private int MaxMana = 30;
        public override void SetDefaults()
        {
            base.SetDefaults(); 
            Item.rare = ItemRarityID.Orange; // 橙色稀有度
            Item.value = Item.sellPrice(gold: 5); // 售价5金币
            Item.manaIncrease = 30;
            Item.defense = 3;
        }
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(FlatDamageAndCrits, DamageAndDR.ToPercent(), SummonCrit.ToPercent(), SummonCritDamage.ToPercent(), MaxMana);

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemType<LeafPlugins>())
                .AddIngredient(ItemType<LavaSeedPlugins>())
                .AddIngredient(ItemType<KaishakuninPlugins>()) 
                .AddRecipeGroup(PluginRecipeGroup.AnyEvilPlugin)
                .AddTile(TileID.DemonAltar)
                .Register();
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            player.GetDamage(DamageClass.Generic).Flat += 2f;
            player.GetDamage(DamageClass.Generic) += 3 / 100f;
            player.GetCritChance(DamageClass.Generic) += 3f;
            player.endurance += 0.03f;
            player.GetDamage(DamageClass.Summon) += 0.5f;
            player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.Burning] = true;
            player.MPPlayer().nightEquipped = true;
        }
    }
}