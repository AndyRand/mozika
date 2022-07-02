using Mozika.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mozika.Domain.Repositories
{
    public interface ITrackRepository : IDisposable
    {
        List<Track> GetAll();
        Task<List<Track>> GetAllAsync();
        Track GetById(int id);
        List<Track> GetByAlbumId(int id);
        List<Track> GetByGenreId(int id);
        List<Track> GetByMediaTypeId(int id);
        Track Add(Track newTrack);
        bool Update(Track track);
        bool Delete(int id);
        List<Track> GetByInvoiceId(int id);
        List<Track> GetByPlaylistId(int id);
        List<Track> GetByArtistId(int id);
        List<Track> GetAllByName(string name);
    }
}