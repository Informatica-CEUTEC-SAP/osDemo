using OSDemo.Samples;
using Xunit;

namespace OSDemo.EntityFrameworkCore.Applications;

[Collection(OSDemoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<OSDemoEntityFrameworkCoreTestModule>
{

}
