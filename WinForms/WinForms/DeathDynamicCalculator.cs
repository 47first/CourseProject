namespace WinForms
{
    public delegate float CalculationsDelegate(float current, float relative);

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

        public IEnumerable<KeyValuePair<int, float>> AsBasic(CalculationsDelegate calculations)
        {
            Dictionary<int, float> result = new();

            float basisValue = _dynamic.First().Value;

            foreach (var item in _dynamic.Skip(1))
                result.Add(item.Key, calculations(item.Value, basisValue));

            return result;
        }

        public IEnumerable<KeyValuePair<int, float>> AsChain(CalculationsDelegate calculations)
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
