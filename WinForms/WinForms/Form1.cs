namespace DeathDynamicCalculatorProject
{
    public enum DynamicMethod
    {
        Basis,
        Chain
    }

    public partial class Form1 : Form
    {
        private DeathDynamicCalculator _deathCalculator;
        private DynamicMethod _dynamicMethod = DynamicMethod.Basis;
        private string _calculationMethod = "����������";

        public Form1()
        {
            InitializeComponent();

            _deathCalculator = new(new Dictionary<int, float> {
                { 1995, 1163.5f },
                { 1996, 1113.7f },
                { 1997, 1100.3f },
                { 1998, 1094.1f },
                { 1999, 1187.8f },
                { 2000, 1231.4f },
                { 2001, 1253.1f },
                { 2002, 1308.1f },
                { 2003, 1330.5f },
                { 2004, 1287.7f }
            });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (sender as ComboBox);

            _dynamicMethod = comboBox.SelectedItem switch
            {
                "��������" => DynamicMethod.Basis,
                "������" => DynamicMethod.Chain,
                _ => throw null
            };

            CalculateResult();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (sender as ComboBox);

            _calculationMethod = comboBox.SelectedItem.ToString();

            CalculateResult();
        }

        private void CalculateResult()
        {
            string result = "������! ����������� �������";

            if (_calculationMethod is "�������")
                result = $"������� ��������: {_deathCalculator.Average()}";

            else if (_calculationMethod is "�������������")
            {
                var dynamic = _dynamicMethod switch
                {
                    DynamicMethod.Basis => _deathCalculator.AsBasic(_deathCalculator.Relative),
                    DynamicMethod.Chain => _deathCalculator.AsChain(_deathCalculator.Relative)
                };

                result = $"������������� ��������:{Environment.NewLine}{GetFormatedString(dynamic)}";
            }

            else if (_calculationMethod is "����������")
            {
                var dynamic = _dynamicMethod switch
                {
                    DynamicMethod.Basis => _deathCalculator.AsBasic(_deathCalculator.Absolute),
                    DynamicMethod.Chain => _deathCalculator.AsChain(_deathCalculator.Absolute)
                };

                result = $"���������� ��������:{Environment.NewLine}{GetFormatedString(dynamic)}";
            }

            resultTextBox.Text = result;
        }

        private string GetFormatedString(IEnumerable<KeyValuePair<int, float>> dynamic)
        {
            string result = "";

            foreach (var item in dynamic)
                result += $"{item.Key} - {item.Value}{Environment.NewLine}";

            return result;
        }
    }
}