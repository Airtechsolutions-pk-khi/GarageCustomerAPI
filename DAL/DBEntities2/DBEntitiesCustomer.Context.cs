﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.DBEntities2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GarageCustomer_Entities : DbContext
    {
        public GarageCustomer_Entities()
            : base("name=GarageCustomer_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Amenity> Amenities { get; set; }
        public virtual DbSet<BodyType> BodyTypes { get; set; }
        public virtual DbSet<CarFavourite> CarFavourites { get; set; }
        public virtual DbSet<CarSell> CarSells { get; set; }
        public virtual DbSet<CarSellImage> CarSellImages { get; set; }
        public virtual DbSet<DiscLocationJunc> DiscLocationJuncs { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Landmark> Landmarks { get; set; }
        public virtual DbSet<LocationJunc> LocationJuncs { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<PackagesInfo> PackagesInfoes { get; set; }
        public virtual DbSet<PushToken> PushTokens { get; set; }
        public virtual DbSet<ReportReview> ReportReviews { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual ObjectResult<sp_CheckCarSellNoPlate_Result> sp_CheckCarSellNoPlate(string registrationNo, Nullable<int> statusID, Nullable<int> customerID)
        {
            var registrationNoParameter = registrationNo != null ?
                new ObjectParameter("RegistrationNo", registrationNo) :
                new ObjectParameter("RegistrationNo", typeof(string));
    
            var statusIDParameter = statusID.HasValue ?
                new ObjectParameter("StatusID", statusID) :
                new ObjectParameter("StatusID", typeof(int));
    
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_CheckCarSellNoPlate_Result>("sp_CheckCarSellNoPlate", registrationNoParameter, statusIDParameter, customerIDParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_DeleteAmenities(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DeleteAmenities", idParameter);
        }
    
        public virtual int sp_DeleteLandmark(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DeleteLandmark", idParameter);
        }
    
        public virtual int sp_DeleteService(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DeleteService", idParameter);
        }
    
        public virtual int sp_DeleteSetting(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DeleteSetting", idParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_GetAmenities_Result> sp_GetAmenities()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAmenities_Result>("sp_GetAmenities");
        }
    
        public virtual ObjectResult<sp_GetAmenitiesByID_Result> sp_GetAmenitiesByID(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAmenitiesByID_Result>("sp_GetAmenitiesByID", idParameter);
        }
    
        public virtual ObjectResult<sp_GetCarSell_CADMIN_Result> sp_GetCarSell_CADMIN(Nullable<System.DateTime> fromdate, Nullable<System.DateTime> todate)
        {
            var fromdateParameter = fromdate.HasValue ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(System.DateTime));
    
            var todateParameter = todate.HasValue ?
                new ObjectParameter("todate", todate) :
                new ObjectParameter("todate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetCarSell_CADMIN_Result>("sp_GetCarSell_CADMIN", fromdateParameter, todateParameter);
        }
    
        public virtual ObjectResult<sp_GetCarSell_CAPI_Result> sp_GetCarSell_CAPI()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetCarSell_CAPI_Result>("sp_GetCarSell_CAPI");
        }
    
        public virtual ObjectResult<sp_GetCarSellById_CADMIN_Result> sp_GetCarSellById_CADMIN(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetCarSellById_CADMIN_Result>("sp_GetCarSellById_CADMIN", idParameter);
        }
    
        public virtual ObjectResult<sp_GetCarSellImages_CAdmin_Result> sp_GetCarSellImages_CAdmin(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetCarSellImages_CAdmin_Result>("sp_GetCarSellImages_CAdmin", idParameter);
        }
    
        public virtual ObjectResult<sp_GetLandmark_Result> sp_GetLandmark()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetLandmark_Result>("sp_GetLandmark");
        }
    
        public virtual ObjectResult<sp_GetLandmarkByID_Result> sp_GetLandmarkByID(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetLandmarkByID_Result>("sp_GetLandmarkByID", idParameter);
        }
    
        public virtual int sp_GetLocationServices()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_GetLocationServices");
        }
    
        public virtual ObjectResult<sp_GetService_Result> sp_GetService()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetService_Result>("sp_GetService");
        }
    
        public virtual ObjectResult<sp_GetServiceByID_Result> sp_GetServiceByID(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetServiceByID_Result>("sp_GetServiceByID", idParameter);
        }
    
        public virtual ObjectResult<sp_GetServices_Result> sp_GetServices()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetServices_Result>("sp_GetServices");
        }
    
        public virtual ObjectResult<sp_GetSetting_Result> sp_GetSetting()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetSetting_Result>("sp_GetSetting");
        }
    
        public virtual ObjectResult<sp_GetSettingByID_Result> sp_GetSettingByID(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetSettingByID_Result>("sp_GetSettingByID", idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_InsertAmenities(string name, string image, Nullable<int> statusID, string arabicName)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var imageParameter = image != null ?
                new ObjectParameter("Image", image) :
                new ObjectParameter("Image", typeof(string));
    
            var statusIDParameter = statusID.HasValue ?
                new ObjectParameter("StatusID", statusID) :
                new ObjectParameter("StatusID", typeof(int));
    
            var arabicNameParameter = arabicName != null ?
                new ObjectParameter("ArabicName", arabicName) :
                new ObjectParameter("ArabicName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertAmenities", nameParameter, imageParameter, statusIDParameter, arabicNameParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> sp_InsertCarSell(string name, string description, string registrationNo, string bodyType, string fuelType, string engineType, string year, Nullable<int> customerID, Nullable<int> makeID, Nullable<int> modelID, string transmition, string kilometer, Nullable<double> price, Nullable<bool> isInspected, Nullable<int> cityID, string address, Nullable<int> carSellAddID, string bodyColor, string assembly, Nullable<int> statusID, Nullable<System.DateTime> createdDate, Nullable<int> createdBy)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var registrationNoParameter = registrationNo != null ?
                new ObjectParameter("RegistrationNo", registrationNo) :
                new ObjectParameter("RegistrationNo", typeof(string));
    
            var bodyTypeParameter = bodyType != null ?
                new ObjectParameter("BodyType", bodyType) :
                new ObjectParameter("BodyType", typeof(string));
    
            var fuelTypeParameter = fuelType != null ?
                new ObjectParameter("FuelType", fuelType) :
                new ObjectParameter("FuelType", typeof(string));
    
            var engineTypeParameter = engineType != null ?
                new ObjectParameter("EngineType", engineType) :
                new ObjectParameter("EngineType", typeof(string));
    
            var yearParameter = year != null ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(string));
    
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(int));
    
            var makeIDParameter = makeID.HasValue ?
                new ObjectParameter("MakeID", makeID) :
                new ObjectParameter("MakeID", typeof(int));
    
            var modelIDParameter = modelID.HasValue ?
                new ObjectParameter("ModelID", modelID) :
                new ObjectParameter("ModelID", typeof(int));
    
            var transmitionParameter = transmition != null ?
                new ObjectParameter("Transmition", transmition) :
                new ObjectParameter("Transmition", typeof(string));
    
            var kilometerParameter = kilometer != null ?
                new ObjectParameter("Kilometer", kilometer) :
                new ObjectParameter("Kilometer", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(double));
    
            var isInspectedParameter = isInspected.HasValue ?
                new ObjectParameter("IsInspected", isInspected) :
                new ObjectParameter("IsInspected", typeof(bool));
    
            var cityIDParameter = cityID.HasValue ?
                new ObjectParameter("CityID", cityID) :
                new ObjectParameter("CityID", typeof(int));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var carSellAddIDParameter = carSellAddID.HasValue ?
                new ObjectParameter("CarSellAddID", carSellAddID) :
                new ObjectParameter("CarSellAddID", typeof(int));
    
            var bodyColorParameter = bodyColor != null ?
                new ObjectParameter("BodyColor", bodyColor) :
                new ObjectParameter("BodyColor", typeof(string));
    
            var assemblyParameter = assembly != null ?
                new ObjectParameter("Assembly", assembly) :
                new ObjectParameter("Assembly", typeof(string));
    
            var statusIDParameter = statusID.HasValue ?
                new ObjectParameter("StatusID", statusID) :
                new ObjectParameter("StatusID", typeof(int));
    
            var createdDateParameter = createdDate.HasValue ?
                new ObjectParameter("CreatedDate", createdDate) :
                new ObjectParameter("CreatedDate", typeof(System.DateTime));
    
            var createdByParameter = createdBy.HasValue ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("sp_InsertCarSell", nameParameter, descriptionParameter, registrationNoParameter, bodyTypeParameter, fuelTypeParameter, engineTypeParameter, yearParameter, customerIDParameter, makeIDParameter, modelIDParameter, transmitionParameter, kilometerParameter, priceParameter, isInspectedParameter, cityIDParameter, addressParameter, carSellAddIDParameter, bodyColorParameter, assemblyParameter, statusIDParameter, createdDateParameter, createdByParameter);
        }
    
        public virtual int sp_insertCarSellFeature_CAPI(Nullable<int> carSellID, string featureId)
        {
            var carSellIDParameter = carSellID.HasValue ?
                new ObjectParameter("CarSellID", carSellID) :
                new ObjectParameter("CarSellID", typeof(int));
    
            var featureIdParameter = featureId != null ?
                new ObjectParameter("FeatureId", featureId) :
                new ObjectParameter("FeatureId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_insertCarSellFeature_CAPI", carSellIDParameter, featureIdParameter);
        }
    
        public virtual int sp_insertCarSellImages_CAPI(string image)
        {
            var imageParameter = image != null ?
                new ObjectParameter("Image", image) :
                new ObjectParameter("Image", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_insertCarSellImages_CAPI", imageParameter);
        }
    
        public virtual int sp_InsertLandmark(string name, string arabicName, string image, Nullable<int> statusID)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var arabicNameParameter = arabicName != null ?
                new ObjectParameter("ArabicName", arabicName) :
                new ObjectParameter("ArabicName", typeof(string));
    
            var imageParameter = image != null ?
                new ObjectParameter("Image", image) :
                new ObjectParameter("Image", typeof(string));
    
            var statusIDParameter = statusID.HasValue ?
                new ObjectParameter("StatusID", statusID) :
                new ObjectParameter("StatusID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertLandmark", nameParameter, arabicNameParameter, imageParameter, statusIDParameter);
        }
    
        public virtual int sp_InsertService(string serviceTitle, string serviceDescription, string image, Nullable<int> displayOrder, Nullable<int> statusID, string type, string arabicServiceTitle, string arabicServiceDescription)
        {
            var serviceTitleParameter = serviceTitle != null ?
                new ObjectParameter("ServiceTitle", serviceTitle) :
                new ObjectParameter("ServiceTitle", typeof(string));
    
            var serviceDescriptionParameter = serviceDescription != null ?
                new ObjectParameter("ServiceDescription", serviceDescription) :
                new ObjectParameter("ServiceDescription", typeof(string));
    
            var imageParameter = image != null ?
                new ObjectParameter("Image", image) :
                new ObjectParameter("Image", typeof(string));
    
            var displayOrderParameter = displayOrder.HasValue ?
                new ObjectParameter("DisplayOrder", displayOrder) :
                new ObjectParameter("DisplayOrder", typeof(int));
    
            var statusIDParameter = statusID.HasValue ?
                new ObjectParameter("StatusID", statusID) :
                new ObjectParameter("StatusID", typeof(int));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var arabicServiceTitleParameter = arabicServiceTitle != null ?
                new ObjectParameter("ArabicServiceTitle", arabicServiceTitle) :
                new ObjectParameter("ArabicServiceTitle", typeof(string));
    
            var arabicServiceDescriptionParameter = arabicServiceDescription != null ?
                new ObjectParameter("ArabicServiceDescription", arabicServiceDescription) :
                new ObjectParameter("ArabicServiceDescription", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertService", serviceTitleParameter, serviceDescriptionParameter, imageParameter, displayOrderParameter, statusIDParameter, typeParameter, arabicServiceTitleParameter, arabicServiceDescriptionParameter);
        }
    
        public virtual int sp_InsertSetting(string title, string description, string image, string alternateImage, string pageName, string type, Nullable<int> displayOrder, Nullable<int> statusID, string arabicTitle, string arabicDescription)
        {
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var imageParameter = image != null ?
                new ObjectParameter("Image", image) :
                new ObjectParameter("Image", typeof(string));
    
            var alternateImageParameter = alternateImage != null ?
                new ObjectParameter("AlternateImage", alternateImage) :
                new ObjectParameter("AlternateImage", typeof(string));
    
            var pageNameParameter = pageName != null ?
                new ObjectParameter("PageName", pageName) :
                new ObjectParameter("PageName", typeof(string));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var displayOrderParameter = displayOrder.HasValue ?
                new ObjectParameter("DisplayOrder", displayOrder) :
                new ObjectParameter("DisplayOrder", typeof(int));
    
            var statusIDParameter = statusID.HasValue ?
                new ObjectParameter("StatusID", statusID) :
                new ObjectParameter("StatusID", typeof(int));
    
            var arabicTitleParameter = arabicTitle != null ?
                new ObjectParameter("ArabicTitle", arabicTitle) :
                new ObjectParameter("ArabicTitle", typeof(string));
    
            var arabicDescriptionParameter = arabicDescription != null ?
                new ObjectParameter("ArabicDescription", arabicDescription) :
                new ObjectParameter("ArabicDescription", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertSetting", titleParameter, descriptionParameter, imageParameter, alternateImageParameter, pageNameParameter, typeParameter, displayOrderParameter, statusIDParameter, arabicTitleParameter, arabicDescriptionParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_updateAmenities_Admin(Nullable<int> amenitiesID, string name, string image, Nullable<int> statusID, string arabicName)
        {
            var amenitiesIDParameter = amenitiesID.HasValue ?
                new ObjectParameter("AmenitiesID", amenitiesID) :
                new ObjectParameter("AmenitiesID", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var imageParameter = image != null ?
                new ObjectParameter("Image", image) :
                new ObjectParameter("Image", typeof(string));
    
            var statusIDParameter = statusID.HasValue ?
                new ObjectParameter("StatusID", statusID) :
                new ObjectParameter("StatusID", typeof(int));
    
            var arabicNameParameter = arabicName != null ?
                new ObjectParameter("ArabicName", arabicName) :
                new ObjectParameter("ArabicName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_updateAmenities_Admin", amenitiesIDParameter, nameParameter, imageParameter, statusIDParameter, arabicNameParameter);
        }
    
        public virtual int sp_updateLandmark_Admin(Nullable<int> landmarkID, string name, string arabicName, string image, Nullable<int> statusID)
        {
            var landmarkIDParameter = landmarkID.HasValue ?
                new ObjectParameter("LandmarkID", landmarkID) :
                new ObjectParameter("LandmarkID", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var arabicNameParameter = arabicName != null ?
                new ObjectParameter("ArabicName", arabicName) :
                new ObjectParameter("ArabicName", typeof(string));
    
            var imageParameter = image != null ?
                new ObjectParameter("Image", image) :
                new ObjectParameter("Image", typeof(string));
    
            var statusIDParameter = statusID.HasValue ?
                new ObjectParameter("StatusID", statusID) :
                new ObjectParameter("StatusID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_updateLandmark_Admin", landmarkIDParameter, nameParameter, arabicNameParameter, imageParameter, statusIDParameter);
        }
    
        public virtual int sp_updateService_Admin(Nullable<int> serviceID, string serviceTitle, string serviceDescription, string arabicServiceTitle, string arabicServiceDescription, Nullable<int> displayOrder, string image, Nullable<int> statusID, string type)
        {
            var serviceIDParameter = serviceID.HasValue ?
                new ObjectParameter("ServiceID", serviceID) :
                new ObjectParameter("ServiceID", typeof(int));
    
            var serviceTitleParameter = serviceTitle != null ?
                new ObjectParameter("ServiceTitle", serviceTitle) :
                new ObjectParameter("ServiceTitle", typeof(string));
    
            var serviceDescriptionParameter = serviceDescription != null ?
                new ObjectParameter("ServiceDescription", serviceDescription) :
                new ObjectParameter("ServiceDescription", typeof(string));
    
            var arabicServiceTitleParameter = arabicServiceTitle != null ?
                new ObjectParameter("ArabicServiceTitle", arabicServiceTitle) :
                new ObjectParameter("ArabicServiceTitle", typeof(string));
    
            var arabicServiceDescriptionParameter = arabicServiceDescription != null ?
                new ObjectParameter("ArabicServiceDescription", arabicServiceDescription) :
                new ObjectParameter("ArabicServiceDescription", typeof(string));
    
            var displayOrderParameter = displayOrder.HasValue ?
                new ObjectParameter("DisplayOrder", displayOrder) :
                new ObjectParameter("DisplayOrder", typeof(int));
    
            var imageParameter = image != null ?
                new ObjectParameter("Image", image) :
                new ObjectParameter("Image", typeof(string));
    
            var statusIDParameter = statusID.HasValue ?
                new ObjectParameter("StatusID", statusID) :
                new ObjectParameter("StatusID", typeof(int));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_updateService_Admin", serviceIDParameter, serviceTitleParameter, serviceDescriptionParameter, arabicServiceTitleParameter, arabicServiceDescriptionParameter, displayOrderParameter, imageParameter, statusIDParameter, typeParameter);
        }
    
        public virtual int sp_updateSetting_Admin(Nullable<int> iD, string title, string description, string image, string alternateImage, string pageName, string type, Nullable<int> statusID, Nullable<int> displayOrder, string arabicTitle, string arabicDescription)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var imageParameter = image != null ?
                new ObjectParameter("Image", image) :
                new ObjectParameter("Image", typeof(string));
    
            var alternateImageParameter = alternateImage != null ?
                new ObjectParameter("AlternateImage", alternateImage) :
                new ObjectParameter("AlternateImage", typeof(string));
    
            var pageNameParameter = pageName != null ?
                new ObjectParameter("PageName", pageName) :
                new ObjectParameter("PageName", typeof(string));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var statusIDParameter = statusID.HasValue ?
                new ObjectParameter("StatusID", statusID) :
                new ObjectParameter("StatusID", typeof(int));
    
            var displayOrderParameter = displayOrder.HasValue ?
                new ObjectParameter("DisplayOrder", displayOrder) :
                new ObjectParameter("DisplayOrder", typeof(int));
    
            var arabicTitleParameter = arabicTitle != null ?
                new ObjectParameter("ArabicTitle", arabicTitle) :
                new ObjectParameter("ArabicTitle", typeof(string));
    
            var arabicDescriptionParameter = arabicDescription != null ?
                new ObjectParameter("ArabicDescription", arabicDescription) :
                new ObjectParameter("ArabicDescription", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_updateSetting_Admin", iDParameter, titleParameter, descriptionParameter, imageParameter, alternateImageParameter, pageNameParameter, typeParameter, statusIDParameter, displayOrderParameter, arabicTitleParameter, arabicDescriptionParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
