using Contoso_API.Models;

namespace Contoso_API.Service
{
    public class PizzaService
    {

        static List<Pizza> Pizzas { get; }
        static int nextId = 3;
        static PizzaService()
        {
            Pizzas = new List<Pizza>
            {
                new Pizza { Id = "1", Name = "Classic Italiana", IsGlutenFree = false },
                new Pizza { Id = "2", Name = "Veggie", IsGlutenFree = true }
            };
        }

        public static List<Pizza> GetAll() => Pizzas;

        public static Pizza? Get(string id) => Pizzas.FirstOrDefault(p => p.Id == id);

        public static void Add(Pizza pizza)
        {
            pizza.Id = generateId();
            Pizzas.Add(pizza);
        }

        public static void Delete(string id)
        {
            var pizza = Get(id);
            if (pizza is null)
                return;

            Pizzas.Remove(pizza);
        }

        public static void Update(Pizza pizza)
        {
            var index = Pizzas.FindIndex(p => p.Id == pizza.Id);

            if (index == -1)
                return;

            Pizzas[index] = pizza;
        }

        #region Métodos Privado

        private static string generateId()
        {
            return Guid.NewGuid().ToString("N");
        }

        #endregion
    }
}
