namespace FunctionApp1
{
    public interface IMyService
    {
        int counter { get; set; }

        public string GetMyValue();
    }
}