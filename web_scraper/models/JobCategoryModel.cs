﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_scraper.models {

	public class JobCategoryModel {

		[Key]
		public int CategoryId { get; set; }

		[ForeignKey("JobModel")]
		public string JobId { get; set; }

		public string Category { get; set; }
	}
}