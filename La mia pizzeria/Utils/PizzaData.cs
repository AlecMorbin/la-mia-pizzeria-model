using La_mia_pizzeria.Models;

namespace La_mia_pizzeria.Utils
{
    public class PizzaData
    {
        private static List<PizzaData> pizzas = new List<PizzaData>();

        public static List<PizzaData> GetPizzas()
        {
            if( pizzas != null )
                return pizzas;

            for (int i = 0; i < 0; i++)
            {
                Pizza pizza = new Pizza(i,"Pizza n-" +i, "Lorem Ipsum is simply dummy text of the printing and typesetting... ","/img/pizza-margherita");
            }


            return pizzas;
        }
    }
}
