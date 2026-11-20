using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IPhotoRepository
    {
        void Add(Photo photo);
        IEnumerable<Photo> GetAll();
    }
}