using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars.Ribbon;

namespace MvpvmNavigation {
    public interface IRibbonModule {
        RibbonControl Ribbon { get; }
    }

    public interface ISupportTransitions {
        void StartTransition(bool forward, object waitParameter);
        void EndTransition();
    }
}
