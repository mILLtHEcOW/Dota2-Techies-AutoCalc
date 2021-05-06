using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechiesClac
{
    public partial class FormTechiesCalc : Form
    {
        public FormTechiesCalc()
        {
            InitializeComponent();
            AddList();//编组
            ChangeDamage();
        }

        List<TextBox> ListBombdamage = new List<TextBox>();
        private void AddList()//给炸弹TextBox编组
        {
            ListBombdamage.Add(lableBombDamage1);
            ListBombdamage.Add(lableBombDamage2);
            ListBombdamage.Add(lableBombDamage3);
            ListBombdamage.Add(lableBombDamage4);
            ListBombdamage.Add(lableBombDamage5);
            ListBombdamage.Add(lableBombDamage6);
            ListBombdamage.Add(lableBombDamage7);
            ListBombdamage.Add(lableBombDamage8);
            ListBombdamage.Add(lableBombDamage9);
            ListBombdamage.Add(lableBombDamage10);
            ListBombdamage.Add(lableBombDamage11);
            ListBombdamage.Add(lableBombDamage12);
            ListBombdamage.Add(lableBombDamage13);
            ListBombdamage.Add(lableBombDamage14);
            ListBombdamage.Add(lableBombDamage15);
            ListBombdamage.Add(lableBombDamage16);
            ListBombdamage.Add(lableBombDamage17);
            ListBombdamage.Add(lableBombDamage18);
            ListBombdamage.Add(lableBombDamage19);
            ListBombdamage.Add(lableBombDamage20);
        }

        public void ChangeDamage() //批量更改炸弹伤害
        {
            for (int i = 0; i < 20; i++)
            {
                ListBombdamage[i].Text = ClacData.DamageResult(i + 1).ToString();
            }
        }
        public void Blel1_Click(object sender, EventArgs e)
        {
            ClacData.skillLevel = 2;
            ChangeDamage();
        }

        private void Blel2_Click(object sender, EventArgs e)
        {
            ClacData.skillLevel = 3;
            ChangeDamage();
        }

        private void Blel3_Click(object sender, EventArgs e)
        {
            ClacData.skillLevel = 4;
            ChangeDamage();
        }

        private void equipA_CheckedChanged(object sender, EventArgs e)
        {
            if (ClacData.equipA == 0)
                ClacData.equipA = 1;
            else
                ClacData.equipA = 0;
            ChangeDamage();
        }

        private void CustomResistance_TextChanged(object sender, EventArgs e)
        {
            ClacData.resistance = Convert.ToDouble(CustomResistance.Text)/100;
            ChangeDamage();
        }
    }
}
