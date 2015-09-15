using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150912Pattern
{
    class AbstractFatoryPattern
    {
        
    }

    public interface AbstractFatory
    {
        IProduct CreateProduct();
    }

    public class ProductAFactory : AbstractFatory
    {
        public IProduct CreateProduct()
        {
            return new ProductA();
        }
    }

    public class ProductBFactory : AbstractFatory
    {
        public IProduct CreateProduct()
        {
            return new ProductB();
        }
    }
}
