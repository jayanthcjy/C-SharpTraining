namespace DemoFoodApplication.Models
{
    public class Modell
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cuisine { get; set; }

        public Modell(int Id,string Name,string cus) {
            this.Id = Id;
            this.Name = Name;
            this.Cuisine = cus;

        }

        public List<Modell> rest=new List<Modell>() { 
           new Modell(1,"Hello","Burger" ),
           new Modell(2,"Hi","Biryani")

        };
        
    }
}
