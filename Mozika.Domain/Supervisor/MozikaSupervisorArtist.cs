using System;
using System.Collections.Generic;
using System.Linq;
using Mozika.Domain.Extensions;
using Mozika.Domain.ApiModels;
using Microsoft.Extensions.Caching.Memory;

namespace Mozika.Domain.Supervisor
{
    public partial class MozikaSupervisor
    {
        public IEnumerable<ArtistApiModel> GetAllArtist()
        {
            var artists = _artistRepository.GetAll().ConvertAll();
            foreach (var artist in artists)
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(string.Concat("Artist-", artist.ArtistId), artist, cacheEntryOptions);
            }
            return artists;
        }

        public IEnumerable<ArtistApiModel> GetAllArtistWithAlbumsCount()
        {
            var artists = _artistRepository.GetAllWithAlbumsCount().ConvertAll();
            foreach (var artist in artists)
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(string.Concat("Artist-", artist.ArtistId), artist, cacheEntryOptions);
            }
            return artists;
        }

        public ArtistApiModel GetArtistById(int id)
        {
            var artistApiModelCached = _cache.Get<ArtistApiModel>(string.Concat("Artist-", id));

            if (artistApiModelCached != null)
            {
                return artistApiModelCached;
            }
            else
            {
                var artistApiModel = (_artistRepository.GetById(id)).Convert();
                artistApiModel.Albums = (GetAlbumByArtistId(artistApiModel.ArtistId)).ToList();

                var cacheEntryOptions =
                    new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(604800));
                _cache.Set(string.Concat("Artist-", artistApiModel.ArtistId), artistApiModel, cacheEntryOptions);

                return artistApiModel;
            }
        }

        public ArtistApiModel AddArtist(ArtistApiModel newArtistApiModel)
        {
            var artist = newArtistApiModel.Convert();

            artist = _artistRepository.Add(artist);
            newArtistApiModel.ArtistId = artist.ArtistId;
            return newArtistApiModel;
        }

        public bool UpdateArtist(ArtistApiModel artistApiModel)
        {
            var artist = _artistRepository.GetById(artistApiModel.ArtistId);

            if (artist == null) return false;
            artist.ArtistId = artistApiModel.ArtistId;
            artist.Name = artistApiModel.Name;

            return _artistRepository.Update(artist);
        }

        public bool DeleteArtist(int id) 
            => _artistRepository.Delete(id);

        public IEnumerable<ArtistApiModel> GetAllArtistByName(string name)
        {
            var artists = _artistRepository.GetAllByName(name);
            return artists.ConvertAll();
        }
    }
}