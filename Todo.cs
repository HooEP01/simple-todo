namespace ConsoleApp1
{
    class Todo(string description)
    {
        public string Description { get; set; } = description;
        public bool Done { get; set; } = false;
    }
}