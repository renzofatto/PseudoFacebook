using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObligatorioUI
{
    public partial class ExpandableBook : UserControl
    {
        private const int MaxCountBeforeExpand = 3;
        private const int ExpansionUnit = 90;

        private readonly IList<Control> controls;
        private bool IsExpanded { get; set; }
        private int Units { get; set; }

        public ExpandableBook(string title, IList<Control> controls)
        {
            this.controls = controls;
            InitializeComponent();
            this.bookNameLabel.Text = title;
            Units = (int)Math.Ceiling(Convert.ToDecimal(controls.Count) / Convert.ToDecimal(MaxCountBeforeExpand)) - 1;
            LoadControls(MaxCountBeforeExpand);
        }

        private void LoadControls(int count)
        {
            this.containerPanel.Controls.Clear();
            if (count > controls.Count)
                count = controls.Count;
            for (int i = 0; i < count; i++)
                this.containerPanel.Controls.Add(controls[i]);
            if (count > MaxCountBeforeExpand)
                Expand();
            else
                Shrink();
        }

        private void Expand(int height = ExpansionUnit)
        {
            if (!IsExpanded)
            {
                this.Size += new Size(0, height * Units);
                this.card.Size += new Size(0, height * Units);
                this.borderPanel.Size += new Size(0, height * Units);
                this.containerPanel.Size += new Size(0, height * Units);
                IsExpanded = true;
                LoadControls(controls.Count);
            }

        }

        private void Shrink(int height = ExpansionUnit)
        {
            if (IsExpanded)
            {
                this.Size -= new Size(0, height * Units);
                this.card.Size -= new Size(0, height * Units);
                this.borderPanel.Size -= new Size(0, height * Units);
                this.containerPanel.Size -= new Size(0, height * Units);
                IsExpanded = false;
                LoadControls(MaxCountBeforeExpand);
            }
        }

        private void expandButton_Click(object sender, EventArgs e)
        {
            if (IsExpanded)
            {

                Shrink();
            }
            else
            {

                Expand();
            }
        }
    }
}
