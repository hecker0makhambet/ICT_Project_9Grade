using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox2.Hide();
            label3.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if(Convert.ToString(comboBox1.SelectedItem) == "Доверенность")
            {
                comboBox2.Show();
                label3.Show();
                comboBox2.Items.Add("На приобретение недвижимости");
                comboBox2.Items.Add("На сопровождение ребенка");
            }
            else
            {
                comboBox2.Hide();
                label3.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer();
            sound.Stream = WindowsFormsApp1.Properties.Resources.mouse_click;
            sound.Load();
            sound.Play();
            switch (Convert.ToString(comboBox1.SelectedItem))
            {
                case "Резюме":
                    {
                        Resume form3 = new Resume();
                        form3.Show();
                        this.Close();
                        break;
                    }
                case "Доверенность":
                    {
                        if(Convert.ToString(comboBox2.SelectedItem) == "На приобретение недвижимости")
                        {
                            Dover1 form3 = new Dover1();
                            form3.Show();
                            this.Close();
                        }
                        else if(Convert.ToString(comboBox2.SelectedItem) == "На сопровождение ребенка")
                        {
                            Dover2 form3 = new Dover2();
                            form3.Show();
                            this.Close();
                        }
                        break;
                    }
            }
            
            
        }
    }
}
