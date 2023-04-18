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

        
        
        
        // COSTRUTTORE
        public Product(string name)
        {
            this.name = name;
            code = 123445567;
        }
        
        // METODI   

        public int getCode()
        {
       
            return code;
        }



        public string getInfo()
        {
            return "il nostro prodotto si chiama " + name;
        }


        public void setName(string name) 
        { 
           this.name = name;
        }





        /*
        private int codeProduct;
        public string nameProduct;
        public string desciptionProduct;
        public float priceProduct;
        public float ivaPriceProduct;
  */





    }
      



   















}