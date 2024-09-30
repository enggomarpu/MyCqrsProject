namespace Catalog.Application.Responses
{
	public class ProductResponse
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;

		public string ProductType { get; set; } = string.Empty;
		public string ProductBrand { get; set; } = string.Empty;
	}
}
