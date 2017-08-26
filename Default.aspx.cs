using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Constructor
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Car myCar = new Car("Oldschool", "Mercedez", 1986, "White");
            //Car myCar = new Car();
            resultLabel.Text =  myCar.displayCarDetails();
        }
        
    }
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

      public Car(string Make, string Model, int Year, string Color)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Color = Color;
        }

        public Car()
        {
            this.Make = "undefined";
            this.Model = "undefined";
            this.Year = 0000;
            this.Color = "undefined";
        }

        public string displayCarDetails()
        {
          return string.Format("Make:{0}-Model:{1}- Year:{2}- Color:{3}", 
                this.Make,
                this.Model, 
               this.Year.ToString(),
                this.Color);
        }
    }
}