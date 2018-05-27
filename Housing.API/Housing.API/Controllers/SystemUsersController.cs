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
    public class SystemUsersController : ApiController
    {
        private HousingContext db = new HousingContext();

        // GET: api/SystemUsers
        public IQueryable<SystemUser> GetSystemUser()
        {
            return db.SystemUser;
        }

        // GET: api/SystemUsers/5
        [ResponseType(typeof(SystemUser))]
        public async Task<IHttpActionResult> GetSystemUser(int id)
        {
            SystemUser systemUser = await db.SystemUser.FindAsync(id);
            if (systemUser == null)
            {
                return NotFound();
            }

            return Ok(systemUser);
        }

        // PUT: api/SystemUsers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSystemUser(int id, SystemUser systemUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != systemUser.ID)
            {
                return BadRequest();
            }

            db.Entry(systemUser).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SystemUserExists(id))
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

        // POST: api/SystemUsers
        [ResponseType(typeof(SystemUser))]
        public async Task<IHttpActionResult> PostSystemUser(SystemUser systemUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SystemUser.Add(systemUser);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = systemUser.ID }, systemUser);
        }

        // DELETE: api/SystemUsers/5
        [ResponseType(typeof(SystemUser))]
        public async Task<IHttpActionResult> DeleteSystemUser(int id)
        {
            SystemUser systemUser = await db.SystemUser.FindAsync(id);
            if (systemUser == null)
            {
                return NotFound();
            }

            db.SystemUser.Remove(systemUser);
            await db.SaveChangesAsync();

            return Ok(systemUser);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SystemUserExists(int id)
        {
            return db.SystemUser.Count(e => e.ID == id) > 0;
        }
    }
}