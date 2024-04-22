﻿using Domain.Validation.Models;
using FluentValidation;

namespace Domain.Entities.Book_
{
	public class Rating : Entity<ulong>
	{
		public ValueObjects.Rating Score { get; private set; }


		// Relationships
		public ulong UserID { get; set; }
		public ulong BookID { get; set; }


		// Logic
		public Rating(ValueObjects.Rating score, ulong userID, ulong bookID)
		{
			Score = score;

			UserID = userID;

			BookID = bookID;
		}

		public void Update(ValueObjects.Rating rating)
		{
			Score = rating;

		}
	}
}
