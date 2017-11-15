using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using WPFDemo.ViewModels;

namespace WPFDemo
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            base.OnStartup(sender, e);

            var settings = new Dictionary<string, object>
                {
                   { "SizeToContent", SizeToContent.Manual },
                   { "Height" , 600  },
                   { "Width"  , 1024 },
               };

            DisplayRootViewFor<ShellViewModel>(settings);
        }
    }
}
