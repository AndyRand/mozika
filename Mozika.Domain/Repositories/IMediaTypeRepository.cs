using Mozika.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Mozika.Domain.Repositories
{
    public interface IMediaTypeRepository : IDisposable
    {
        List<MediaType> GetAll();
        MediaType GetById(int id);
        MediaType Add(MediaType newMediaType);
        bool Update(MediaType mediaType);
        bool Delete(int id);
    }
}