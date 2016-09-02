using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveSplit.AutoTwitch
{
    public partial class MessageSettings : UserControl
    {
        enum MessageEvent
        {
            Split,
            Reset,
            Best,
            PB,
            FinishedRun

        }
        public MessageSettings()
        {
            InitializeComponent();
        }
    }
}
