using System.ComponentModel;

namespace WebYMCA.Models
{
    public class Calculator : INotifyPropertyChanged
    {
        double waga = 80;
        double wzrost = 186;
        bool Man = true;

        public double Waga
        {
            get { return waga; }

            set
            {
                waga = value;
                OnPropertyChanged("Waist");
                OnPropertyChanged("Description");
            }
        }

        public double Wzrost
        {
            get { return wzrost; }

            set
            {
                wzrost = value;
                OnPropertyChanged("Weight");
                OnPropertyChanged("Description");
            }
        }

        public bool Men
        {
            get { return Man; }
            set
            {
                Man = value;
                OnPropertyChanged("IsMale");
                OnPropertyChanged("Description");
            }
        }

        public string Description
        {
            get
            {
                try
                {
                    string description;
                    double YMCA;
                    if (Man == true)
                    {
                        YMCA = (((1.634 * waga) - (0.1804 * wzrost) - 98.42) / (2.2 * wzrost)) * 100;

                        if (YMCA < 5)
                            description = Math.Round(YMCA, 2) + "% - Essential Fat Percent";
                        else if (YMCA < 13)
                            description = Math.Round(YMCA, 2) + "% - Fat Percent for Athletes";
                        else if (YMCA < 17)
                            description = Math.Round(YMCA, 2) + "% - Fitness Level";
                        else if (YMCA < 24)
                            description = Math.Round(YMCA, 2) + "% - Average Level";
                        else 
                            description = Math.Round(YMCA, 2) + "% - Obese Level";

                        return description;
                    }
                    else
                    {
                        YMCA = (((1.634 * waga) - (0.1804 * wzrost) - 76.76) / (2.2 * wzrost)) * 100;

                        if (YMCA < 13)
                            description = Math.Round(YMCA, 2) + "% - Essential Fat Percent";
                        else if (YMCA < 20)
                            description = Math.Round(YMCA, 2) + "% - Fat Percent for Athletes";
                        else if (YMCA < 24)
                            description = Math.Round(YMCA, 2) + "% - Fitness Level";
                        else if (YMCA < 31)
                            description = Math.Round(YMCA, 2) + "% - Average Level";
                        else
                            description = Math.Round(YMCA, 2) + "% - Obese Level";

                        return description;
                    }
                }
                catch (FormatException)
                {
                    return "Something went wrong.";
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;

            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(property);
                handler(this, e);
            }
        }
    }
}
