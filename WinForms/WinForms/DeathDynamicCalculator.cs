namespace WinForms
{
    public enum DynamicMethod
    {
        Basis,
        Chain
    }

    public class DeathDynamicCalculator
    {
        private Dictionary<int, float> _dynamic = new();
        public DeathDynamicCalculator(IEnumerable<KeyValuePair<int, float>> dynamicValues)
        {
            foreach(var value in dynamicValues)
                _dynamic.TryAdd(value.Key, value.Value);
        }

        public float Absolute(float current, float basis) => current - basis;

        public float Average() => _dynamic.Values.Average();

        public float Relative(float current, float basis) => current / basis;

        public IEnumerable<KeyValuePair<int, float>> BasisAbsolute() => MakeBasisCalculations(Absolute);

        public IEnumerable<KeyValuePair<int, float>> ChainAbsolute() => MakeChainCalculations(Absolute);

        public IEnumerable<KeyValuePair<int, float>> BasisRelative() => MakeBasisCalculations(Relative);

        public IEnumerable<KeyValuePair<int, float>> ChainRelative() => MakeChainCalculations(Relative);

        public delegate float CalculationsDelegate(float current, float relative);

        private IEnumerable<KeyValuePair<int, float>> MakeBasisCalculations(CalculationsDelegate calculations)
        {
            Dictionary<int, float> result = new();

            float basisValue = _dynamic.First().Value;

            foreach (var item in _dynamic.Skip(1))
                result.Add(item.Key, calculations(item.Value, basisValue));

            return result;
        }

        private IEnumerable<KeyValuePair<int, float>> MakeChainCalculations(CalculationsDelegate calculations)
        {
            Dictionary<int, float> result = new();

            float prevValue = _dynamic.First().Value;

            foreach (var item in _dynamic.Skip(1))
            {
                result.Add(item.Key, calculations(item.Value, prevValue));
                prevValue = item.Value;
            }

            return result;
        }
    }
}
