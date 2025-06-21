using Xunit;

namespace OSDemo.EntityFrameworkCore;

[CollectionDefinition(OSDemoTestConsts.CollectionDefinitionName)]
public class OSDemoEntityFrameworkCoreCollection : ICollectionFixture<OSDemoEntityFrameworkCoreFixture>
{

}
