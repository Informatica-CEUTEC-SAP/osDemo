using OSDemo.Books;
using Xunit;

namespace OSDemo.EntityFrameworkCore.Applications.Books;

[Collection(OSDemoTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<OSDemoEntityFrameworkCoreTestModule>
{

}