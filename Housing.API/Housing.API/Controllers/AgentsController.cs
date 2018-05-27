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
    public class AgentsController : ApiController
    {
        private HousingContext db = new HousingContext();

        // GET: api/Agents
        public IQueryable<Agent> GetAgent()
        {
            return db.Agent;
        }

        // GET: api/Agents/5
        [ResponseType(typeof(Agent))]
        public async Task<IHttpActionResult> GetAgent(int id)
        {
            Agent agent = await db.Agent.FindAsync(id);
            if (agent == null)
            {
                return NotFound();
            }

            return Ok(agent);
        }

        // PUT: api/Agents/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAgent(int id, Agent agent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != agent.ID)
            {
                return BadRequest();
            }

            db.Entry(agent).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgentExists(id))
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

        // POST: api/Agents
        [ResponseType(typeof(Agent))]
        public async Task<IHttpActionResult> PostAgent(Agent agent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Agent.Add(agent);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = agent.ID }, agent);
        }

        // DELETE: api/Agents/5
        [ResponseType(typeof(Agent))]
        public async Task<IHttpActionResult> DeleteAgent(int id)
        {
            Agent agent = await db.Agent.FindAsync(id);
            if (agent == null)
            {
                return NotFound();
            }

            db.Agent.Remove(agent);
            await db.SaveChangesAsync();

            return Ok(agent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AgentExists(int id)
        {
            return db.Agent.Count(e => e.ID == id) > 0;
        }
    }
}