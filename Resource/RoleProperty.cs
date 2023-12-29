using System.Diagnostics.CodeAnalysis;
using Resource.Role;

namespace Resource;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public class RoleProperty : Property
{
    public int 人物等级 = 100;

    public ProfessionEnum 职业;

    public int 觉醒次数;

    public int SP;

    public int TP;
}