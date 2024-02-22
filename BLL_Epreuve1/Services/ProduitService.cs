using BLL_Epreuve.Entities;
using BLL_Epreuve.Mappers;
using Shared_Epreuve.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL = DAL_Epreuve.Entities;

namespace BLL_Epreuve.Services
{
    public class ProduitService : IProduitRepository<Produit>
    {
        private readonly IProduitRepository<DAL.Produit> _repository;
        public ProduitService(IProduitRepository<DAL.Produit> repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Produit> Get()
        {
            return _repository.Get().Select(d => d.ToBLL());
        }

        public Produit Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert(Produit data)
        {
            return _repository.Insert(data.ToDAL());
        }

        public void Update(Produit data)
        {
            _repository.Update(data.ToDAL());
        }
    }
}
