using System;
using System.Reflection;

namespace N01282172_MaryLouiseAnhanceAbrena_Assignment2.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}