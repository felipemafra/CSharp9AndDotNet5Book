namespace Packt.Shared
{
    public class BusinessClassPassenger
    {
        public override string ToString()
        {
            return $"Business Class";
        }
    }

    public class FirstClassPassenger
    {
        public int AirMiles { get; set; }

        public override string ToString()
        {
            return $"First Class with {AirMiles:N0} air miles";
        }
    }

    public class CoachClassPasenger
    {
        public double CarryOnKG { get; set; }

        public override string ToString()
        {
            return $"Coach Class with {CarryOnKG:N2} KG carry on";
        }
    }
}