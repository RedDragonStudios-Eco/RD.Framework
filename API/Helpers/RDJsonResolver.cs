using Eco.Core.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Reflection;


namespace RD.Framework.API.Helpers
{
    public class RDJsonResolver : ExpandableObjectContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var propertybase = base.CreateProperty(member, memberSerialization);
            if (!propertybase.Writable)
            {
                var property = member as PropertyInfo;
                var hasPrivatesetter = property?.GetSetMethod(true) != null;
                propertybase.Writable = hasPrivatesetter;
            }
            return propertybase;
        }
    }
}
