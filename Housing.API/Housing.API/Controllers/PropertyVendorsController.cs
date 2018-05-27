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
    public class PropertyVendorsController : ApiController
    {
        private HousingContext db = new HousingContext();

        // GET: api/PropertyVendors
        public IQueryable<PropertyVendor> GetPropertyVendor()
        {
            return db.PropertyVendor;
        }

        // GET: api/PropertyVendors/5
        [ResponseType(typeof(PropertyVendor))]
        public async Task<IHttpActionResult> GetPropertyVendor(int id)
        {
            PropertyVendor propertyVendor = await db.PropertyVendor.FindAsync(id);
            if (propertyVendor == null)
            {
                return NotFound();
            }

            return Ok(propertyVendor);
        }

        // PUT: api/PropertyVendors/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPropertyVendor(int id, PropertyVendor propertyVendor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != propertyVendor.ID)
            {
                return BadRequest();
            }

            db.Entry(propertyVendor).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PropertyVendorExists(id))
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

        // POST: api/PropertyVendors
        [ResponseType(typeof(PropertyVendor))]
        public async Task<IHttpActionResult> PostPropertyVendor(PropertyVendor propertyVendor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PropertyVendor.Add(propertyVendor);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = propertyVendor.ID }, propertyVendor);
        }

        // DELETE: api/PropertyVendors/5
        [ResponseType(typeof(PropertyVendor))]
        public async Task<IHttpActionResult> DeletePropertyVendor(int id)
        {
            PropertyVendor propertyVendor = await db.PropertyVendor.FindAsync(id);
            if (propertyVendor == null)
            {
                return NotFound();
            }

            db.PropertyVendor.Remove(propertyVendor);
            await db.SaveChangesAsync();

            return Ok(propertyVendor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PropertyVendorExists(int id)
        {
            return db.PropertyVendor.Count(e => e.ID == id) > 0;
        }
    }
}