using Microsoft.Xna.Framework;
using Moreplugins.Core.Utilities;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Moreplugins.Content.Items.Accessories
{
    /// <summary>
    /// Holy饰品 - 神圣饰品
    /// </summary>
    internal class HolyPlugins : BasicPlugins
    {

        #region 基础属性配置
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.maxStack = 1;
            Item.accessory = true; // 标记为饰品
            Item.rare = ItemRarityID.Pink; // 粉色稀有度
            Item.value = Item.sellPrice(gold: 5); // 售价5金币
        }
        #endregion

        #region 合成配方
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.HallowedBar, 3)       // 3个神圣锭
                .AddIngredient(ItemID.Ruby, 1)              // 1个红宝石
                .AddTile(TileID.MythrilAnvil)               // 秘银砧/山铜砧合成
                .Register();
        }
        #endregion

        #region 核心饰品效果
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            // 3点防御
            player.statDefense += 3;
            // 1最大仆从数
            player.maxMinions += 1;
            // 召唤物有30%概率造成150%伤害
            player.GetCritChance(DamageClass.Summon) += 0.3f;
            // 5点护甲穿透
            player.GetArmorPenetration(DamageClass.Summon) += 5;
            player.MPPlayer().SoundAcc = true;
        }
        #endregion
    }
}