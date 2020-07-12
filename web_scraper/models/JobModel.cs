﻿using System.ComponentModel.DataAnnotations;

namespace web_scraper.models {

	public class JobModel {
		//REMOVE

		[Key]
		public string JobId { get; set; }

		/**/

		public string PositionHeadline { get; set; }
		public string PositionTitle { get; set; }

		/**/
		/*Url*/
		public string ShortDescription { get; set; }

		/*Location*/
		public string LocationZipCode { get; set; }
		public string LocationCity { get; set; }
		public string LocationCounty { get; set; }
		public string LocationAdress { get; set; }

		/*Job primary info*/
		public string DescriptionHtml { get; set; }
		public string Description { get; set; }

		/*Job secondary info*/
		public string NumberOfPositions { get; set; }
		public string Deadline { get; set; }
		public string Modified { get; set; }

		/**/
		public string Admissioner { get; set; }
		public string AdmissionerWebsite { get; set; }
		public string AdmissionerContactPerson { get; set; }
		public string AdmissionerContactPersonTelephone { get; set; }

		/**/
		public string PositionType { get; set; }
		public string Sector { get; set; }
		/**/
		public string AdvertUrl { get; set; }
		public string ImageUrl { get; set; }
		public string OriginWebsite { get; set; }
		public string ForeignJobId { get; set; }
	}
}