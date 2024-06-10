namespace CarseerTask.Models
{
    public class CarModelRES_ENT
    {
            public List<Model>? Models { get; set; } = null;

    }
    public class Model
    {
        public string? Make_Name { get; set; } = null;
        public string? Model_Name { get; set; } = null;
        public int? ModelId { get; set; } = null;
    }
}
