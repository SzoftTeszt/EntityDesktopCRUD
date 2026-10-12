using Emberek.Data;
using Emberek.Models;

namespace Emberek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            string nev = txtName.Text.Trim();
            if (string.IsNullOrWhiteSpace(nev))
            {
                MessageBox.Show("A név mezõ nem lehet üres!");
                txtName.Focus();
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Az életkor egészszám legyen!");
                txtAge.Focus();
                return;
            }

            if (age < 0 || age > 120)
            {
                MessageBox.Show("Az életkornak 0 és 120 között kell lennie!");
                txtAge.Focus();
                return;
            }



            using EmberekContext context = new EmberekContext();

            if (sender == btnMentes)
            {

                var ember = new Models.Ember(nev, age);
                context.Emberek.Add(ember);
            }
            if (sender == btnModositas)
            {
                var ember = context.Emberek.Find(((Ember)lstEmberek.SelectedItem).Id);

                if (ember != null)
                {
                    ember.Name = txtName.Text;
                    ember.Age = int.Parse(txtAge.Text);
                }

            }

            context.SaveChanges();

            txtAge.Clear();
            txtName.Clear();
            txtName.Focus();
            emberekBetoltese();

        }



        private void btnModositas_Click(object sender, EventArgs e)
        {
            string nev = txtName.Text.Trim();
            if (string.IsNullOrWhiteSpace(nev))
            {
                MessageBox.Show("A név mezõ nem lehet üres!");
                txtName.Focus();
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Az életkor egészszám legyen!");
                txtAge.Focus();
                return;
            }

            if (age < 0 || age > 120)
            {
                MessageBox.Show("Az életkornak 0 és 120 között kell lennie!");
                txtAge.Focus();
                return;
            }



            using EmberekContext context = new EmberekContext();

            var ember = context.Emberek.Find(((Ember)lstEmberek.SelectedItem).Id);

            if (ember != null)
            {
                ember.Name = txtName.Text;
                ember.Age = int.Parse(txtAge.Text);

            }
            context.SaveChanges();

            txtAge.Clear();
            txtName.Clear();
            txtName.Focus();
            emberekBetoltese();

        }



        private void emberekBetoltese()
        {
            using EmberekContext context = new EmberekContext();
            lstEmberek.Items.Clear();

            //lstEmberek.Items.AddRange(context.Emberek.ToList());

            foreach (var ember in context.Emberek)
            {
                lstEmberek.Items.Add(ember);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            emberekBetoltese();
        }

        private void lstEmberek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmberek.SelectedItem is Ember)
            {
                txtName.Text = ((Ember)lstEmberek.SelectedItem).Name;
                txtAge.Text = ((Ember)lstEmberek.SelectedItem).Age.ToString();
            }



        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            using EmberekContext context = new EmberekContext();

            var ember = context.Emberek.Find(((Ember)lstEmberek.SelectedItem).Id);
            if (ember != null)
            {
                context.Emberek.Remove(ember);
                context.SaveChanges();
            }

            txtAge.Clear();
            txtName.Clear();
            txtName.Focus();
            emberekBetoltese();
        }
    }
}
