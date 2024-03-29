﻿namespace oshhona.BusinesLogic.Interfaces;

public interface IFileService
{
    List<string> UploadMultipleImageWithoutBg(List<IFormFile> files);
    void DeleteMultiple(List<string> fileNames);
    string UploadImage(IFormFile file);
    void DeleteImage(string fileName);
}