namespace Session10Classes
{
    public class Ingredient
    {
        /// <summary>
        /// Creates a definition of an ingredient for a recipe
        /// </summary>
        /// <param name="amount">The amount required for one portion of food</param>
        /// <param name="unit">The unit for the ingredient amount</param>
        /// <param name="name">The ingredient name</param>
        public Ingredient(double amount, string unit, string name)
        {
            Amount = amount;
            Unit = unit;
            Name = name;
        }

        public string Name { get; }
        public string Unit { get; }
        public double Amount { get; }

        public Ingredient ForPortionsInstance(int portions)
        {
            return ForPortionsStatic(this, portions);
        }

        public static Ingredient ForPortionsStatic(Ingredient ingredient, int portions)
        {
            double amount = ingredient.Amount * portions;

            return new Ingredient(amount, ingredient.Unit, ingredient.Name);
        }

        public static int DefaultAmount = 1;
    }
}