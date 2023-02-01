namespace FunctionApp1
{
    public class MyService : IMyService
    {
        public int counter { get; set; }
        
        public string GetMyValue()
        {
            if (counter == 0)
            {
                counter++;   
            }

            return "Hello from MyService!";
        }
    }
}