using System.Security.Policy;

namespace dieLabel251104
{
    public partial class Form1 : Form
    {
        Random rd = new Random();
        int[] freq = new int[7];
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btRoll_Click(object sender, EventArgs e)
        {
            Label[] labels = new Label[]
            {
                dieLabel1, dieLabel2, dieLabel3, dieLabel4, dieLabel5, dieLabel6,
                dieLabel7, dieLabel8, dieLabel9, dieLabel10, dieLabel11, dieLabel12
            };

            for (int i = 1; i < labels.Length; i += 2)
            {
                labels[i].Text = "";
            }

            foreach (var lbl in labels) DisplayDie(lbl);
            

            displayBox.Text = "Face \t Frequency \t percent \n";

            double total = 0.0;
            for (int k = 1; k < freq.Length; k++)
            {
                total += freq[k];
            }

            
            for (int m = 1; m < freq.Length; m++)
            {
                //displayBox.Text += m + "\t\t\t" + freq[m] + "\t\t\t\t" + (freq[m] / total * 100).ToString("F2") + "%\n";
                displayBox.Text += m + "\t\t " + freq[m] + "\t\t\t\t " + String.Format("{0:N}", (freq[m] / total) * 100) + "%\n";
            }
        }

        public void DisplayDie(Label pdie)
        {
            int face = rd.Next(1, 7);
            pdie.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images" + "\\die" + face + ".gif");
            freq[face]++;

        }


    }
}