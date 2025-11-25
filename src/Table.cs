using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        private List<Dish> order = new List<Dish>();
        public int Number;
        public bool IsOccupied;

        public Table(int number)
        {
            Number = number;
        }

        public bool HasOrders()
        {
            return this.order.Count > 0;
        }

        public void Ocupy()
        {
            this.IsOccupied = true;
        }

        public void Free()
        {
            this.IsOccupied = false;
            this.order.Clear();
        }

        public void AddToOrder(Dish dish)
        {
            order.Add(dish);
        }
        
    }
}