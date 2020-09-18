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

        public override string ToString() => $"{PartID}" + $"{Name}" + $"{Price}" + $"{InStock}" + $"{Min}" + $"{Max}"; // FIXME: Revisit this, see how it needs to be to fit into the datagridview

        // FIXME: The example has an abstract method used by the derived classes here--is it necessary?
        // Is this good? Is this necessary?
        public abstract string PartSource();
        // FIXME: I think I'll need something around here to allow switching of parts between in-house and outsourced - think of how to preserve part numbers
        // Can I say something like "if the part number exists, use it?" Will that data survive a move between classes? I think the object will get destroyed and recreated
        // when it moves between the two.
    }

    public class Inhouse : Part
    {
        public int machineID;

        public Inhouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
        : base(partID, name, price, inStock, min, max)
        {
            MachineID = machineID;
        }

        public int MachineID
        {
            get
            {
                return machineID;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(MachineID)} must be >= 0");
                }

                machineID = value;
            }
        }

        public override string PartSource() => $"{MachineID}";

        public override string ToString() => $"{base.ToString()}" + $"{MachineID}";
    }

    public class Outsourced : Part
    {
        public string companyName;

        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
        : base(partID, name, price, inStock, min, max)
        {
            CompanyName = companyName;
        }

        public string CompanyName
        {
            get
            {
                return companyName;
            }

            set
            {
                if (value == null)
                {
                    // FIXME: Do I really need to throw an exception here? If so, what kind? ArgumentOutOfRangeException?
                    throw new ArgumentNullException(nameof(value), $"{nameof(CompanyName)} must not be null");
                }

                companyName = value;
            }
        }

        public override string PartSource() => $"{CompanyName}"; // FIXME: Does this need the string interpolation stuff? It's already a string.

        public override string ToString() => $"{base.ToString()}" + $"{CompanyName}";
    }
}
