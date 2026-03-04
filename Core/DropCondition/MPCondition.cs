using Moreplugins.Core.Utilities;
using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace Moreplugins.Core.DropCondition
{
    /// <summary>
    /// 检测白天的条件类
    /// </summary>
    public class DaytimeCondition : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            return Main.dayTime;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            //别特么用硬编码我草
            //所有这种要显示给玩家的内容必须得统一用本地化
            //return "在白天击败光之女皇时掉落";

            //这里使用了封装的拓展方法
            //具体语义可以跳转一下
            return $"Mods.Moreplugins.PluginConditoins.OnDaytimeEmpress".ToLanValue();
        }
    }
}
