namespace Session05Animals
{
    public abstract class Animal
    {
        // Definiera fält
        public int AgeInYears;

        // Definiera egenskap
        // public int AgeInYears { get; set; }

        // Det går även att skriva ut hela logiken
        // private int _ageInYears;
        // public int AgeInYears {
            //get {
                // return _ageInYears;
            //}
            //set {
                //_ageInYears = value; <- värt att komma ihåg;
            //}
        //}

        //Bara get
        // public int AgeInYears { get; }

        // Är lika som
        // public int AgeInYears => _ageInYears;

        // Flera olika konstruktorer
        // Denna läggs till av kompilatorn, om ingen konstruktor finns
        public Animal()
        {

        }

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
