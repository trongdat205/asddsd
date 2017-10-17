using DemoShop.Model.Abstract;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace DemoShop.Model.Models
{
	[Table("Products")]
	public class Product: Auditable
	{
		public int ID { set; get; }
		public string Name { set; get; }
		public string Alias { set; get; }
		public int CategoryID { set; get; }
		public string Image { set; get; }
		public XElement MoreImage { set; get; }
		public decimal Price { set; get; }
		public decimal? PromotionPrice { set; get; }

		public int? Warranty { set; get; }
		public string Description { set; get; }


		[ForeignKey("CategoryID")]
		public virtual ProductCategory ProductCategory { set; get; }
	}
}