using System;
using System.Collections.Generic;
using System.Text;

namespace Nuevo.Middlewares.AppHealthManager.Models
{
    public class AppResponsetModel
    {
        public int  Id { get; set; }
        public int AccountId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Tracking { get; set; }
    }
}
