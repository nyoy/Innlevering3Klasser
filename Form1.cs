using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Innlevering3Klasser
{
    public partial class Form1 : Form
    {
        Person person1 = new Person("Ola", 22);
        Person person2 = new Person("Kari", 23);
        Person person3 = new Person("Hermann", 18);
        Person person4 = new Person("Mikkel", 17);
        public Form1()
        {
            InitializeComponent();

            cboVelgPerson.DisplayMember = "Text";
            cboVelgPerson.ValueMember = "Value";

            cboVelgPerson.Items.Add(new { Text = "person1", value = person1 });
            cboVelgPerson.Items.Add(new { Text = "person2", value = person2 });
            cboVelgPerson.Items.Add(new { Text = "person3", value = person3 });
            cboVelgPerson.Items.Add(new { Text = "person4", value = person4 });
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void cboVelgPerson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void btnVisInfo_Click(object sender, EventArgs e) //Henter Navn og Alder
        {
            ComboBox bcboVelgPerson = new ComboBox();

            if (cboVelgPerson.SelectedIndex == 0)
            {
                txtNavn.Text = person1.GetNavn(); 
                txtAlder.Text = Convert.ToString(person1.GetAlder());
            }
            else if (cboVelgPerson.SelectedIndex == 1)
            {
                txtNavn.Text = person2.GetNavn(); 
                txtAlder.Text = Convert.ToString(person2.GetAlder());
            }
            else if (cboVelgPerson.SelectedIndex == 2)
            {
                txtNavn.Text = person3.GetNavn(); 
                txtAlder.Text = Convert.ToString(person3.GetAlder());
            }
            else if (cboVelgPerson.SelectedIndex == 3)
            {
                txtNavn.Text = person4.GetNavn();                 
                txtAlder.Text = Convert.ToString(person4.GetAlder());
            }
        }
        private void btnVisAntall_Click_1(object sender, EventArgs e) //viser hvor mange ganger constructor har vært aktiv
        {
            int antall = Person.GettantallPersoner();
            txtAntallPersoner.Text = Convert.ToString(antall);
        }

        private void btnEndreNavn_Click(object sender, EventArgs e) //bytter navn
        {
            if (cboVelgPerson.SelectedIndex == 0)
            {
                person1.SettNavn(txtNavn.Text);
                txtAlder.Text = Convert.ToString(person1.GetAlder());
            }
            else if (cboVelgPerson.SelectedIndex == 1)
            {
                person2.SettNavn(txtNavn.Text);
                txtAlder.Text = Convert.ToString(person2.GetAlder());
            }
            else if (cboVelgPerson.SelectedIndex == 2)
            {
                person3.SettNavn(txtNavn.Text);
                txtAlder.Text = Convert.ToString(person3.GetAlder());
            }
            else if (cboVelgPerson.SelectedIndex == 3)
            {
                person4.SettNavn(txtNavn.Text);
                txtAlder.Text = Convert.ToString(person4.GetAlder());
            }
        }
    }
}
