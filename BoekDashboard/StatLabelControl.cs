using System.Windows.Forms;

namespace BoekDashboard
{
    public partial class StatLabelControl : UserControl
    {
        public StatLabelControl()
        {
            InitializeComponent();
        }

        public void SetValue(string value)
        {
            valueLbl.Text = value;
        }

        public void SetTitle(string title)
        {
            titleLbl.Text = title;
        }
    }
}
