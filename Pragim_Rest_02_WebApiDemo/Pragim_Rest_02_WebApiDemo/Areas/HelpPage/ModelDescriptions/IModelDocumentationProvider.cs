using System;
using System.Reflection;

namespace Pragim_Rest_02_WebApiDemo.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}