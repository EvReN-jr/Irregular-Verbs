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

namespace ING_PERFORMANS
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();

        }

        System.Media.SoundPlayer sest = new System.Media.SoundPlayer();
        System.Media.SoundPlayer sesf = new System.Media.SoundPlayer();
        int a = -1;

        int i3 = 0;
        int j3 = 1;
        int art3 = 1;

        int i1 = 0;
        int j1 = 1;
        int art1 = 1;

        int i2 = 0;
        int j2 = 1;
        int art2 = 1;
        //initiation
        private void getverb()
        {
            txt.Clear();
            txt1.Clear();
            textBox_clear();
            textBox_add();
            lst_v2.Items.Clear();
            lst_v3.Items.Clear();
            lst_V.Items.Clear();
            a++;
            ad1();
            ad2();
            ad3();
            check1();
            a++;
            check2();
            a++;
            check3();
            btn_pass.Visible = true;
            txt.Focus();
            if (lbl_v1.Text == "a")
            {
                var sonuc = MessageBox.Show("THE GAME IS OVER THANKS FOR PLAYING", "SYSTEM MESSAGE", MessageBoxButtons.OK);
                if (sonuc == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
        private void ad1()
        {
            string ad1 = @"ad1.txt"; // edit the text document we put it in Debug folder
            StreamReader oku = new StreamReader(ad1, Encoding.Default);
            //For Turkish characters that write at the end

            string deger1 = oku.ReadLine();
            while (i1 < j1)
            {
                lbl_v.Text = deger1.ToString();
                lbl_v1.Text = deger1.ToString();
                deger1 = oku.ReadLine();
                i1++;
            }
            char[] boluculer = { ' ', ',', ':', '.' };
            string[] parcalar = lbl_v.Text.Split(boluculer);
            foreach (string parca in parcalar)
            {
                lst_V.Items.Add(parca);
            }//To separate the lines on the line
            art1++;
            j1 += art1;
        }


        private void ad2()
        {
            string ad2 = @"ad2.txt";
            StreamReader oku = new StreamReader(ad2, Encoding.Default);
            string deger2 = oku.ReadLine();
            while (i2 < j2)
            {
                lbl_v2.Text = deger2.ToString();
                deger2 = oku.ReadLine();
                i2++;
            }
            char[] boluculer = { ' ', ',', ':', '.' };
            string[] parcalar = lbl_v2.Text.Split(boluculer);
            foreach (string parca in parcalar)
            {
                lst_V.Items.Add(parca);
            }
            art2++;
            j2 += art1;
        }


        private void ad3()
        {
            string ad3 = @"ad3.txt";
            StreamReader oku = new StreamReader(ad3, Encoding.Default);
            string deger3 = oku.ReadLine();
            while (i3 < j3)
            {
                lbl_v3.Text = deger3.ToString();
                deger3 = oku.ReadLine();
                i3++;
            }
            char[] boluculer = { ' ', ',', ':', '.' };
            string[] parcalar = lbl_v3.Text.Split(boluculer);
            foreach (string parca in parcalar)
            {
                lst_V.Items.Add(parca);
            }
            art3++;
            j3 += art1;
        }

        private void check1()
        {
            string ifade1 = lst_V.Items[0].ToString();
            Random rnd = new Random();
            int tut = 0;
            int[] dizi = new int[ifade1.Length];
            for (int i = 0; i < ifade1.Length; )
            {
                tut = rnd.Next(ifade1.Length + 1);
                bool snc = false;
                for (int j = 0; j < i; j++)
                {
                    if (tut == dizi[j])
                    {
                        snc = true;
                        break;
                    }
                }
                if (!snc)
                {
                    dizi[i++] = tut;
                    // lst_kelime.Items.Add(dizi[i]);
                }
            }
        }//For mix
        private void check2()
        {
            string ifade1 = lst_V.Items[1].ToString();
            Random rnd = new Random();
            int tut = 0;
            int[] dizi = new int[ifade1.Length];
            for (int i = 0; i < ifade1.Length; )
            {
                tut = rnd.Next(ifade1.Length);
                bool snc = false;
                for (int j = 0; j < i; j++)
                {
                    if (tut == dizi[j])
                    {
                        snc = true;
                        break;
                    }
                }
                if (!snc)
                {
                    dizi[i++] = tut;
                    // lst_kelime.Items.Add(dizi[i]);
                }
            }
            TextBox[] txt = new TextBox[dizi.Length];
            int sag = 0;
            foreach (int dz in dizi)
            {
                // lst_v2.Items.Add(ifade1[dz]);
                txt[dz] = new TextBox();
                txt[dz].Text = ifade1[dz].ToString();
                txt[dz].Top = 320;
                txt[dz].Width = 45;
                txt[dz].Multiline = true;
                txt[dz].Height = 60;
                txt[dz].Font = new Font("Microsoft Sans Serif", 35, FontStyle.Bold);
                txt[dz].Left = 250 + sag;
                sag += 50;
                this.Controls.Add(txt[dz]);
            }// To write the mixed verb
        }
        private void check3()
        {
            string ifade1 = lst_V.Items[2].ToString();
            Random rnd = new Random();
            int tut = 0;
            int[] dizi = new int[ifade1.Length];
            for (int i = 0; i < ifade1.Length; )
            {
                tut = rnd.Next(ifade1.Length);
                bool snc = false;
                for (int j = 0; j < i; j++)
                {
                    if (tut == dizi[j])
                    {
                        snc = true;
                        break;
                    }
                }
                if (!snc)
                {
                    dizi[i++] = tut;
                    // lst_kelime.Items.Add(dizi[i]);
                }
            }
            TextBox[] txt = new TextBox[dizi.Length];
            int sag = 0;
            foreach (int dz in dizi)
            {
                //lst_v3.Items.Add(ifade1[dz]);
                txt[dz] = new TextBox();
                txt[dz].Text = ifade1[dz].ToString();
                txt[dz].Top = 320;
                txt[dz].Width = 45;
                txt[dz].Multiline = true;
                txt[dz].Height = 60;
                txt[dz].Font = new Font("Microsoft Sans Serif", 35, FontStyle.Bold);
                txt[dz].Left = 810 + sag;
                sag += 50;
                this.Controls.Add(txt[dz]);
            }
        }
        private void textBox_clear()
        {
            foreach (Control item in this.Controls) // we made the visible of all textBoxes false
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Visible = false;
                }
                foreach (Control items in this.Controls)//we deleted of all textBoxes
                {
                    if (items is TextBox)
                    {
                        TextBox tbox1 = (TextBox)items;
                        this.Controls.Remove(tbox1);
                    }
                }
            }
        }
        TextBox txt = new TextBox();
        TextBox txt1 = new TextBox();
       
        private void textBox_add()
        {
            txt.Top = 384;
            txt.Left = 250;
            txt.Width = 303;
            txt.Height = 60;
            txt.Font = new Font("Microsoft Sans Serif", 35, FontStyle.Bold);
            this.Controls.Add(txt);

            txt1.Top = 384;
            txt1.Left = 810;
            txt1.Width = 303;
            txt1.Height = 65;
            txt1.Font = new Font("Microsoft Sans Serif", 35, FontStyle.Bold);
            this.Controls.Add(txt1);

        }
        int pass = 5;
        private void btn_pass_Click(object sender, EventArgs e)
        {
            pass--;
            btn_pass.Visible = false;
            getverb();
            if (pass == 0)
            {
                MessageBox.Show("Rust Is Over");
                btn_pass.Enabled = false;
            }
            else if (lbl_v1.Text == "a")
            {
                var sonuc = MessageBox.Show("THE GAME IS OVER THANKS FOR PLAYING", "SYSTEM MESSAGE", MessageBoxButtons.OK);
                if (sonuc == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        int p = 0;

        int inft = 5;
        private void tm_inf_Tick(object sender, EventArgs e)
        {
            inft--;
            if (inft == 0)
            {
                txtinf.Visible = false;
                tm_inf.Enabled = false;
                inft = 0;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            lbl_h1.Visible = true;
            txt.Visible = true;
            txt1.Visible = true;
            txt_area1.Visible = true;
            txt_area2.Visible = true;
            lbl_h21.Visible = true;
            lbl_h22.Visible = true;
            lbl_h3.Visible = true;
            lbl_point.Visible = true;
            lbl_v1.Visible = true;
            btn_pass.Visible = true;
            btn_checked.Visible = true;
            btn_start.Visible = false;
            getverb();

            
        }

        TextBox txtinf = new TextBox();
        private void btn_inf_Click(object sender, EventArgs e)
        {
            txtinf.Top = 545;
            txtinf.Left = 1112;
            txtinf.Width = 145;
            txtinf.Height = 120;
            txtinf.Multiline = true;
            txtinf.Visible = true;
            txtinf.Font = new Font("Microsoft Sans Serif", 10);
            txtinf.Text = "Hi guys. This game was made for you. You should to write the 2nd and 3rd versions of the mixed verbs. Don't forget that you have 5 pass rights.";
            this.Controls.Add(txtinf);

            tm_inf.Enabled = true;
            inft = 5;
        }

        private void btn_checked_Click(object sender, EventArgs e)
        {
            sest.SoundLocation = "TRUE.wav";
            sesf.SoundLocation = "FALSE.wav";
            if (txt.Text == lbl_v2.Text && txt1.Text == lbl_v3.Text)
            {
                sest.Play();
                var sonuc = MessageBox.Show("WELL DONE ! TRUE ANSWERS", "SYSTEM MESSAGE", MessageBoxButtons.OK);
                if (sonuc == DialogResult.OK)
                {
                    p += 10;
                    lbl_point.Text = p.ToString();
                    getverb();
                    sest.Stop();
                }
            }
            if (txt.TextLength > 2 && txt1.TextLength > 2 && txt.Text != lbl_v2.Text && txt1.Text == lbl_v3.Text)
            {
                sesf.Play();
                MessageBox.Show("THE PAST SIMPLE FORM OF THE VERB IS INCORRECT TYPE                                    TRY AGAIN", "System Message");
                txt.Clear();
                txt.Focus();
            }
            if (txt.Text == lbl_v2.Text && txt1.Text != lbl_v3.Text)
            {
                sesf.Play();
                MessageBox.Show("THE PAST PARTICIPLE FORM OF THE VERB IS INCORRECT TYPE                                TRY AGAIN", "System Message");
                txt1.Clear();
                txt1.Focus();
            }
            if (txt.TextLength > 2 && txt1.TextLength > 2 && txt.Text != lbl_v2.Text && txt1.Text != lbl_v3.Text)
            {
                sesf.Play();
                MessageBox.Show("THE PAST SIMPLE AND PAST PARTICIPLE FORM OF THE VERB IS INCORRECT TYPE TRY AGAIN", "System Message");
                txt.Clear();
                txt1.Clear();
                txt.Focus();
            }
            if (lbl_v1.Text == "a")
            {
                var sonuc = MessageBox.Show("THE GAME IS OVER THANKS FOR PLAYING", "SYSTEM MESSAGE", MessageBoxButtons.OK);
                if (sonuc == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
   
    }
}
