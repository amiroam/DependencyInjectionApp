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
        public Builder()
        {
            _saw = new Saw(); // Builder is responsible for creating its dependencies.
			_hammer = new Hammer();//Builder is responsible for creating its dependencies.
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
                Console.WriteLine("Hello, World!");
            }
        }
    }
}
