using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SkillBuilder.Skills;

namespace SkillBuilder
{
    public partial class frmSkillCrafter : Form
    {
        static Pen techPen = Pens.Gray;
        static Pen modPen = Pens.White;
        static Pen selectedPen = Pens.Yellow;
        static Pen emptyModPen = Pens.Red;
        static Pen emptyTechPen = Pens.Red;

        static Brush regularText = Brushes.White;
        static Brush emptyText = Brushes.Gray;

        public static Point startPos = new Point(5, 130);
        public static Size boxSize = new Size(150, 40);
        public static Font font = new Font("Arial", 10);

        Character currentCharacter;
        Skill selectedSkill;
        public frmSkillCrafter(Character currentCharacter)
        {
            InitializeComponent();

            this.currentCharacter = currentCharacter;

            startPos.Y = lblDescription.Location.Y + lblDescription.Size.Height + boxSize.Height;

            //selectedSkill = new Skill();
            selectedSkill = null;

            RefreshSkillList();
            RefreshDescription();
        }
        
        private void RefreshSkillList()
        {
            cboSkill.Items.Clear();
            cboSkill.Items.AddRange(currentCharacter.Skills.ToArray());
            cboSkill.Items.Add("New Skill...");
        }

        private void RefreshDescription()
        {
            if (selectedSkill == null)
            {
                lblCost.Text = "";
                lblDescription.Text = "Select a skill, or create a new one.";
            }
            else
            {
                lblCost.Text = "Costs " + selectedSkill.TotalCost;
                lblDescription.Text = selectedSkill.ToString();
            }
        }

        private void skillPartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPartsEditor().ShowDialog(this);
            RefreshDescription();
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            if (selectedSkill != null)
            {

                Graphics g = e.Graphics;
                //Point mousePos = this.PointToClient(Cursor.Position);
                Point mouseIndex = this.CursorToIndices();


                int i;
                for (i = 0; i < selectedSkill.Techniques.Count; i++)
                {
                    SkillTechnique tech = selectedSkill.Techniques[i];
                    DrawHelper(g, i, 0, techPen, regularText, tech.PartInfo.Name);

                    //Point techPos = new Point(startPos.X + boxSize.Width * i, startPos.Y);

                    //g.DrawRectangle(techPen, new Rectangle(techPos, boxSize));
                    //g.DrawString(tech.PartInfo.Name, null, Brushes.White, techPos);

                    int j;
                    for (j = 0; j < tech.Modifiers.Count; j++)
                    {
                        SkillModifier mod = tech.Modifiers[j];
                        DrawHelper(g, i, j + 1, modPen, regularText, mod.PartInfo.Name);

                        //Point modPos = new Point(techPos.X, techPos.Y + boxSize.Height * (1 + j));

                        //g.DrawRectangle(modPen, new Rectangle(modPos, boxSize));


                    }
                    DrawHelper(g, i, j + 1, emptyModPen, emptyText, "+NEW MOD");
                    //Point newModPos = new Point(techPos.X, techPos.Y + boxSize.Height * (1 + j));

                    //g.DrawRectangle(emptyPen, new Rectangle(newModPos, boxSize));
                }
                DrawHelper(g, i, 0, emptyTechPen, emptyText, "+NEW TECH");
                //Point newTechPos = new Point(startPos.X + boxSize.Width * i, startPos.Y);
                //g.DrawRectangle(emptyPen, new Rectangle(newTechPos, boxSize));

                DrawHelper(g, mouseIndex.X, mouseIndex.Y, selectedPen, regularText, "");
            }
        }

        public void DrawHelper(Graphics g, int techIndex, int modIndex, Pen boxColor, Brush fontColor, String name)
        {
            Point pos = new Point(frmSkillCrafter.startPos.X + techIndex * frmSkillCrafter.boxSize.Width,
                                  frmSkillCrafter.startPos.Y + modIndex * frmSkillCrafter.boxSize.Height);

            g.DrawRectangle(boxColor, new Rectangle(pos, frmSkillCrafter.boxSize));
            g.DrawString(name, frmSkillCrafter.font, fontColor, pos);
        }

        private Point CursorToIndices()
        {
            Point mousePos = this.PointToClient(Cursor.Position);
            Point indices = new Point();
            
            //Determine X
            indices.X = (mousePos.X - startPos.X) / boxSize.Width;
            indices.Y = (mousePos.Y - startPos.Y) / boxSize.Height;

            if (indices.X < 0) indices.X = 0;
            else if (indices.X > selectedSkill.Techniques.Count) indices.X = selectedSkill.Techniques.Count;

            if (indices.Y < 0 || indices.X == selectedSkill.Techniques.Count) indices.Y = 0;
            else
            {
                int modCount = selectedSkill.Techniques[indices.X].Modifiers.Count + 1;
                
                if (indices.Y > modCount) indices.Y = modCount;
            }

            return indices;
        }

        private void frmSkillCrafter_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectedSkill != null)
            {
                Point mouseIndex = CursorToIndices();

                SkillTechnique tech;

                if (mouseIndex.X < selectedSkill.Techniques.Count)
                {
                    tech = selectedSkill.Techniques[mouseIndex.X];

                    if (mouseIndex.Y == 0)
                    {
                        SkillPartInfo info = frmSkillPicker.Show(this, GameData.Current.TechsInfo);

                        if (info == null)
                        {
                            selectedSkill.Techniques.Remove(tech);
                        }
                        else
                        {
                            tech.PartInfo = info;
                        }
                    }
                    else if (mouseIndex.Y <= tech.Modifiers.Count)
                    {
                        SkillModifier mod = tech.Modifiers[mouseIndex.Y - 1];

                        SkillPartInfo info = frmSkillPicker.Show(this, GameData.Current.ModsInfo);

                        if (info == null)
                        {
                            tech.Modifiers.Remove(mod);
                        }
                        else
                        {
                            mod.PartInfo = info;
                        }
                    }
                    else
                    {
                        SkillPartInfo info = frmSkillPicker.Show(this, GameData.Current.ModsInfo);

                        if (info != null)
                        {
                            tech.Modifiers.Add(new SkillModifier(info, 1));
                        }
                    }
                }
                else
                {
                    SkillPartInfo info = frmSkillPicker.Show(this, GameData.Current.TechsInfo);

                    if (info != null)
                    {
                        tech = new SkillTechnique((SkillTechniqueInfo)info, 1);

                        selectedSkill.Techniques.Add(tech);
                    }
                }

                //if (mouseIndex.Y == 0) //It's a technique
                //{
                //    if (mouseIndex.X < skill.Techniques.Count)
                //    {

                //    }
                //    else
                //    {

                //    }
                //}
                //else
                //{

                //}

                RefreshDescription();
            }
        }

        private void cboSkill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSkill.SelectedIndex < 0)
            {
                selectedSkill = null;
            }
            else if (cboSkill.SelectedIndex == cboSkill.Items.Count - 1)
            {
                selectedSkill = new Skill();
                currentCharacter.Skills.Add(selectedSkill);
                cboSkill.Items.Add("New Skill...");
            }
            else
            {
                selectedSkill = (Skill)cboSkill.SelectedItem;
            }
            RefreshDescription();
        }
    }
}
