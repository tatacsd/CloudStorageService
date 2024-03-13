using FileTypeChecker.Extensions;
using FileTypeChecker.Types;
using Microsoft.AspNetCore.Http;

namespace CloudStorageServiceApplication.UsesCases.User.UploadProfilePhoto;
public class UploadProfilePhotoUseCase
{
    public void Execute(IFormFile file)
    {
        // TODO: Validate to check if the file is really an image and jpge
        var fileSteam = file.OpenReadStream();
        // Validate all types of images
        //var isImage = FileTypeValidator.IsImage(fileSteam);

        // Validates on JPGE
        var isImage = fileSteam.Is<JointPhotographicExpertsGroup>();

        if (isImage == false)
            throw new Exception("The file type upload is not supported");




    }
}
