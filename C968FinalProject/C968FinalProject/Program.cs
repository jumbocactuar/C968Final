using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
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

        public void addProduct(Product product)
        {

        }

        public bool removeProduct(int p)
        {

        }

        public Product lookupProduct(int q)
        {

        }

        public void updateProduct(int q, Product p)
        {

        }

        public void addPart(Part p)
        {

        }

        public bool deletePart(int q)
        {

        }

        public Part lookupPart(int q)
        {

        }

        public void updatePart(int q, Part p)
        {

        }
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

        public void addAssociatedPart(Part part)
        {

        }

        public bool removeAssociatedPart(int p)
        {

        }

        public Part lookupAssociatedPart(int p)
        {

        }

        /*// FIXME: is a default constructor necessary?
        // default constructor
        public Product()
        {

        }*/

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

        /*// FIXME: Is a default constructor necessary?
        public Part()
        {

        }*/

        // constructor containing all properties
        public Part(int partID, string name, decimal price, int inStock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
    }

    public class Inhouse : Part
    {
        public int MachineID { get; }

        public Inhouse(int machineID) : base(10, "name", 3.50M, 1, 2, 3) // FIXME: Is the M necessary? Is it for literal values or something?
        {
            MachineID = machineID;
        }
    }

    public class Outsourced : Part
    {
        public string CompanyName { get; }

        public Outsourced(string companyName) : base(11, "name", 3.50M, 1, 2, 3)
        {
            CompanyName = companyName;
        }
    }
}
