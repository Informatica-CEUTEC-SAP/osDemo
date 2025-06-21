using OSDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace OSDemo.Permissions;

public class OSDemoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(OSDemoPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(OSDemoPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(OSDemoPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(OSDemoPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(OSDemoPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(OSDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<OSDemoResource>(name);
    }
}
