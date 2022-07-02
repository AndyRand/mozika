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
    public class PlaylistTrackRepository : IPlaylistTrackRepository
    {
        private readonly DbInfo _dbInfo;

        public PlaylistTrackRepository(DbInfo dbInfo)
        {
            _dbInfo = dbInfo;
        }

        private IDbConnection Connection => new SqlConnection(_dbInfo.ConnectionStrings);
        
        public void Dispose()
        {
            
        }

        public List<PlaylistTrack> GetAll()
        {
            using IDbConnection cn = Connection;
            cn.Open();
            var playListTracks = Connection.Query<PlaylistTrack>("Select * From PlaylistTrack");
            return playListTracks.ToList();
        }

        public List<PlaylistTrack> GetByPlaylistId(int id)
        {
            using var cn = Connection;
            cn.Open();
            var playListTracks = cn.Query<PlaylistTrack>("Select * From PlaylistTrack WHERE ArtistId = @Id", new { id });
            return playListTracks.ToList();
        }

        public List<PlaylistTrack> GetByTrackId(int id)
        {
            using var cn = Connection;
            cn.Open();
            var playListTracks = cn.Query<PlaylistTrack>("Select * From PlaylistTrack WHERE ArtistId = @Id", new { id });
            return playListTracks.ToList();
        }

        public PlaylistTrack Add(PlaylistTrack newPlaylistTrack)
        {
            using var cn = Connection;
            cn.Open();

            cn.Insert(new PlaylistTrack {PlaylistId = newPlaylistTrack.PlaylistId, TrackId = newPlaylistTrack.TrackId});

            return newPlaylistTrack;
        }

        public bool Update(PlaylistTrack playlistTrack)
        {
            try
            {
                using var cn = Connection;
                cn.Open();
                return cn.Update(playlistTrack);
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
                return cn.Delete(new PlaylistTrack {PlaylistId = id});
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}