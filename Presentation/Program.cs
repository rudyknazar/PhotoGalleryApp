using System;
using System.Text;
using Domain.Interfaces;
using Application.UseCases;
using Infrastructure.Repositories;

Console.OutputEncoding = Encoding.UTF8;

IPhotoRepository repository = new JsonPhotoRepository("gallery.json");
var addPhotoUseCase = new AddPhotoUseCase(repository);
var getGalleryUseCase = new GetGalleryUseCase(repository);

addPhotoUseCase.Execute("Моє перше фото", "/images/photo1.jpg");
addPhotoUseCase.Execute("Захід сонця над морем", "/images/sunset.png");

Console.WriteLine("=== Список фотографій у галереї ===");
foreach (var p in getGalleryUseCase.Execute())
{
    Console.WriteLine($"[{p.Id}] {p.Title} ({p.FilePath}) - {p.UploadDate}");
}