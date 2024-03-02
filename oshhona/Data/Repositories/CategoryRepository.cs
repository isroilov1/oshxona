using Oshxona.Data.Entities;
using Oshxona.Data.Inrterfaces;
using System;

namespace oshhona.Data.Repositories;

public class CategoryRepository(AppDbContext dbContext)
    : Repository<Category>(dbContext), ICategoryInterface
{
}
