using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UI
{
    public partial class Frmdongle : Form
    {
      //  private ListView listView1;
        public Frmdongle()
        {
            InitializeComponent();
        }
        //public static string CpuId()
        //{
        //    string str = ".";
        //    object objectValue = RuntimeHelpers.GetObjectValue(Interaction.GetObject("winmgmts:{impersonationLevel=impersonate}!\\\\" + str + "\\root\\cimv2", null));
        //    object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "ExecQuery", new object[]
        //    {
        //        "Select * from Win32_Processor"
        //    }, null, null, null));
        //    string text = "";
        //    IEnumerator enumerator = null;
        //    try
        //    {
        //        foreach (object obj in ((IEnumerable)objectValue2))
        //        {
        //            object objectValue3 = RuntimeHelpers.GetObjectValue(obj);
        //            text = Conversions.ToString(Operators.ConcatenateObject(text + ", ", NewLateBinding.LateGet(objectValue3, null, "ProcessorId", new object[0], null, null, null)));
        //        }
        //    }
        //    finally
        //    {
        //        if (enumerator is IDisposable)
        //        {
        //            (enumerator as IDisposable).Dispose();
        //        }
        //    }
        //    if (text.Length > 0)
        //    {
        //        text = text.Substring(2);
        //    }
        //    return text;
        //}

        // Token: 0x06000FA2 RID: 4002 RVA: 0x002041C4 File Offset: 0x002023C4
        //public static string SystemSerialNumber()
        //{
        //    object objectValue = RuntimeHelpers.GetObjectValue(Interaction.GetObject("WinMgmts:", null));
        //    string text = "";
        //    object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "InstancesOf", new object[]
        //    {
        //        "Win32_BaseBoard"
        //    }, null, null, null));
        //    IEnumerator enumerator = null;
        //    try
        //    {
        //        foreach (object obj in ((IEnumerable)objectValue2))
        //        {
        //            object objectValue3 = RuntimeHelpers.GetObjectValue(obj);
        //            text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(", ", NewLateBinding.LateGet(objectValue3, null, "SerialNumber", new object[0], null, null, null))));
        //        }
        //    }
        //    finally
        //    {
        //        if (enumerator is IDisposable)
        //        {
        //            (enumerator as IDisposable).Dispose();
        //        }
        //    }
        //    if (text.Length > 0)
        //    {
        //        text = text.Substring(2);
        //    }
        //    return text;
        //}

        // Token: 0x06000FA3 RID: 4003 RVA: 0x0001EC78 File Offset: 0x0001CE78
        private void Frmdongle_Load(object sender, EventArgs e)
        {
            //Frmdongle.CpuId();
            //Frmdongle.SystemSerialNumber();
        }
    }
}
