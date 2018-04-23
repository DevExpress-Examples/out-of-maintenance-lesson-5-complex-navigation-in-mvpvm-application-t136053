using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;

namespace MvpvmNavigation.Views {
    public partial class View2 : UserControl, IRibbonModule {
        public View2() {
            InitializeComponent();
            System.Threading.Thread.Sleep(1000);
        }
        RibbonControl IRibbonModule.Ribbon {
            get { return ribbonControl1; }
        }
    }
}
