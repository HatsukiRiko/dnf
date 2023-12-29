using Resource.Attributes.枚举;

namespace Resource.Role;

public class 瞎子 : RoleProperty
{
    public Dictionary<SkillLevelEnum, Dictionary<string, int>> 技能 { get; set; } = new();

    public Dictionary<string, int> 特性技能 { get; set; } = new();

    public 瞎子()
    {
        技能 = GetSkill("瞎子");
        特性技能 = GetSpecialSkill("瞎子");
    }

    private Dictionary<string, int> GetSpecialSkill(string name)
    {
        throw new NotImplementedException();
    }

    private Dictionary<SkillLevelEnum, Dictionary<string, int>> GetSkill(string name)
    {
        throw new NotImplementedException();
    }
}