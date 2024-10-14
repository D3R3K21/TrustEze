namespace TrustEze.Models.Api
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ContractInformation
    {
        public string BookSection { get; set; }
        public string Area { get; set; }

        public string BeginDate { get; set; }
    }

    public class CustomField
    {
        public List<Main> Main { get; set; }
        public List<Detail> Details { get; set; }
    }

    public class Detail
    {
        public List<View> View { get; set; }

        public List<LotFeature> LotFeatures { get; set; }
    }

    public class DisplayCompliance
    {
        public IDXLogoSmall IDXLogoSmall { get; set; }
        public string View { get; set; }
        public IDXLogo IDXLogo { get; set; }
    }

    public class Document
    {
        public string ResourceUri { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Uri { get; set; }
    }

    public class Field
    {
        public string RoomName { get; set; }

        public string RoomLevel { get; set; }

        public string NoofRooms { get; set; }
        public string Area { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }

        public string RoomRemarks { get; set; }
    }

    public class GeneralPropertyDescription
    {
        public string RealtorCOMType { get; set; }
        public string Style { get; set; }
        public string Basement { get; set; }
        public int? Stories { get; set; }

        public string GarageType { get; set; }

        public string GarageStall { get; set; }

        public int? SqFtB { get; set; }

        public int? SqFt1 { get; set; }

        public int? SqFt2 { get; set; }

        public string SqFtSource { get; set; }
        public string NewConstruction { get; set; }
        public double? LotAcres { get; set; }

        public string LotType1 { get; set; }

        public string LotType2 { get; set; }

        public string LakeRiverName { get; set; }
    }

    public class IDXLogo
    {
        public string LogoUri { get; set; }
        public string Type { get; set; }
    }

    public class IDXLogoSmall
    {
        public string LogoUri { get; set; }
        public string Type { get; set; }
    }

    public class LotFeature
    {
        public bool Irregular { get; set; }
        public bool? Level { get; set; }
    }

    public class Main
    {
        public List<ContractInformation> ContractInformation { get; set; }

        public List<GeneralPropertyDescription> GeneralPropertyDescription { get; set; }
    }

    public class OpenHouse
    {
        public string ResourceUri { get; set; }
        public string Id { get; set; }
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }

    public class Pagination
    {
        public int TotalRows { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
    }

    public class Photo
    {
        public string ResourceUri { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Caption { get; set; }
        public string UriThumb { get; set; }
        public string Uri300 { get; set; }
        public string Uri640 { get; set; }
        public string Uri800 { get; set; }
        public string Uri1024 { get; set; }
        public string Uri1280 { get; set; }
        public string Uri1600 { get; set; }
        public string Uri2048 { get; set; }
        public string UriLarge { get; set; }
        public bool Primary { get; set; }
    }

    public class Result
    {
        public string ResourceUri { get; set; }
        public string Id { get; set; }
        public StandardFields StandardFields { get; set; }
        public List<CustomField> CustomFields { get; set; }
        public DisplayCompliance DisplayCompliance { get; set; }
    }

    public class Room
    {
        public string Id { get; set; }
        public string ResourceUri { get; set; }
        public List<Field> Fields { get; set; }
    }

    public class ListingResponse
    {
        public bool Success { get; set; }
        public List<Result> Results { get; set; }
        public Pagination Pagination { get; set; }
    }

    public class StandardFields
    {
        public string ListingKey { get; set; }
        public string ListingId { get; set; }
        public string PropertyType { get; set; }
        public string PropertySubType { get; set; }
        public int ListPrice { get; set; }
        public string StreetNumber { get; set; }
        public object StreetDirPrefix { get; set; }
        public string StreetName { get; set; }
        public string StreetSuffix { get; set; }
        public string StreetDirSuffix { get; set; }
        public object StreetAdditionalInfo { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string PostalCode { get; set; }
        public int YearBuilt { get; set; }
        public int BuildingAreaTotal { get; set; }
        public int BathsThreeQuarter { get; set; }
        public int BathsTotal { get; set; }
        public int BathsFull { get; set; }
        public int BedsTotal { get; set; }
        public int BathsHalf { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string SubdivisionName { get; set; }
        public string MLSAreaMinor { get; set; }
        public object CountyOrParish { get; set; }
        public string PublicRemarks { get; set; }
        public string PrivateRemarks { get; set; }
        public string PrivateOfficeRemarks { get; set; }
        public string PendingDate { get; set; }
        public string CloseDate { get; set; }
        public string CancelDate { get; set; }
        public string WithdrawDate { get; set; }
        public string ListAgentFirstName { get; set; }
        public string ListAgentMiddleName { get; set; }
        public string ListAgentLastName { get; set; }
        public string ListAgentPreferredPhone { get; set; }
        public string ListAgentPreferredPhoneExt { get; set; }
        public string ListAgentOfficePhone { get; set; }
        public string ListAgentOfficePhoneExt { get; set; }
        public string ListAgentCellPhone { get; set; }
        public string ListAgentDirectPhone { get; set; }
        public string ListAgentTollFreePhone { get; set; }
        public string ListAgentFax { get; set; }
        public string ListAgentPager { get; set; }
        public string ListAgentVoiceMail { get; set; }
        public string ListAgentVoiceMailExt { get; set; }
        public string ListAgentEmail { get; set; }
        public string ListAgentURL { get; set; }
        public string ListAgentStateLicense { get; set; }
        public string ListAgentDesignation { get; set; }
        public string ListOfficeName { get; set; }
        public string ListOfficePhone { get; set; }
        public string ListOfficePhoneExt { get; set; }
        public string ListOfficeFax { get; set; }
        public string ListOfficeEmail { get; set; }
        public string ListOfficeURL { get; set; }
        public string CoListAgentFirstName { get; set; }
        public string CoListAgentMiddleName { get; set; }
        public string CoListAgentLastName { get; set; }
        public string CoListAgentPreferredPhone { get; set; }
        public string CoListAgentPreferredPhoneExt { get; set; }
        public string CoListAgentOfficePhone { get; set; }
        public string CoListAgentOfficePhoneExt { get; set; }
        public string CoListAgentCellPhone { get; set; }
        public string CoListAgentDirectPhone { get; set; }
        public string CoListAgentTollFreePhone { get; set; }
        public string CoListAgentFax { get; set; }
        public string CoListAgentPager { get; set; }
        public string CoListAgentVoiceMail { get; set; }
        public string CoListAgentVoiceMailExt { get; set; }
        public string CoListAgentEmail { get; set; }
        public string CoListAgentURL { get; set; }
        public string CoListAgentStateLicense { get; set; }
        public string CoListAgentDesignation { get; set; }
        public string CoListOfficeName { get; set; }
        public string CoListOfficePhone { get; set; }
        public string CoListOfficePhoneExt { get; set; }
        public string CoListOfficeFax { get; set; }
        public string CoListOfficeEmail { get; set; }
        public string CoListOfficeURL { get; set; }
        //TODO left off here
        public DateTime ModificationTimestamp { get; set; }
        public string VirtualTourURLBranded { get; set; }
        public string VirtualTourURLUnbranded { get; set; }
        public string Supplement { get; set; }
        public List<Photo> Photos { get; set; }
        public List<OpenHouse> OpenHouses { get; set; }
        public List<Document> Documents { get; set; }
        public List<VirtualTour> VirtualTours { get; set; }
        public List<Video> Videos { get; set; }
        public List<Room> Rooms { get; set; }
    }

    public class Video
    {
        public string ResourceUri { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Caption { get; set; }
        public string Type { get; set; }
        public string ObjectHtml { get; set; }
    }

    public class View
    {
        public bool Mountain { get; set; }
        public bool? River { get; set; }
    }

    public class VirtualTour
    {
        public string ResourceUri { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Uri { get; set; }
        public string Type { get; set; }
    }


}
