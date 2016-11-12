using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService
{
    public partial class FileCreationSvc : ServiceBase
    {
        public FileCreationSvc()
        {
            InitializeComponent();
            InitializeSheduler();
        }
        private void InitializeSheduler()
        {
            Sheduler oSheduler = new Sheduler();
            oSheduler.Start();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
