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
    public class AuditRecordsController : ApiController
    {
        private HousingContext db = new HousingContext();

        // GET: api/AuditRecords
        public IQueryable<AuditRecord> GetAuditRecord()
        {
            return db.AuditRecord;
        }

        // GET: api/AuditRecords/5
        [ResponseType(typeof(AuditRecord))]
        public async Task<IHttpActionResult> GetAuditRecord(int id)
        {
            AuditRecord auditRecord = await db.AuditRecord.FindAsync(id);
            if (auditRecord == null)
            {
                return NotFound();
            }

            return Ok(auditRecord);
        }

        // PUT: api/AuditRecords/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAuditRecord(int id, AuditRecord auditRecord)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != auditRecord.ID)
            {
                return BadRequest();
            }

            db.Entry(auditRecord).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuditRecordExists(id))
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

        // POST: api/AuditRecords
        [ResponseType(typeof(AuditRecord))]
        public async Task<IHttpActionResult> PostAuditRecord(AuditRecord auditRecord)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AuditRecord.Add(auditRecord);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = auditRecord.ID }, auditRecord);
        }

        // DELETE: api/AuditRecords/5
        [ResponseType(typeof(AuditRecord))]
        public async Task<IHttpActionResult> DeleteAuditRecord(int id)
        {
            AuditRecord auditRecord = await db.AuditRecord.FindAsync(id);
            if (auditRecord == null)
            {
                return NotFound();
            }

            db.AuditRecord.Remove(auditRecord);
            await db.SaveChangesAsync();

            return Ok(auditRecord);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AuditRecordExists(int id)
        {
            return db.AuditRecord.Count(e => e.ID == id) > 0;
        }
    }
}