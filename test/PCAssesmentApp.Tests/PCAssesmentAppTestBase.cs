using System;
using System.Threading.Tasks;
using Abp.TestBase;
using PCAssesmentApp.EntityFrameworkCore;
using PCAssesmentApp.Tests.TestDatas;

namespace PCAssesmentApp.Tests
{
    public class PCAssesmentAppTestBase : AbpIntegratedTestBase<PCAssesmentAppTestModule>
    {
        public PCAssesmentAppTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<PCAssesmentAppDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<PCAssesmentAppDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<PCAssesmentAppDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<PCAssesmentAppDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<PCAssesmentAppDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<PCAssesmentAppDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<PCAssesmentAppDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<PCAssesmentAppDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
