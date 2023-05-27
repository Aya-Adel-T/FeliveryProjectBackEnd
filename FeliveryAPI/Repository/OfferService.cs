﻿using FeliveryAPI.Data;
using FeliveryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FeliveryAPI.Repository
{
    public class OfferService : BaseRepoService, IRepository<Offer>
    {
        public OfferService(IDbContextFactory<ElDbContext> context) : base(context)
        {
        }

        public List<Offer> GetAll()
        {
            List<Offer> CategoriesList = new();

            using (var customContext = Context.CreateDbContext())
            {
                CategoriesList = customContext.Offers.ToList();
            }
            return CategoriesList;
        }

        public Offer? GetDetails(int id)
        {
            using var customContext = Context.CreateDbContext();
            return customContext.Offers.Find(id);
        }

        public void Insert(Offer offer)
        {
            using var customContext = Context.CreateDbContext();
            customContext.Offers.Add(offer);
            customContext.SaveChanges();
        }

        public void Update(Offer offer)
        {
            using var customContext = Context.CreateDbContext();
            customContext.Offers.Update(offer);
            customContext.SaveChanges();
        }
        public void Delete(int id)
        {
            using var customContext = Context.CreateDbContext();
            customContext.Offers.Remove(customContext.Offers.Find(id));
            customContext.SaveChanges();
        }
    }
}
