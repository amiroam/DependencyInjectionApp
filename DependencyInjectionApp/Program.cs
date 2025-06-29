namespace DependencyInjectionApp
{
    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Using the hammer!");
        }
    }
    public class Saw
    {
        public void Use()
        {
            Console.WriteLine("Using the saw!");
        }

    }
    public class Builder
    {
        private Saw _saw;
		private Hammer _hammer;
        public Builder(Saw saw,Hammer hammer) // Constructor injection is used to inject dependencies into the Builder class.
		{
            _saw = saw;
			_hammer =hammer;
        }

        public void BuildHouse()
        {
            _saw.Use(); // Builder uses its dependency. 
			_hammer.Use(); // Builder uses its dependency.
            Console.WriteLine("Building a house!");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Saw saw = new Saw();
                Hammer hammer = new Hammer();
                Builder builder = new Builder(saw, hammer); // Dependencies are injected into the Builder class.
                builder.BuildHouse(); // Builder uses its dependencies to build a house.
                Console.WriteLine("House built successfully!");
				Console.ReadKey();
			}
        }
    }
}
