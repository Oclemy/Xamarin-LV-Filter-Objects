namespace LV_Filter_Objects
{
    class Spacecraft
    {
        public Spacecraft(string name, string propellant, string destination)
        {
            Name = name;
            Propellant = propellant;
            Destination = destination;
        }

        public string Name { get; }

        public string Propellant { get; }

        public string Destination { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}