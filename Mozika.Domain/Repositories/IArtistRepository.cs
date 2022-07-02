using System;
using System.Collections.Generic;
using Mozika.Domain.Entities;

namespace Mozika.Domain.Repositories
{
    public interface IArtistRepository : IDisposable
    {
        List<Artist> GetAll();
        List<Artist> GetAllWithAlbumsCount();
        Artist GetById(int id);
        Artist Add(Artist newArtist);
        bool Update(Artist artist);
        bool Delete(int id);
        List<Artist> GetAllByName(string name);

    }
}