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
    public class PropertyImagesController : ApiController
    {
        private HousingContext db = new HousingContext();

        // GET: api/PropertyImages
        public IQueryable<PropertyImage> GetPropertyImage()
        {
            return db.PropertyImage;
        }

        // GET: api/PropertyImages/5
        [ResponseType(typeof(PropertyImage))]
        public async Task<IHttpActionResult> GetPropertyImage(int id)
        {
            PropertyImage propertyImage = await db.PropertyImage.FindAsync(id);
            if (propertyImage == null)
            {
                return NotFound();
            }

            return Ok(propertyImage);
        }

        // PUT: api/PropertyImages/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPropertyImage(int id, PropertyImage propertyImage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != propertyImage.ID)
            {
                return BadRequest();
            }

            db.Entry(propertyImage).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PropertyImageExists(id))
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

        // POST: api/PropertyImages
        [ResponseType(typeof(PropertyImage))]
        public async Task<IHttpActionResult> PostPropertyImage(PropertyImage propertyImage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PropertyImage.Add(propertyImage);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = propertyImage.ID }, propertyImage);
        }

        // DELETE: api/PropertyImages/5
        [ResponseType(typeof(PropertyImage))]
        public async Task<IHttpActionResult> DeletePropertyImage(int id)
        {
            PropertyImage propertyImage = await db.PropertyImage.FindAsync(id);
            if (propertyImage == null)
            {
                return NotFound();
            }

            db.PropertyImage.Remove(propertyImage);
            await db.SaveChangesAsync();

            return Ok(propertyImage);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PropertyImageExists(int id)
        {
            return db.PropertyImage.Count(e => e.ID == id) > 0;
        }
    }
}