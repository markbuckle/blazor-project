namespace Models
{
	public class BaseModel
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public BaseModel()
		{
			Name = string.Empty; // Initialize with a default value
		}
	}
}
