using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;    
using WcfService;    //WcfService Reference

namespace WindowsServiceForWCF
{
    public partial class Service1 : ServiceBase
    {
        internal static ServiceHost WcfServiceHost = null;   //Create a Service Host

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)   //Run While WindowServices Start 
        {

            if (WcfServiceHost != null)
            {
                WcfServiceHost.Close();
            }
            WcfServiceHost = new ServiceHost(typeof(WcfService.Service1));  //Run While WindowServices Stop 

            WcfServiceHost.Open();
        }

        protected override void OnStop()
        {
            if (WcfServiceHost != null)
            {
                WcfServiceHost.Close();
                WcfServiceHost = null;
            }
        }
    }
}
