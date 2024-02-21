using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL = BLL_Epreuve.Entities;
using DAL = DAL_Epreuve.Entities;
using BLL_Epreuve;

namespace BLL_Epreuve.Services
{
    public class CategorieService : ICategorieRepository<Categorie>
    {
        private readonly ICategorieRepository<DAL.Categorie> _repository;
        public CategorieService (ICategorieRepository<DAL.Categorie> repository)
        {
            _repository = repository;
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Categorie> Get()
        {
            return _repository.Get().Select(d => d.ToBLL());
        }

        public Categorie Get(int id)
        {
            return _repository.Get(id).ToBLL();

        }

        public int Insert(Categorie data)
        {
            return _repository.Insert(data.ToDAL());
        }

        public void Update(Categorie data)
        {
            _repository.Update(data.ToDAL());
        }
    }
}
}
