using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Mozika.Domain.DbInfo;
using Mozika.Domain.Repositories;
using Mozika.Domain.Entities;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Mozika.AdoNet.Repositories
{
    public class PlaylistRepository : IPlaylistRepository
    {
        private readonly DbInfo _dbInfo;

        public PlaylistRepository(DbInfo dbInfo)
        {
            _dbInfo = dbInfo;
        }

        private IDbConnection Connection => new SqlConnection(_dbInfo.ConnectionStrings);

        public void Dispose()
        {
            
        }

        private bool PlaylistExists(int id) =>
            Connection.ExecuteScalar<bool>("select count(1) from Playlist where PlaylistId = @id", new {id});

        public List<Playlist> GetAll()
        {
            using IDbConnection cn = Connection;
            cn.Open();
            var playlists = Connection.Query<Playlist>("Select * From Playlist");
            return playlists.ToList();
        }

        public Playlist GetById(int id)
        {
            using var cn = Connection;
            cn.Open();
            return cn.QueryFirstOrDefault<Playlist>("Select * From Playlist WHERE PlaylistId = @Id", new {id});
        }

        public Playlist Add(Playlist newPlaylist)
        {
            using var cn = Connection;
            cn.Open();

            newPlaylist.PlaylistId = (int) cn.Insert(new Playlist {Name = newPlaylist.Name});

            return newPlaylist;
        }

        public List<Track> GetTrackByPlaylistId(int id)
        {
            using var cn = Connection;
            cn.Open();
            var tracks = cn.Query<Track>(
                "SELECT Track.* FROM Playlist INNER JOIN PlaylistTrack ON Playlist.PlaylistId = PlaylistTrack.PlaylistId INNER JOIN Track ON PlaylistTrack.TrackId = Track.TrackId WHERE Playlist.PlaylistId = @Id", new { id });
            return tracks.ToList();
        }

        public bool Update(Playlist playlist)
        {
            if (!PlaylistExists(playlist.PlaylistId))
                return false;

            try
            {
                using var cn = Connection;
                cn.Open();
                return cn.Update(playlist);
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using var cn = Connection;
                cn.Open();
                return cn.Delete(new Playlist {PlaylistId = id});
            }
            catch(Exception)
            {
                return false;
            }
        }

        public List<Playlist> GetByTrackId(int id)
        {
            //SELECT PL.PlaylistId, PL.Name FROM Playlist AS PL INNER JOIN PlaylistTrack PLT ON PL.PlaylistId = PLT.PlaylistId WHERE PLT.TrackID = 5
            using var cn = Connection;
            cn.Open();
            var playlists = cn.Query<Playlist>(
                "SELECT PL.PlaylistId, PL.Name FROM Playlist AS PL INNER JOIN PlaylistTrack PLT ON PL.PlaylistId = PLT.PlaylistId WHERE PLT.TrackID = @Id", new { id });
            return playlists.ToList();
        }
    }
}