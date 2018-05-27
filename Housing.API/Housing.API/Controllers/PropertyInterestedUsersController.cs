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
    public class PropertyInterestedUsersController : ApiController
    {
        private HousingContext db = new HousingContext();

        // GET: api/PropertyInterestedUsers
        public IQueryable<PropertyInterestedUser> GetPropertyInterestedUser()
        {
            return db.PropertyInterestedUser;
        }

        // GET: api/PropertyInterestedUsers/5
        [ResponseType(typeof(PropertyInterestedUser))]
        public async Task<IHttpActionResult> GetPropertyInterestedUser(int id)
        {
            PropertyInterestedUser propertyInterestedUser = await db.PropertyInterestedUser.FindAsync(id);
            if (propertyInterestedUser == null)
            {
                return NotFound();
            }

            return Ok(propertyInterestedUser);
        }

        // PUT: api/PropertyInterestedUsers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPropertyInterestedUser(int id, PropertyInterestedUser propertyInterestedUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != propertyInterestedUser.ID)
            {
                return BadRequest();
            }

            db.Entry(propertyInterestedUser).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PropertyInterestedUserExists(id))
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

        // POST: api/PropertyInterestedUsers
        [ResponseType(typeof(PropertyInterestedUser))]
        public async Task<IHttpActionResult> PostPropertyInterestedUser(PropertyInterestedUser propertyInterestedUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PropertyInterestedUser.Add(propertyInterestedUser);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = propertyInterestedUser.ID }, propertyInterestedUser);
        }

        // DELETE: api/PropertyInterestedUsers/5
        [ResponseType(typeof(PropertyInterestedUser))]
        public async Task<IHttpActionResult> DeletePropertyInterestedUser(int id)
        {
            PropertyInterestedUser propertyInterestedUser = await db.PropertyInterestedUser.FindAsync(id);
            if (propertyInterestedUser == null)
            {
                return NotFound();
            }

            db.PropertyInterestedUser.Remove(propertyInterestedUser);
            await db.SaveChangesAsync();

            return Ok(propertyInterestedUser);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PropertyInterestedUserExists(int id)
        {
            return db.PropertyInterestedUser.Count(e => e.ID == id) > 0;
        }
    }
}