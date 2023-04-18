using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProduct
{
    public class Product
    {                                                                                                        
        // ATTRIBUTI

        private int code;
        private string name;
        private string description;

        
        
        
        // COSTRUTTORE
        public Product(string name, string description)
        {
            this.name = name;
            code = 123445567;
            this.description = description;
        }

        // METODI   

        public int getCode()
        {
       
            return code;
        }



        public string getName()
        {
            return  name;
        }

        public string getDescription()
        {
            return "DESCRIZIONE PRODOTTO: " + description;
        }

        





  




    }


    /*
  private int codeProduct;
  public string nameProduct;
  public string desciptionProduct;
  public float priceProduct;
  public float ivaPriceProduct;
*/


















}