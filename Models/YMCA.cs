namespace WebYMCA.Models
{
    public class YMCA
    {
        public int Id { get; set; }
        public DateTime Dane { get; set; }

        public double Waga { get; set; }

        public double Wzrost { get; set; }

        public bool Man { get; set; }
        public Calculator CalculateYMCA { get { return new Calculator() { Waga = Waga, Wzrost = Wzrost, Men = Man }; } }
    }
}
