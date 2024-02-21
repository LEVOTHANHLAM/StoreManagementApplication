using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosManager.Model
{
    interface IKeepable
    {
        bool ShouldKeepForm { get; set; }
        void OnMounted();
        void OnUnMounted(ref UserControl next);
    }
}
