using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.RepositoryPattern
{
    internal class BeerRepository : IBeerRepository
    {
        private DesignPatternsContext _context;
        public BeerRepository(DesignPatternsContext context)
        {
            _context=context;
        }
        public void Add(Beer data)
        {
            this._context.Add(data);
        }

        public void Delete(int id)
        {
            var beer = _context.Beers.Find(id);
            if (beer != null)
            _context.Beers.Remove(beer);
        }

        public IEnumerable<Beer> Get()
        {
            return _context.Beers.ToList();
        }
        // tambien podria ser  public IEnumerable<Beer> Get() => _context.Beers.ToList();
        

    public Beer Get(int id)
        {
            return _context.Beers.Find(id);
        }

        public void Update(Beer data)
        {
            // modified solo manda los campos a editarse. update manda todo y edita todo a pesar de que algunos campos no se editarán
            _context.Entry(data).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //_context.Beers.Update(data);
        }

        //ojo que ante cualquier modificacion hay que ejecutar SaveChanges para grabar los cambios
        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
