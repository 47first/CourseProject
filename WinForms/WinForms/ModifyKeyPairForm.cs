namespace WinForms
{
    public partial class ModifyKeyPairForm : Form
    {
        private Dictionary<int, float> _dynamic;

        public ModifyKeyPairForm(Dictionary<int, float> dynamic)
        {
            _dynamic = dynamic;

            InitializeComponent();
        }

        private void Add(object sender, EventArgs e)
        {
            if (int.TryParse(yearTextBox.Text, out int year) == false ||
                float.TryParse(deathAmountTextBox.Text, out float deathAmount) == false ||
                _dynamic.ContainsKey(year))
            {
                MessageBox.Show("Некорректно введены данные!");
                return;
            }

            _dynamic.Add(year, deathAmount);

            Close();
        }

        private void Remove(object sender, EventArgs e)
        {
            if (int.TryParse(yearTextBox.Text, out int year) == false ||
                _dynamic.ContainsKey(year) == false)
            {
                MessageBox.Show("Нет данных на удаление с таким годом!");
                return;
            }

            _dynamic.Remove(year);

            Close();
        }
    }
}
