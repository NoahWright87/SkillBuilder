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
    public partial class frmPartsEditor : Form
    {
        const String PARTS_TYPE_TECHNIQUE = "Technique";
        const String PARTS_TYPE_MODIFER = "Modifier";

        List<SkillTechniqueInfo.TechniqueType> techTypes;
        List<SkillModifierInfo.ModifierType> modTypes;

        Skills.SkillPartInfo currentPartInfo;

        public frmPartsEditor()
        {
            InitializeComponent();

            techTypes = new List<SkillTechniqueInfo.TechniqueType>();
            techTypes.Add(SkillTechniqueInfo.TechniqueType.Action);
            techTypes.Add(SkillTechniqueInfo.TechniqueType.ActorSpawn);
            techTypes.Add(SkillTechniqueInfo.TechniqueType.ProjectileSpawn);

            modTypes = new List<SkillModifierInfo.ModifierType>();
            modTypes.Add(SkillModifierInfo.ModifierType.Modifier);
            modTypes.Add(SkillModifierInfo.ModifierType.Directional);
            modTypes.Add(SkillModifierInfo.ModifierType.Frequency);

            cboPartType.Items.Clear();
            cboPartType.Items.Add(PARTS_TYPE_TECHNIQUE);
            cboPartType.Items.Add(PARTS_TYPE_MODIFER);
            cboPartType.SelectedIndex = 0;

            //cboType.Items.Clear();
            //cboType.Items.Add(SkillModifierInfo.ModifierType.Modifier);
            //cboType.Items.Add(SkillModifierInfo.ModifierType.Directional);
        }

        private void lstParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveCurrentPart();

            if (lstParts.SelectedIndex < 0)
            {
                currentPartInfo = null;
                btnRemovePart.Hide();
                grpPartInfo.Hide();
            }
            else
            {
                btnRemovePart.Show();
                grpPartInfo.Show();
                LoadPart((SkillPartInfo)lstParts.SelectedItem);
            }
        }

        private void SaveCurrentPart()
        {
            if (currentPartInfo != null)
            {
                currentPartInfo.Name = txtName.Text;
                currentPartInfo.Description = txtDescription.Text;
                currentPartInfo.Description2 = txtDescription2.Text;
                currentPartInfo.Description3 = txtDescription3.Text;
                currentPartInfo.Cost.health = (float)numHPCost.Value;
                currentPartInfo.Cost.mana = (float)numMPCost.Value;
                currentPartInfo.Cost.stamina = (float)numSPCost.Value;

                if (currentPartInfo is SkillModifierInfo)
                {
                    SkillModifierInfo modInfo = (SkillModifierInfo)currentPartInfo;
                    modInfo.ModType = (SkillModifierInfo.ModifierType)cboType.SelectedItem;
                }
                else
                {
                    SkillTechniqueInfo techInfo = (SkillTechniqueInfo)currentPartInfo;
                    techInfo.TechType = (SkillTechniqueInfo.TechniqueType)cboType.SelectedItem;
                }
            }
        }
        private void LoadPart(SkillPartInfo partInfo)
        {
            currentPartInfo = partInfo;

            txtId.Text = partInfo.Id.ToString();
            txtName.Text = partInfo.Name;
            txtDescription.Text = partInfo.Description;
            txtDescription2.Text = partInfo.Description2;
            txtDescription3.Text = partInfo.Description3;
            numHPCost.Value = (decimal)partInfo.Cost.health;
            numMPCost.Value = (decimal)partInfo.Cost.mana;
            numSPCost.Value = (decimal)partInfo.Cost.stamina;

            if (partInfo is SkillModifierInfo)
            {
                cboType.Items.Clear();
                foreach (SkillModifierInfo.ModifierType type in modTypes)
                {
                    cboType.Items.Add(type);
                }

                SkillModifierInfo modInfo = (SkillModifierInfo)partInfo;
                cboType.SelectedItem = modInfo.ModType;
            }
            else
            {
                cboType.Items.Clear();
                foreach (SkillTechniqueInfo.TechniqueType type in techTypes)
                {
                    cboType.Items.Add(type);
                }

                SkillTechniqueInfo techInfo = (SkillTechniqueInfo)partInfo;
                cboType.SelectedItem = techInfo.TechType;
            }
        }

        private void cboPartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveCurrentPart();

            lstParts.Items.Clear();

            //Func<SkillPartInfo, bool> filter;
            if (cboPartType.Text == PARTS_TYPE_MODIFER)
            {
                //filter = (x => x is SkillModifierInfo);
                lstParts.Items.AddRange(GameData.Current.ModsInfo.ToArray());

                //grpModAttributes.Show();
                //grpTechniqueAttributes.Hide();
            }
            else //must be a technique
            {
                //filter = (x => x is SkillTechniqueInfo);
                lstParts.Items.AddRange(GameData.Current.TechsInfo.ToArray());

                //grpModAttributes.Hide();
                //grpTechniqueAttributes.Show();
            }

            //foreach (SkillPartInfo i in SkillData.Current.PartsInfo.Where(filter))
            //{
            //    lstParts.Items.Add(i);
            //}

            lstParts_SelectedIndexChanged(sender, null);
            //if (cboPartType.SelectedItem == PARTS_TYPE_MODIFER)
            //{
            //    foreach (SkillPartInfo i in SkillData.Current.PartsInfo.Values.Where(x => x is SkillModifierInfo))
            //    {
            //        lstParts.Items.Add(i);
            //    }
            //}
            //else if (cboPartType.SelectedItem == PARTS_TYPE_TECHNIQUE)
            //{
            //    foreach (SkillPartInfo i in SkillData.Current.PartsInfo.Values.Where(x => x is SkillModifierInfo))
            //    {
            //        lstParts.Items.Add(i);
            //    }
            //}
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            SaveCurrentPart();

            if (cboPartType.Text == PARTS_TYPE_MODIFER)
            {
                currentPartInfo = new SkillModifierInfo();
                GameData.Current.ModsInfo.Add(currentPartInfo);
            }
            else //must be a technique
            {
                currentPartInfo = new SkillTechniqueInfo();
                GameData.Current.TechsInfo.Add(currentPartInfo);
            }

            //SkillData.Current.PartsInfo.Add(currentPartInfo);

            LoadPart(currentPartInfo);

            lstParts.Items.Add(currentPartInfo);
            lstParts.SelectedIndex = lstParts.Items.Count - 1;
        }

        private void btnRemovePart_Click(object sender, EventArgs e)
        {
            //SkillData.Current.PartsInfo.Remove(currentPartInfo);

            if (cboPartType.Text == PARTS_TYPE_MODIFER)
            {
                GameData.Current.ModsInfo.Remove((SkillModifierInfo)currentPartInfo);
            }
            else //must be a technique
            {
                GameData.Current.TechsInfo.Remove((SkillTechniqueInfo)currentPartInfo);
            }

            cboPartType_SelectedIndexChanged(sender, null);
        }

        private void frmPartsEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCurrentPart();
            GameData.Current.Save();
        }

        private void UpdateDescription(object sender, EventArgs e)
        {
            if (this.currentPartInfo is SkillModifierInfo)
            {
                lblExample.Text = Skill.GetExampleDescription(txtDescription.Text, txtDescription2.Text, txtDescription3.Text, null, null, null, null, null);
            }
            else
            {
                lblExample.Text = Skill.GetExampleDescription(null, null, null, txtDescription.Text, txtDescription2.Text, txtDescription3.Text, null, null);
            }
        }
    }
}
