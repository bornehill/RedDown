using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using RedDown.Data.Entities;

namespace RedDown.Data
{
    public class RedDownRepository : IRedDownRepository
    {
        private readonly RedDownContext _ctx;
        private readonly ILogger<RedDownRepository> _logger;

        public RedDownRepository(RedDownContext ctx, ILogger<RedDownRepository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }

        public IEnumerable<RegistryDown> GetRedDownRegistrys() {
            return _ctx.RegistryDowns.Include(q => q.Questions)
                .Include(f => f.Father)
                .Include(m => m.Mother);
        }

        public RegistryDown GetRedDownById(int redDownId)
        {
            return _ctx.RegistryDowns.Where(r => r.Id == redDownId).Include(q => q.Questions)
                .Include(f => f.Father)
                .Include(m => m.Mother).FirstOrDefault();
        }

        public void AddEntity(object model) {
            _ctx.Add(model);
        }

        public void UpdateRegistry(RegistryDown model)
        {
            _ctx.Attach(model);
            _ctx.Entry(model).State = EntityState.Modified;
        }

        public bool SaveAll() {
            return _ctx.SaveChanges() > 0;
        }
    }
}
