using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NostalG.titlebars
{
    public partial class DefaultProgramBar : UserControl
    {
        private string _progName;

        public event EventHandler CloseRequested;

        public DefaultProgramBar()
        {
            InitializeComponent();
        }

        public DefaultProgramBar(Form mainForm, string progName) : this()
        {
            _progName = progName;
            if (progLbl != null)
            {
                progLbl.Text = _progName;
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Program name displayed on the bar")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ProgName
        {
            get => _progName;
            set
            {
                _progName = value;
                if (progLbl != null)
                {
                    progLbl.Text = _progName;
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            CloseRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
