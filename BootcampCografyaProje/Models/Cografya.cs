using System;
namespace BootcampCografyaProje.Models
{
	public class Cografya
	{
		public int Id { get; set; }
		public string? title { get; set; }
		public string? description { get; set; }
		public string? example { get; set; }
		public string? image { get; set; }
        public string[]? tags { get; set; }

    }
}

