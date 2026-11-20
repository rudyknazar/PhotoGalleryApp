using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCases
{
    public class GetGalleryUseCase
    {
        private readonly IPhotoRepository _repository;

        public GetGalleryUseCase(IPhotoRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Photo> Execute()
        {
            return _repository.GetAll();
        }
    }
}