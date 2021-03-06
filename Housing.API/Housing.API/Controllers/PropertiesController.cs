﻿using System;
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
using Housing.API.Models;
using Housing.Classes;
using Housing.Classes.Enums;
using Housing.DataModel;


namespace Housing.API.Controllers
{
    public class PropertiesController : ApiController
    {
        private HousingContext db = new HousingContext();

        // GET: api/Properties
        public IQueryable<PropertyWithInformation> GetProperty(DeviceType DeviceType, int CurrentPage=1,string SearchText="")
        {
            int PageElementSize = 0;
            if (DeviceType == DeviceType.SmallDevice)
            {
                PageElementSize = (int)DeviceTypePage.SmallDevice;
            }
            else if (DeviceType == DeviceType.MediumDevice)
            {
                PageElementSize = (int)DeviceTypePage.SmallDevice;
            }
            else if (DeviceType == DeviceType.LargeDevice )
            {
                PageElementSize = (int)DeviceTypePage.LargeDevice;
            }
            else if (DeviceType == DeviceType.ExtraLargeDevice)
            {
                PageElementSize = (int)DeviceTypePage.ExtraLargeDevice;
            }
            int totalPage = (db.Property.Count() + PageElementSize - 1) / PageElementSize;
            var PropertyWithInformations = db.Property
                .Where((s => (s.PropertyDescription.Contains(SearchText) && SearchText.Trim().Length > 0) || SearchText.Trim().Length == 0))
                    .OrderBy(e => e.ID).Skip(PageElementSize * (CurrentPage - 1)).Take(PageElementSize).Select(e => new PropertyWithInformation
                    {
                        ID = e.ID,
                        PropertyCode = e.PropertyCode,
                        PropertyShortDescription = e.PropertyShortDescription,
                        PropertyTypeID = e.PropertyType.ID,
                        PropertyTypeDescription = e.PropertyType.PropertyTypeDescription,
                        PropertyTypeCreatedDate = e.PropertyType.PropertyTypeCreatedDate,
                        PropertyTypeCreatedBy = e.PropertyType.PropertyTypeCreatedBy,
                        PropertyTypeUpdatedDate = e.PropertyType.PropertyTypeUpdatedDate,
                        PropertyTypeUpdatedBy = e.PropertyType.PropertyTypeUpdatedBy,
                        PropertyDescription = e.PropertyDescription,
                        PropertyFeatures = e.PropertyFeatures,
                        PropertyLocation = e.PropertyLocation,
                        IsActive = e.IsActive,
                        PropertyPrice = e.PropertyPrice,
                        Bedrooms = e.Bedrooms,
                        Restrooms = e.Restrooms,
                        CarParks = e.CarParks,
                        AdvertisementTypeID = (int)(e.AdvertisementType),
                        AdvertisementTypeDescription = e.AdvertisementType.ToString(),
                        PropertyAdvertisementStartDate = e.PropertyAdvertisementStartDate,
                        PropertyAdvertisementFinishDate = e.PropertyAdvertisementFinishDate,
                        PropertyCreatedDate = e.PropertyCreatedDate,
                        PropertyCreatedBy = e.PropertyCreatedBy,
                        PropertyUpdatedDate = e.PropertyUpdatedDate,
                        PropertyUpdatedBy = e.PropertyUpdatedBy
                    });
            return PropertyWithInformations;
        }

        // GET: api/Properties/5
        [ResponseType(typeof(Property))]
        public async Task<IHttpActionResult> GetProperty(int id)
        {
            Property property = await db.Property.FindAsync(id);
            if (property == null)
            {
                return NotFound();
            }

            return Ok(property);
        }

        // PUT: api/Properties/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProperty(int id, Property property)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != property.ID)
            {
                return BadRequest();
            }

            db.Entry(property).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PropertyExists(id))
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

        // POST: api/Properties
        [ResponseType(typeof(Property))]
        public async Task<IHttpActionResult> PostProperty(Property property)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Property.Add(property);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = property.ID }, property);
        }

        // DELETE: api/Properties/5
        [ResponseType(typeof(Property))]
        public async Task<IHttpActionResult> DeleteProperty(int id)
        {
            Property property = await db.Property.FindAsync(id);
            if (property == null)
            {
                return NotFound();
            }

            db.Property.Remove(property);
            await db.SaveChangesAsync();

            return Ok(property);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PropertyExists(int id)
        {
            return db.Property.Count(e => e.ID == id) > 0;
        }
    }
}