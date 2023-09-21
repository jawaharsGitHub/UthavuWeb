namespace Uthavu_Models.LearnBlazorModel
{
	public class Product
	{

		public int Id { get; set; }
		public string Name { get; set; }

		public double Price { get; set; }
		public bool IsActive { get; set; }

		public IEnumerable<Size> Sizes { get; set; }


	}
}