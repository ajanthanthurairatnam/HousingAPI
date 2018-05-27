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
    public class PropertyAgentsController : ApiController
    {
        private HousingContext db = new HousingContext();

        // GET: api/PropertyAgents
        public IQueryable<PropertyAgent> GetPropertyAgent()
        {
            return db.PropertyAgent;
        }

        // GET: api/PropertyAgents/5
        [ResponseType(typeof(PropertyAgent))]
        public async Task<IHttpActionResult> GetPropertyAgent(int id)
        {
            PropertyAgent propertyAgent = await db.PropertyAgent.FindAsync(id);
            if (propertyAgent == null)
            {
                return NotFound();
            }

            return Ok(propertyAgent);
        }

        // PUT: api/PropertyAgents/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPropertyAgent(int id, PropertyAgent propertyAgent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != propertyAgent.ID)
            {
                return BadRequest();
            }

            db.Entry(propertyAgent).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PropertyAgentExists(id))
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

        // POST: api/PropertyAgents
        [ResponseType(typeof(PropertyAgent))]
        public async Task<IHttpActionResult> PostPropertyAgent(PropertyAgent propertyAgent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PropertyAgent.Add(propertyAgent);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = propertyAgent.ID }, propertyAgent);
        }

        // DELETE: api/PropertyAgents/5
        [ResponseType(typeof(PropertyAgent))]
        public async Task<IHttpActionResult> DeletePropertyAgent(int id)
        {
            PropertyAgent propertyAgent = await db.PropertyAgent.FindAsync(id);
            if (propertyAgent == null)
            {
                return NotFound();
            }

            db.PropertyAgent.Remove(propertyAgent);
            await db.SaveChangesAsync();

            return Ok(propertyAgent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PropertyAgentExists(int id)
        {
            return db.PropertyAgent.Count(e => e.ID == id) > 0;
        }
    }
}