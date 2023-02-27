namespace WeatherApp
{
    class Patient
    {
        private string _name;

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public Patient(string name)
        {
            _name = name;
        }
    }
}
