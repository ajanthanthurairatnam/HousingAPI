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
    public class PropertyBuyersController : ApiController
    {
        private HousingContext db = new HousingContext();

        // GET: api/PropertyBuyers
        public IQueryable<PropertyBuyer> GetPropertyBuyer()
        {
            return db.PropertyBuyer;
        }

        // GET: api/PropertyBuyers/5
        [ResponseType(typeof(PropertyBuyer))]
        public async Task<IHttpActionResult> GetPropertyBuyer(int id)
        {
            PropertyBuyer propertyBuyer = await db.PropertyBuyer.FindAsync(id);
            if (propertyBuyer == null)
            {
                return NotFound();
            }

            return Ok(propertyBuyer);
        }

        // PUT: api/PropertyBuyers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPropertyBuyer(int id, PropertyBuyer propertyBuyer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != propertyBuyer.ID)
            {
                return BadRequest();
            }

            db.Entry(propertyBuyer).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PropertyBuyerExists(id))
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

        // POST: api/PropertyBuyers
        [ResponseType(typeof(PropertyBuyer))]
        public async Task<IHttpActionResult> PostPropertyBuyer(PropertyBuyer propertyBuyer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PropertyBuyer.Add(propertyBuyer);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = propertyBuyer.ID }, propertyBuyer);
        }

        // DELETE: api/PropertyBuyers/5
        [ResponseType(typeof(PropertyBuyer))]
        public async Task<IHttpActionResult> DeletePropertyBuyer(int id)
        {
            PropertyBuyer propertyBuyer = await db.PropertyBuyer.FindAsync(id);
            if (propertyBuyer == null)
            {
                return NotFound();
            }

            db.PropertyBuyer.Remove(propertyBuyer);
            await db.SaveChangesAsync();

            return Ok(propertyBuyer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PropertyBuyerExists(int id)
        {
            return db.PropertyBuyer.Count(e => e.ID == id) > 0;
        }
    }
}