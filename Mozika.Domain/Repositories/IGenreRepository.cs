using Mozika.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Mozika.Domain.Repositories
{
    public interface IGenreRepository : IDisposable
    {
        List<Genre> GetAll();
        Genre GetById(int id);
        Genre Add(Genre newGenre);
        bool Update(Genre genre);
        bool Delete(int id);
    }
}