﻿using Database.IRepositories.Auth;
using Database.IRepositories.Book_;
using Database.IRepositories.Classification;
using Database.IRepositories.Creators;
using Database.IRepositories.User_;
using System;
using System.Threading.Tasks;

namespace Database.IUnitOfWork
{
	public interface IUnitOfWork : IDisposable
	{
		ISecurityRepository Security { get; }
		ISessionRepository Session { get; }

		IBookRepository Book { get; }
		IRatingRepository Rating { get; }
		IReviewRepository Review { get; }

		ICategoryRepository Category { get; }

		IAuthorRepository Author { get; }
		IPublisherRepository Publisher { get; }

		IMarkedBookRepository MarkedBook { get; }
		IUserRepository User { get; }


		Task SaveChangesAsync();
	}
}
