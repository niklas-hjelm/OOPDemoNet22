namespace OOPDemo
{
    public class Player
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        public int Level { get; set; }

        public bool Alive { get; set; }

        public void PrintName(List<string> apa)
        {
        }

        public void PrintName(string name)
        {

            Console.WriteLine(Name);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Level: {Level}, Alive: {Alive}";
        }
    }
}
