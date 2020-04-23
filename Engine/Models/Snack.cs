using System.Xml;
using System.Xml.Linq;

namespace Engine.Models
{
    public class Snack
    {
        public int ID;
        public string Name;
        public string Price;
        public string Type;

        public Snack(string name, string price, string type)
        {
            this.ID = 1000;
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }

        public void SaveSnack()
        {
            
            XDocument snacksDocument= XDocument.Load(@"F:\ProjectB\Engine\Resources\snacks.xml");
            
            snacksDocument.Element("Snacks").Add(
                new XElement("snack", new XAttribute("ID", this.ID),
                    new XElement("Name", this.Name),
                    new XElement("Price", this.Price),
                    new XElement("Type", this.Type)
                    ));

            snacksDocument.Save(@"F:\ProjectB\Engine\Resources\Snacks.xml");


        }
    }
}