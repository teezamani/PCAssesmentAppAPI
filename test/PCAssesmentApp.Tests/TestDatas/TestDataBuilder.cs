using PCAssesmentApp.EntityFrameworkCore;

namespace PCAssesmentApp.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly PCAssesmentAppDbContext _context;

        public TestDataBuilder(PCAssesmentAppDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}