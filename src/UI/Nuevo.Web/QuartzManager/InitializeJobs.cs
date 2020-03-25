using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nuevo.Middlewares.AppHealthManager.Models;
using Nuevo.Middlewares.AppHealthManager.Provider.LogicContracts;
using Quartz;
using Quartz.Impl;

namespace Nuevo.Web.QuartzManager
{
    public class InitializeJobs
    {
        private readonly IAppHealthLogic _appHealthLogic;

        public InitializeJobs(IAppHealthLogic appHealthLogic)
        {
            _appHealthLogic = appHealthLogic;
        }

        public void Start()
        {
            var model = _appHealthLogic.GetApplication(0);
            InitializeJobs.Start(model.Data);
        }

        public static async void Start(List<AppResponsetModel> modelData)
        {
            foreach (var appResponsetModel in modelData)
            {
                try
                {
                    if (appResponsetModel.Tracking.Length <= 3) continue;
                    var _scheduler = await new StdSchedulerFactory().GetScheduler();
                    await _scheduler.Start();

                    var userEmailsJob = JobBuilder.Create<AppHealtJob>().UsingJobData("JobKey", appResponsetModel.Id)
                        .WithIdentity("SendUserEmailsJob")
                        .Build();
                    var userEmailsTrigger = TriggerBuilder.Create()
                        .WithIdentity("SendUserEmailsCron")
                        .StartNow()
                        .WithCronSchedule(appResponsetModel.Tracking)
                        .Build();

                    var result = await _scheduler.ScheduleJob(userEmailsJob, userEmailsTrigger);

                }
                catch
                {
                
                }
            }


        }
    }
}
