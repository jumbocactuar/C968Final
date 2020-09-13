using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
// FIXME: Does System.ComponentModel need to be in all the files?
namespace C968FinalProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainScreenForm());
        }
    }

    public class Inventory
    {
        public BindingList<Product> Products { get; }
        public BindingList<Part> AllParts { get; }
    }

    public class Product
    {
        public BindingList<Part> AssociatedPart { get; }
        public int ProductID { get; }
        public string Name { get; }
        public decimal Price { get; }
        public int InStock { get; }
        public int Min { get; }
        public int Max { get; }

        // FIXME: is a default constructor necessary?
        // default constructor
        public Product()
        {

        }

        // constructor containing all properties
        public Product(BindingList<Part> associatedPart, int productID, string name, decimal price, int inStock, int min, int max)
        {
            AssociatedPart = associatedPart;
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
    }

    public abstract class Part
    {
        public int PartID { get; }
        public string Name { get; }
        public decimal Price { get; }
        public int InStock { get; }
        public int Min { get; }
        public int Max { get; }
    }
}
