namespace Session05Animals
{
    public abstract class Animal
    {
        public int AgeInYears;

        public Animal(int ageInYears)
        {
            AgeInYears = ageInYears;
        }

        // Abstrakt metoddefinition
        public abstract void EatFood();

        // Konkret metoddefinition
        public void Breed()
        {
            /* This implementation does nothing */
        }
    }
}
