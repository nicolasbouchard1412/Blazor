
namespace Tangy_Models.LearnBlazorModel
{
    public class Demo_Product
    {
        public int Id { get;set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public double Price { get; set; }

        public IEnumerable<DemoProduct_Prop> Properties { get; set; }
    }
}
