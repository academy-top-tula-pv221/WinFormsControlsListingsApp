namespace WinFormsControlsListingsApp
{
    public partial class Form1 : Form
    {
        List<string> companies = new List<string>()
        {
            "Yandex", "Mail Group", "Ozon", "Rambler", "Avito"
        };

        List<string> countries = new()
        {
            "Россия", "Китай", "Иран", "Индия", "Венгрия"
        };
        public Form1()
        {
            InitializeComponent();
            //lstBoxCountries.Items.AddRange(countries.ToArray());
            countries.Add("Беларусия");
            countries.Insert(2, "Бразилия");
            //lstBoxCountries.Items.Remove("Иран");
            //lstBoxCountries.Items.RemoveAt(1);

            lstBoxCountries.DataSource = countries;

            lblCountry.Text = "";

            cmbBoxCompanies.Items.AddRange(companies.ToArray());
            AutoCompleteStringCollection comps = new AutoCompleteStringCollection();
            comps.AddRange(companies.ToArray());
            cmbBoxCompanies.AutoCompleteCustomSource = comps;
        }

        private void txtBoxIndex_TextChanged(object sender, EventArgs e)
        {
            lstBoxCountries.SelectedIndex = Int32.Parse(txtBoxIndex.Text);
        }

        private void lstBoxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxCountries.SelectedItems.Count != 0)
            {
                if (lstBoxCountries.SelectionMode != SelectionMode.One)
                {
                    string msg = "";
                    foreach (var item in lstBoxCountries.SelectedItems)
                        msg += item.ToString() + "\n";
                    lblCountry.Text = msg;
                }
                else
                    lblCountry.Text = lstBoxCountries.Items[lstBoxCountries.SelectedIndex].ToString();
            }

        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            //lstBoxCountries.Items.Add(txtBoxCountry.Text);
            countries.Add(txtBoxCountry.Text);
            txtBoxCountry.Text = "";
        }

        private void lstBoxCountries_DoubleClick(object sender, EventArgs e)
        {
            lstBoxCountries.Items.RemoveAt(lstBoxCountries.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(countries.Count > 3)
                countries.RemoveAt(3);
        }
    }
}