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
    public class CodePrefixesController : ApiController
    {
        private HousingContext db = new HousingContext();

        // GET: api/CodePrefixes
        public IQueryable<CodePrefix> GetCodePrefix()
        {
            return db.CodePrefix;
        }

        // GET: api/CodePrefixes/5
        [ResponseType(typeof(CodePrefix))]
        public async Task<IHttpActionResult> GetCodePrefix(int id)
        {
            CodePrefix codePrefix = await db.CodePrefix.FindAsync(id);
            if (codePrefix == null)
            {
                return NotFound();
            }

            return Ok(codePrefix);
        }

        // PUT: api/CodePrefixes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCodePrefix(int id, CodePrefix codePrefix)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != codePrefix.ID)
            {
                return BadRequest();
            }

            db.Entry(codePrefix).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CodePrefixExists(id))
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

        // POST: api/CodePrefixes
        [ResponseType(typeof(CodePrefix))]
        public async Task<IHttpActionResult> PostCodePrefix(CodePrefix codePrefix)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CodePrefix.Add(codePrefix);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = codePrefix.ID }, codePrefix);
        }

        // DELETE: api/CodePrefixes/5
        [ResponseType(typeof(CodePrefix))]
        public async Task<IHttpActionResult> DeleteCodePrefix(int id)
        {
            CodePrefix codePrefix = await db.CodePrefix.FindAsync(id);
            if (codePrefix == null)
            {
                return NotFound();
            }

            db.CodePrefix.Remove(codePrefix);
            await db.SaveChangesAsync();

            return Ok(codePrefix);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CodePrefixExists(int id)
        {
            return db.CodePrefix.Count(e => e.ID == id) > 0;
        }
    }
}