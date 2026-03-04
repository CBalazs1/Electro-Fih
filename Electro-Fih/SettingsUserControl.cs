using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electro_Fih
{
    public partial class SettingsUserControl : UserControl
    {
        public SettingsUserControl()
        {
            InitializeComponent();
        }

        private void SettingsUserControl_Load(object sender, EventArgs e)
        {

        }

        public event Func<Task> OnDeleteProfileRequested;

        private async void profileDeletionButton_Click(object sender, EventArgs e)
        {
            if (OnDeleteProfileRequested != null)
                await OnDeleteProfileRequested.Invoke();
        }
    }
}
