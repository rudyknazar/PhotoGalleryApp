using System;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCases
{
    public class AddPhotoUseCase
    {
        private readonly IPhotoRepository _repository;

        public AddPhotoUseCase(IPhotoRepository repository)
        {
            _repository = repository;
        }

        public void Execute(string title, string filePath)
        {
            var photo = new Photo
            {
                Id = new Random().Next(1, 1000),
                Title = title,
                FilePath = filePath,
                UploadDate = DateTime.Now
            };

            if (photo.IsValid())
            {
                _repository.Add(photo);
            }
        }
    }
}