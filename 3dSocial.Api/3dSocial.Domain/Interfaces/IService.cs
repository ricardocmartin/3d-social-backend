﻿using _3dSocial.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3dSocial.Domain.Interfaces
{
	public interface IService<T> where T : BaseEntity
	{
		T Post<V>(T obj) where V : AbstractValidator<T>;

		T Put<V>(T obj) where V : AbstractValidator<T>;

		void Delete(T obj);

		T Get(int id);

		IList<T> Get();
	}
}
