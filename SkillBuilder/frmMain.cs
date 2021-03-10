using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillBuilder
{
    public partial class frmMain : Form
    {
        Character selectedCharacter;

        public frmMain()
        {
            InitializeComponent();

            selectedCharacter = null;
            UpdateSelectedCharacter(null, null);
        }

        private void btnSkills_Click(object sender, EventArgs e)
        {
            SaveCurrentCharacter();
            new frmSkillCrafter(selectedCharacter).ShowDialog(this);
        }

        private void btnPassives_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented!  Sorry!", "Oops!");
        }

        private void btnGear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented!  Sorry!", "Oops!");
        }

        private void UpdateSelectedCharacter(object sender, EventArgs e)
        {
            SaveCurrentCharacter();

            if (cboCharacter.SelectedIndex < 0)
            {
                grpCharacterInfo.Hide();
                selectedCharacter = null;
            }
            else
            {
                if (cboCharacter.SelectedIndex == cboCharacter.Items.Count - 1)
                {
                    selectedCharacter = new Character();
                    GameData.Current.Characters.Add(selectedCharacter);
                }
                else
                {
                    selectedCharacter = (Character)cboCharacter.SelectedItem;
                }
                LoadCharacter();
            }

            RefreshCharacterList();
        }
        private void SaveCurrentCharacter()
        {
            if (selectedCharacter != null)
            {
                selectedCharacter.Name = txtName.Text;
                selectedCharacter.Resources = new ResourceAmount((float)numHP.Value, (float)numMP.Value, (float)numSP.Value);
            }
        }
        private void LoadCharacter()
        {
            grpCharacterInfo.Show();

            txtName.Text = selectedCharacter.Name;
            numHP.Value = (decimal)selectedCharacter.Resources.health;
            numMP.Value = (decimal)selectedCharacter.Resources.mana;
            numSP.Value = (decimal)selectedCharacter.Resources.stamina;
        }

        private void RefreshCharacterList()
        {
            cboCharacter.Items.Clear();
            cboCharacter.Items.AddRange(GameData.Current.Characters.ToArray());
            cboCharacter.Items.Add("New Character...");
            //cboCharacter.SelectedItem = selectedCharacter;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCurrentCharacter();
            GameData.Current.Save();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //SaveCurrentCharacter();
            //RefreshCharacterList();
        }
    }
}
