using Sideas.Hygge.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Sideas.Hygge.Permissions
{
    public class HyggePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(HyggePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(HyggePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<HyggeResource>(name);
        }
    }
}
