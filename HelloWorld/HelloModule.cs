namespace HelloWorld
{
    public class HelloModule
    {
        public string SayHello(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "Name cannot be empty";
            }

            return string.Format("Hello, {0}!", name);
        }
    }
}
