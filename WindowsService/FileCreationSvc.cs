using System.ServiceProcess;

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
