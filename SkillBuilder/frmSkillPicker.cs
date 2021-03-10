using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkillBuilder.Skills;

namespace SkillBuilder
{
    public partial class frmSkillPicker : Form
    {
        private SkillPartInfo pickedPart;
        public frmSkillPicker(List<SkillPartInfo> parts)
        {
            InitializeComponent();

            cboChoices.Items.Clear();
            foreach (SkillPartInfo part in parts)
            {
                cboChoices.Items.Add(part);
            }
        }

        public static SkillPartInfo Show(IWin32Window parent, List<SkillPartInfo> parts)
        {
            frmSkillPicker form = new frmSkillPicker(parts);
            form.ShowDialog(parent);
            
            return form.pickedPart;
        }

        private void cboChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChoices.SelectedItem != null)
            {
                this.pickedPart = (SkillPartInfo)cboChoices.SelectedItem;
            }
            else
            {
                this.pickedPart = null;
            }
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.pickedPart = null;
            this.Close();
        }
    }
}
