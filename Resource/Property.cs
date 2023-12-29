using System.Diagnostics.CodeAnalysis;
using Resource.Attributes.枚举;

namespace Resource;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public class Property
{
    public int 力量 { get; set; }

    public int 智力 { get; set; }

    public int 体力 { get; set; }

    public int 精神 { get; set; }

    public int HP { get; set; }

    public int MP { get; set; }

    public int HP恢复 { get; set; }

    public int MP恢复 { get; set; }

    public int 僵直度 { get; set; }

    public int 硬直度 { get; set; }


    public int 攻击强化 { get; set; }

    public int buff量 { get; set; }

    public decimal 攻击强化增加 { get; set; }

    public decimal buff量增加 { get; set; }

    public decimal 技能攻击力 { get; set; }


    public decimal 冷却时间减少_减算 { get; set; }

    public decimal 冷却时间减少_乘算 { get; set; }

    public decimal 冷却时间恢复 { get; set; }


    public int 火属性强化 { get; set; }

    public int 冰属性强化 { get; set; }

    public int 暗属性强化 { get; set; }

    public int 光属性强化 { get; set; }


    public int 火属性抗性 { get; set; }

    public int 冰属性抗性 { get; set; }

    public int 暗属性抗性 { get; set; }

    public int 光属性抗性 { get; set; }


    public int 魔法防御 { get; set; }

    public int 物理防御 { get; set; }

    public decimal 魔法防御减少 { get; set; }

    public decimal 物理防御减少 { get; set; }


    public int 魔法攻击力 { get; set; }

    public int 物理攻击力 { get; set; }

    public int 独立攻击力 { get; set; }


    public decimal 魔法暴击率 { get; set; }

    public decimal 物理暴击率 { get; set; }


    public decimal 回避率 { get; set; }

    public decimal 命中率 { get; set; }


    public decimal 移动速度 { get; set; }

    public decimal 攻击速度 { get; set; }

    public decimal 释放速度 { get; set; }


    #region 异常伤害

    public decimal 出血伤害增加 { get; set; }

    public decimal 感电伤害增加 { get; set; }

    public decimal 灼烧伤害增加 { get; set; }

    public decimal 中毒伤害增加 { get; set; }

    public decimal 出血伤害转换 { get; set; }

    public decimal 感电伤害转换 { get; set; }

    public decimal 灼烧伤害转换 { get; set; }

    public decimal 中毒伤害转换 { get; set; }

    #endregion

    #region 状态类

    public List<Status> 自身状态 { get; set; } = new();

    public List<Status> 附加状态 { get; set; } = new();

    public List<ControlStates> 附加大异常 { get; set; } = new();

    public List<ElementAppend> 属性攻击赋予 { get; set; } = new();

    #endregion

    #region 词条类

    public Dictionary<SkillLevelEnum, int> 等级增加 { get; set; } = new();

    public Dictionary<StackableAttributeEntries, decimal> 可重复特殊词条 { get; set; } = new();

    public List<NonStackableAttributeEntries> 不可叠加词条 { get; set; } = new();

    public Dictionary<SkillLevelEnum, decimal> 技能范围 { get; set; } = new();

    #endregion

    #region 大抗性属性

    public decimal 出血抗性 { get; set; }

    public decimal 中毒抗性 { get; set; }

    public decimal 灼伤抗性 { get; set; }

    public decimal 感电抗性 { get; set; }

    public decimal 冰冻抗性 { get; set; }

    public decimal 减速抗性 { get; set; }

    public decimal 眩晕抗性 { get; set; }

    public decimal 诅咒抗性 { get; set; }

    public decimal 失明抗性 { get; set; }

    public decimal 石化抗性 { get; set; }

    public decimal 睡眠抗性 { get; set; }

    public decimal 混乱抗性 { get; set; }

    public decimal 束缚抗性 { get; set; }

    #endregion

    #region 旧属性提升

    public decimal 暴击伤害增加 { get; set; }

    public decimal 附加伤害 { get; set; }

    public decimal 最终伤害增加 { get; set; }

    public decimal 物理攻击力增加 { get; set; }

    public decimal 魔法攻击力增加 { get; set; }

    public decimal 独立攻击力增加 { get; set; }

    public decimal 力量增加 { get; set; }

    public decimal 智力增加 { get; set; }

    public decimal 持续伤害 { get; set; }

    #endregion

    #region 旧属性提升奶

    public decimal 三攻增加量_固定 { get; set; }

    public decimal 三攻增加量_百分比 { get; set; }

    public decimal 力智增加量_固定 { get; set; }

    public decimal 力智增加量_百分比 { get; set; }

    #endregion
}