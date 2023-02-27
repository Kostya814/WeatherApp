namespace WeatherApp
{
    public enum MeasureUnits
    {
        Celsius,
        Fahrenheit,
        Kelvin
    }

    internal class Weather
    {
        private double _temperature;
        private MeasureUnits _measureUnit = MeasureUnits.Celsius;
        private Patient _patient;

        public double Temperature
        {
            get => _temperature;
        }

        public MeasureUnits MeasureUnit
        {
            get => _measureUnit;
        }

        private Patient Patient
        {
            get => _patient;
        }

        public string PatientName
        {
            get { return Patient != null ? Patient.Name : "Не назначено"; }
        }

        public Weather(double temperature, MeasureUnits measureUnit, Patient city)
        {
            _temperature = temperature;
            _measureUnit = measureUnit;
            _patient = city;
        }


    }
}
