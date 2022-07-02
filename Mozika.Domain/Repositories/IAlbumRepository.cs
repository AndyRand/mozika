using System;
using System.Collections.Generic;
using Mozika.Domain.Entities;

namespace Mozika.Domain.Repositories
{
    public interface IAlbumRepository : IDisposable
    {
        List<Album> GetAll();
        Album GetById(int id);
        List<Album> GetByArtistId(int id);
        Album Add(Album newAlbum);
        bool Update(Album album);
        bool Delete(int id);
        List<Album> GetByTitle(string title);
    }
}