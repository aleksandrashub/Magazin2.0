using Avalonia.Media.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session12
{
    public class Users
{
    public string surname { get; set; }
    public string name { get; set; }
    public string otchestvo { get; set; }
    public string role { get; set; }
    public string login { get; set; }
    public string password { get; set; }

}


    public class ProductKorz
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string manufacturer { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public Bitmap image { get; set; }
        public string category { get; set; }
        public string units { get; set; }
        public int quantitySelect { get; set; }

    }
    public class Product
{
    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string manufacturer { get; set; }
    public double price { get; set; }
    public int quantity { get; set; }
    public Bitmap image { get; set; }
    public string category { get; set; }
    public string units { get; set; }

}

public static class Info
{
    public static List<Users> users = new List<Users>()
        {
        new Users()
        {
        surname="Владимиров",
        name="Алексей",
        otchestvo="Николаевич",
        role="admin",
        login="5678",
        password="5678"

        },
        new Users()
        {
        surname="Виноградова",
        name="Мария",
        otchestvo="Захаровна",
        role="user",
        login="1234",
        password="1234"
        }
        };

        public static int codeRole = -1;
        public static int prodForEdit;
        public static List<ProductKorz> productsInKorzina = new List<ProductKorz>();
        public static List<Product> products = new List<Product>();
   /* {
        new Product()
        {
        id=0,
        name="gc4c",
        description="tgc",
        manufacturer="lo",
        price=6556,
        quantity=8978,
        category=2.ToString(),
        units="yh"

        },
        new Product()
        {
        id= 1,
        name="gcc",
        description="mn",
        manufacturer="lo",
        price=43,
        quantity=8978,
        category=2.ToString(),
        units="yh"

        },
         new Product()
        {
        id= 2,
        name="lok",
        description="hdh",
        manufacturer="xcx",
        price=56,
        quantity=77,
        category=4.ToString(),
        units="cg"
        },
          new Product()
        {
        id= 3,
        name="sds",
        description="hdh",
        manufacturer="lok",
        price=23,
        quantity=454,
        category=1.ToString(),
        units="co"
        },
            new Product()
        {
        id= 4,
        name="ere",
        description="hdh",
        manufacturer="pqq",
        price=56645,
        quantity=454,
        category=2.ToString(),
        units="qw"
            }
    };*/
    public static int ind = 0;
        public static int b = 0;
        
    }





}
