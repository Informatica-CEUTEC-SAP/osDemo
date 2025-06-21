using OSDemo.Samples;
using Xunit;

namespace OSDemo.EntityFrameworkCore.Domains;

[Collection(OSDemoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<OSDemoEntityFrameworkCoreTestModule>
{

}
