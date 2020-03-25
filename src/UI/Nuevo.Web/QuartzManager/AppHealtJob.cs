using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quartz;

namespace Nuevo.Web.QuartzManager
{
    public class AppHealtJob: IJob
    {
      
        public Task Execute(IJobExecutionContext context)
        {
            lock (context)
            {
                var jobData = context.JobDetail.JobDataMap.GetIntValue("JobKey");
                // REQUEST CONTROL LOGİC
                return Task.CompletedTask;
            }
          
        }
    }
}
