using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poker
{
    public partial class Form1 : Form
    {
        public class card
        {
            int Str = 0;
            int Mast = 0;
            public card(int lvl,int type) {
                Str = lvl;
                Mast = type;
            }
            string Sila = "JQKA";
            public string ToString()
            {
                if (Str < 9)
                {
                    return (2 + Str) + "" + masti[mast];

                }
                else { 
                return Sila[Str-9] + "" + masti[mast];
                }
            }
            public int mast { get => Mast; set => Mast = value; }
            public int  str { get => Str;  set => Str  = value; }
        }
        
        List<card> cards = new List<card>();
        List<card> cardsp1 = new List<card>();
        List<card> cardsp2 = new List<card>();
        public Form1()
        {
            InitializeComponent();
            comboBox1.KeyPress += (sender, e) => e.Handled = true;
            comboBox2.KeyPress += (sender, e) => e.Handled = true;
            comboBox3.KeyPress += (sender, e) => e.Handled = true;
            comboBox4.KeyPress += (sender, e) => e.Handled = true;
            comboBox5.KeyPress += (sender, e) => e.Handled = true;
            comboBox6.KeyPress += (sender, e) => e.Handled = true;
            comboBox7.KeyPress += (sender, e) => e.Handled = true;
            comboBox8.KeyPress += (sender, e) => e.Handled = true;
            comboBox9.KeyPress += (sender, e) => e.Handled = true;
            comboBox10.KeyPress += (sender, e) => e.Handled = true;
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++) {
                    cards.Add(new card(i, j));

                   // Text += " " + cards[((i*4) + j)].ToString();
                }
            }
            Pozdati();
            
        }
        Random r = new Random();
        private void Pozdati() {
            label1.Text = "";
            label2.Text = "";

            for (int i = 0; i < 12; i++)
            {
                cardsp1.Add(cards[r.Next(cards.Count)]);
                cardsp2.Add(cards[r.Next(cards.Count)]);
                label1.Text += cardsp1[i].ToString();
                label2.Text += cardsp2[i].ToString();

                comboBox1.Items.Add(i + 1);
                comboBox2.Items.Add(i + 1);
                comboBox3.Items.Add(i + 1);
                comboBox4.Items.Add(i + 1);
                comboBox5.Items.Add(i + 1);

                comboBox6.Items.Add(i + 1);
                comboBox7.Items.Add(i + 1);
                comboBox8.Items.Add(i + 1);
                comboBox9.Items.Add(i + 1);
                comboBox10.Items.Add(i + 1);

            }
        }

        public static string masti = "♥♦♣♠";
        private void label2_Click(object sender, EventArgs e)
        {

        }
        int[] selectedp1 = new int[10];
        int[] selectedp2 = new int[10];

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!selectedp2.Contains(comboBox6.SelectedIndex + 1)) selectedp2[5] = comboBox6.SelectedIndex + 1; else comboBox6.SelectedIndex = -1;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!selectedp2.Contains(comboBox7.SelectedIndex + 1)) selectedp2[6] = comboBox7.SelectedIndex + 1; else comboBox7.SelectedIndex = -1;

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!selectedp2.Contains(comboBox8.SelectedIndex + 1)) selectedp2[7] = comboBox8.SelectedIndex + 1; else comboBox8.SelectedIndex = -1;

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!selectedp2.Contains(comboBox9.SelectedIndex + 1)) selectedp2[8] = comboBox9.SelectedIndex + 1; else comboBox9.SelectedIndex = -1;

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!selectedp2.Contains(comboBox10.SelectedIndex + 1)) selectedp2[9] = comboBox10.SelectedIndex + 1; else comboBox10.SelectedIndex = -1;

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!selectedp1.Contains(comboBox5.SelectedIndex+1)) selectedp1[4] = comboBox5.SelectedIndex + 1; else comboBox5.SelectedIndex = -1;

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!selectedp1.Contains(comboBox4.SelectedIndex+1)) selectedp1[3] = comboBox4.SelectedIndex + 1; else comboBox4.SelectedIndex = -1;

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!selectedp1.Contains(comboBox3.SelectedIndex+1)) selectedp1[2] = comboBox3.SelectedIndex + 1; else comboBox3.SelectedIndex = -1;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!selectedp1.Contains(comboBox2.SelectedIndex + 1)) selectedp1[1] = comboBox2.SelectedIndex + 1; else comboBox2.SelectedIndex = -1;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!selectedp1.Contains(comboBox1.SelectedIndex + 1)) selectedp1[0] = comboBox1.SelectedIndex + 1; else comboBox1.SelectedIndex = 
                    -1;
        }


        public List<card> GetCards(int[] idnexes,List<card> cards)
        {
            List<card> output = new List<card>();
                for (int i = 0; i < idnexes.Length; i++)
                {
                    try
                    {
                        output.Add(cards[idnexes[i] - 1]);
                    }
                    catch
                    {

                    }
                }
            return output;
        }
        
        public bool HasCard(List<card> input,int lvl)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].str == lvl) return true;
            }
            return false;
        }
        
        public void biggerIntList(List<int> ts,int size)
        {
            for (int i = 0; i < size; i++)
            {
                ts.Add(0);
            }
        }

        public int GetCountOfNumber(List<int> input,int number)
        {
            int output = 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == number)
                {
                    output++;
                }
            }
            return output;
        }

        public List<int> GetCardsCount(List<card> input)
        {
            List<int> output = new List<int>();
            biggerIntList(output, 13);
            for (int i = 0; i < input.Count; i++)
            {
                output[input[i].str]++;
            }
            return output;

        }

        public int GetCountOfCard(List<card> input, int lvl)
        {
            int output = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].str == lvl) output++;
            }
            return output;
        }

        public int GetMinimal(List<card> input)
        {
            int output = 99;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].str < output)
                {
                    output = input[i].str;
                }
            }
            return output;
        }

        public int GetCountOfMast(List<card> input)
        {
            List<int> Finded = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (!Finded.Contains(input[i].mast))
                {
                    Finded.Add(input[i].mast);
                }
            }
            if(Finded.Count == 2)
            {
                if((Finded.Contains(1) && Finded.Contains(2)) || (Finded.Contains(0) && Finded.Contains(3)))
                {
                    return 3;
                }
            }
            return Finded.Count;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            List<card> P1 = GetCards(selectedp2, cardsp2);
            List<card> P2 = GetCards(selectedp1, cardsp1);

            List<int> CountsP1 = GetCardsCount(P1);
            List<int> CountsP2 = GetCardsCount(P2);

            int strP1 = 0;
            int strP2 = 0;

            int MinP1 = GetMinimal(P1);
            int MinP2 = GetMinimal(P2);

            // Text = GetCountOfMast(P1) + "";

            if (HasCard(P1,12) && HasCard(P1, 11) && HasCard(P1, 10) && HasCard(P1, 9) && HasCard(P1, 8) && GetCountOfMast(P1) == 1)
            {
                strP1 = 9999;

            }else if (HasCard(P1, MinP1+4) && HasCard(P1, MinP1+3) && HasCard(P1, MinP1+2) && HasCard(P1, MinP1+1) && HasCard(P1, MinP1) && GetCountOfMast(P1) == 1)
            {
                strP1 = 9900 + MinP1;
            }else if (CountsP1.Contains(4)) {
                strP1 = 9000 + CountsP1.IndexOf(4);
            }
            else if (CountsP1.Contains(3) && CountsP1.Contains(2))
            {
                strP1 = 8900 + CountsP1.IndexOf(3) + CountsP1.IndexOf(2);
            }
            
            else if (P1.Count == 5 && GetCountOfMast(P1) == 1)
            {
                strP1 = 8800;
            }
            else if (HasCard(P1, MinP1 + 4) && HasCard(P1, MinP1 + 3) && HasCard(P1, MinP1 + 2) && HasCard(P1, MinP1 + 1) && HasCard(P1, MinP1))
            {
                strP1 = 8700 + MinP1;
            }
            else if (CountsP1.Contains(3))
            {
                strP1 = 8600 + CountsP1.IndexOf(3);
            }
            else if (GetCountOfNumber(CountsP1,2) == 2)
            {
                strP1 = 8500 + CountsP1.IndexOf(2);
            }
            else if (CountsP1.Contains(2))
            {
                strP1 = 8400 + CountsP1.IndexOf(2);
            }
            else if (P1.Count == 5 && HasCard(P1,12))
            {
                strP1 = 8400 + CountsP1.IndexOf(2);
            }
            else
            {
                for (int i = 0; i < P1.Count; i++)
                {
                    strP1 += P1[i].str;
                }
            }
            if (HasCard(P2, 12) && HasCard(P2, 11) && HasCard(P2, 10) && HasCard(P2, 9) && HasCard(P2, 8) && GetCountOfMast(P2) == 1)
            {
                strP2 = 9999;

            }
            else if (HasCard(P2, MinP2 + 4) && HasCard(P2, MinP2 + 3) && HasCard(P2, MinP2 + 2) && HasCard(P2, MinP2 + 1) && HasCard(P2, MinP2) && GetCountOfMast(P2) == 1)
            {
                strP2 = 9900 + MinP2;
            }
            else if (CountsP2.Contains(4))
            {
                strP2 = 9000 + CountsP2.IndexOf(4);
            }
            else if (CountsP2.Contains(3) && CountsP2.Contains(2))
            {
                strP2 = 8900 + CountsP2.IndexOf(3) + CountsP2.IndexOf(2);
            }

            else if (P2.Count == 5 && GetCountOfMast(P2) == 1)
            {
                strP2 = 8800;
            }
            else if (HasCard(P2, MinP2 + 4) && HasCard(P2, MinP2 + 3) && HasCard(P2, MinP2 + 2) && HasCard(P2, MinP2 + 1) && HasCard(P2, MinP2))
            {
                strP2 = 8700 + MinP2;
            }
            else if (CountsP2.Contains(3))
            {
                strP2 = 8600 + CountsP2.IndexOf(3);
            }
            else if (GetCountOfNumber(CountsP2, 2) == 2)
            {
                strP2 = 8500 + CountsP2.IndexOf(2);
            }
            else if (CountsP2.Contains(2))
            {
                strP2 = 8400 + CountsP2.IndexOf(2);
            }
            else if (P2.Count == 5 && HasCard(P2, 12))
            {
                strP2 = 8400 + CountsP2.IndexOf(2);
            }
            else
            {
                for (int i = 0; i < P2.Count; i++)
                {
                    strP2 += P2[i].str;
                }
            }
            if(strP1 != strP2)
            {
                if(strP1 > strP2)
                {
                    label3.Text = "Первый игрок победил";
                }
                else
                {
                    label3.Text = "Второй игрок победил";
                }
            }
            else
            {
                label3.Text = "Ничия";
            }

        }
    }
}
