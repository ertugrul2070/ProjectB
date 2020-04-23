using System.Security.Cryptography.X509Certificates;

namespace Engine.Models
{
    public class SnackCatalog
    {
        public string[][] Snacks;

        public SnackCatalog()
        {
            this.Snacks = new string[][] {};
        }

        public void AddSnack(string name, string price, string type)
        {
            Snack snack = new Snack(name, price, type);
            snack.SaveSnack();
        }
    }
}