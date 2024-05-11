using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager productManager = new CarManager(new EfCarDal());

            foreach (var product in productManager.GetAllByBrandId(2))
            {
                Console.WriteLine(product.ModelYear);
            }
        }
    }
}