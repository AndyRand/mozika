using Mozika.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Mozika.Domain.Repositories
{
    public interface IPlaylistTrackRepository : IDisposable
    {
        List<PlaylistTrack> GetAll();
        List<PlaylistTrack> GetByPlaylistId(int id);
        List<PlaylistTrack> GetByTrackId(int id);
        PlaylistTrack Add(PlaylistTrack newPlaylistTrack);
        bool Update(PlaylistTrack playlistTrack);
        bool Delete(int id);
    }
}