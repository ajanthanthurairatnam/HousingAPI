using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Housing.Classes;
using Housing.DataModel;

namespace Housing.API.Controllers
{
    public class BuyersController : ApiController
    {
        private HousingContext db = new HousingContext();

        // GET: api/Buyers
        public IQueryable<Buyer> GetBuyer()
        {
            return db.Buyer;
        }

        // GET: api/Buyers/5
        [ResponseType(typeof(Buyer))]
        public async Task<IHttpActionResult> GetBuyer(int id)
        {
            Buyer buyer = await db.Buyer.FindAsync(id);
            if (buyer == null)
            {
                return NotFound();
            }

            return Ok(buyer);
        }

        // PUT: api/Buyers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutBuyer(int id, Buyer buyer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != buyer.ID)
            {
                return BadRequest();
            }

            db.Entry(buyer).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BuyerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Buyers
        [ResponseType(typeof(Buyer))]
        public async Task<IHttpActionResult> PostBuyer(Buyer buyer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Buyer.Add(buyer);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = buyer.ID }, buyer);
        }

        // DELETE: api/Buyers/5
        [ResponseType(typeof(Buyer))]
        public async Task<IHttpActionResult> DeleteBuyer(int id)
        {
            Buyer buyer = await db.Buyer.FindAsync(id);
            if (buyer == null)
            {
                return NotFound();
            }

            db.Buyer.Remove(buyer);
            await db.SaveChangesAsync();

            return Ok(buyer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BuyerExists(int id)
        {
            return db.Buyer.Count(e => e.ID == id) > 0;
        }
    }
}