using JustLabel.Models;
using JustLabel.Data.Models;

namespace IntegrationTests.Factories;

public static class LabelSchemeDbModelFactory
{
    public static LabelSchemeDbModel Create(int labelId, int schemeId)
    {
        return new LabelSchemeDbModel
        {
            LabelId = labelId,
            SchemeId = schemeId
        };
    }
}