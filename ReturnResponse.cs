namespace CarseerTask.Models.Base
{
    public class ReturnResponse<T>
    {
        public T Results { set; get; }
        public int? Count { get; set; } = null;
        public string? Message { get; set; } = null;
        public string? SearchCriteria { get; set; } = null;

    }
}
