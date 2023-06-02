using Service.Data;
using Service.InfraStructure.Dto.Resource;
using Service.InfraStructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.InfraStructure.Implement
{
    public class ImageResourceAppService : IResourceAppService<ImageDto>
    {
        private readonly string _rootPath = "./../../db-data/images";
        public readonly string fileType = "Image/png";

        public ImageDto Get(ImageDto inputImage)
        {
            string coverPath = Path.Combine(_rootPath, inputImage.fileName + "_cover.png");
            string filePath = Path.Combine(_rootPath, inputImage.fileName + ".png");
            try
            {
                if (File.Exists(coverPath))
                {
                    inputImage.Thumbnail = File.ReadAllBytes(coverPath);
                }
                inputImage.Image = File.ReadAllBytes(filePath);
            } catch (Exception e) { return inputImage; }
            return inputImage;
        }

        public bool Upload(ImageDto resource, bool merge = false)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string name)
        {
            throw new NotImplementedException();
        }
    }
}
