using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_lists
{
    public partial class FrmListBox : Form
    {
        public FrmListBox()
        {
            InitializeComponent();

            string[] planets = ["Mercury", "Venus", "Earth", "Mars", "Jupiter"];

            lbxLeft.SelectionMode = SelectionMode.MultiSimple;
            lbxRight.SelectionMode = SelectionMode.MultiSimple;
            lbxLeft.Items.AddRange(planets);

            lbxLeft.Items.Add("Sun");

            //lbxLeft.Items.Remove("Sun");
            //lbxLeft.Items.RemoveAt(0);
            //lbxLeft.Items.Clear();

            // MessageBox.Show(lbxLeft.Items[0].ToString());

            // lbxLeft.SelectedIndex = 1;
            // lbxLeft.SelectedItem = "Earth";
            // lbxLeft.SetSelected(2, true);

            // lbxLeft.SelectedIndices;
            // lbxLeft.SelectedItems;
        }

        private void SwapHandler(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                ListBox source = btn.Tag.ToString() == "toRight" ? lbxLeft : lbxRight;
                ListBox target = btn.Tag.ToString() == "toRight" ? lbxRight : lbxLeft;

                while(source.SelectedItems.Count > 0)
                {
                    string? item = source.SelectedItem as string;
                    target.Items.Add(item);
                    source.Items.Remove(item);
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lbxLeft.BeginUpdate();
            for(int i = 0; i < 10; ++i)
            {
                lbxLeft.Items.Add($"item_{i}");
                Thread.Sleep(100);
            }
            lbxLeft.EndUpdate();
        }
    }
}
