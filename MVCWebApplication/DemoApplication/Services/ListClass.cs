namespace DemoApplication.Services
{
    public class ListClass
    {

        public List<string> ListGenders()
        {
            // Basic sample
            return new List<string>() { "Female", "Male" };
        }

        public List<string> ListColors()
        {
            return new List<string>() { "Blue", "Green", "Red", "Yellow" };
        }
    }
}
