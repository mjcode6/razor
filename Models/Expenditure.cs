namespace razor.Models
{
    public class Expenditure
    {
     
        public string Name { get; set; }
        public string Date { get; set; }

        public string Price { get; set; }


        public Expenditure(string name, string date, string price)
        {
          
            Name = name;
            Date = date;
            Price = price;
        }
    }
}
