using BLL_Epreuve.Entities;
using Shared_Epreuve.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL = DAL_Epreuve.Entities;
using BLL_Epreuve.Mappers;

namespace BLL_Epreuve.Services
{
    public class ImageService : IImageRepository<Image>
    {
        private readonly IImageRepository<DAL.Image> _repository;
        public ImageService (IImageRepository<DAL.Image> repository)
        {
            _repository = repository;
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Image> Get()
        {
            return _repository.Get().Select(d => d.ToBLL());
        }

        public Image Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert(Image data)
        {
            return _repository.Insert(data.ToDAL());
        }

        public void Update(Image data)
        {
            _repository.Update(data.ToDAL());
        }
    }
}
