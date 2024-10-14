using Bogus;
using TrustEze.Models.Api;

namespace TrustEze.Models
{
    public static class Fakers
    {
        public static Faker<StandardFields> GetStandardFieldsFaker()
        {
            return new Faker<StandardFields>()
                 .StrictMode(false)
                 .RuleFor(x => x.CoListOfficeURL, y => y.Internet.Url())
                 .RuleFor(x => x.BathsFull, y => y.Random.Number(1, 3))
                 .RuleFor(x => x.ListingKey, y => y.Random.Guid().ToString())
                 .RuleFor(x => x.ListingId, y => y.Random.Guid().ToString())
                 .RuleFor(x => x.PropertyType, y => "Single Family")
                 .RuleFor(x => x.PropertySubType, y => "Single Family")
                 .RuleFor(x => x.ListPrice, y => y.Random.Number(100000, 700000))
                 .RuleFor(x => x.StreetNumber, y => y.Random.Number(0, 6000).ToString())
                 .RuleFor(x => x.StreetDirPrefix, y => "")
                 .RuleFor(x => x.StreetName, y => y.Address.StreetName())
                 .RuleFor(x => x.StreetSuffix, y => y.Address.StreetSuffix())
                 .RuleFor(x => x.StreetDirSuffix, y => "")
                 .RuleFor(x => x.StreetAdditionalInfo, y => "")
                 .RuleFor(x => x.City, y => y.Address.City())
                 .RuleFor(x => x.StateOrProvince, y => y.Address.State())
                 .RuleFor(x => x.PostalCode, y => y.Address.ZipCode())
                 .RuleFor(x => x.YearBuilt, y => y.Random.Number(1960, 2024))
                 .RuleFor(x => x.BuildingAreaTotal, y => y.Random.Number(900, 3000))
                 .RuleFor(x => x.BathsHalf, y => y.Random.Number(0, 1))
                 .RuleFor(x => x.BathsTotal, y => y.Random.Number(0, 4))
                 .RuleFor(x => x.BedsTotal, y => y.Random.Number(1, 5))
                 .RuleFor(x => x.Longitude, y => y.Address.Longitude())
                 .RuleFor(x => x.Latitude, y => y.Address.Latitude())
                 .RuleFor(x => x.SubdivisionName, y => y.Random.Word() + " Heights")
                 .RuleFor(x => x.CountyOrParish, y => y.Address.City())
                 .RuleFor(x => x.PendingDate, y => y.Date.RecentDateOnly().ToString())
                 .RuleFor(x => x.CloseDate, y => y.Date.RecentDateOnly().ToString())
                 .RuleFor(x => x.CancelDate, y => y.Date.RecentDateOnly().ToString())
                 .RuleFor(x => x.WithdrawDate, y => y.Date.RecentDateOnly().ToString())
                 .RuleFor(x => x.ListAgentFirstName, y => y.Name.FirstName())
                 .RuleFor(x => x.ListAgentMiddleName, y => y.Name.FirstName())
                 .RuleFor(x => x.ListAgentLastName, y => y.Name.LastName())
                 .RuleFor(x => x.ListAgentPreferredPhone, y => y.Phone.PhoneNumber())
                 .RuleFor(x => x.ListAgentPreferredPhoneExt, y => y.Random.Number(1, 9).ToString())
                 .RuleFor(x => x.ListAgentOfficePhone, y => y.Phone.PhoneNumber())
                 .RuleFor(x => x.ListAgentOfficePhoneExt, y => y.Random.Number(1, 9).ToString())
                 .RuleFor(x => x.ListAgentCellPhone, y => y.Phone.PhoneNumber())
                 .RuleFor(x => x.ListAgentDirectPhone, y => y.Phone.PhoneNumber())
                 .RuleFor(x => x.ListAgentTollFreePhone, y => y.Phone.PhoneNumber())
                 .RuleFor(x => x.ListAgentFax, y => y.Phone.PhoneNumber())
                 .RuleFor(x => x.ListAgentPager, y => y.Phone.PhoneNumber())
                 .RuleFor(x => x.ListAgentVoiceMail, y => y.Phone.PhoneNumber())
                 .RuleFor(x => x.ListAgentVoiceMailExt, y => y.Random.Number(1, 9).ToString())
                 .RuleFor(x => x.CloseDate, y => y.Date.RecentDateOnly().ToString())
                 .RuleFor(x => x.CancelDate, y => y.Date.RecentDateOnly().ToString())
                 .RuleFor(x => x.WithdrawDate, y => y.Date.RecentDateOnly().ToString())
                 .RuleFor(x => x.ListAgentEmail, y => y.Internet.ExampleEmail())
                 .RuleFor(x => x.ListAgentURL, y => y.Internet.Url())
                 .RuleFor(x => x.CoListOfficePhone, y => y.Phone.PhoneNumber())
                 .RuleFor(x => x.CoListOfficeFax, y => y.Phone.PhoneNumber())
                 .RuleFor(x => x.CoListAgentPreferredPhone, y => y.Phone.PhoneNumber())
                 .RuleFor(x => x.CoListAgentOfficePhone, y => y.Phone.PhoneNumber())
                 .RuleFor(x => x.CoListAgentCellPhone, y => y.Phone.PhoneNumber())
                 .RuleFor(x => x.CoListAgentDirectPhone, y => y.Phone.PhoneNumber())
                 .RuleFor(x => x.CoListAgentTollFreePhone, y => y.Phone.PhoneNumber())
                 .RuleFor(x => x.CoListAgentFax, y => y.Phone.PhoneNumber())
                 .RuleFor(x => x.CoListAgentPager, y => y.Phone.PhoneNumber())
                 .RuleFor(x => x.CoListAgentVoiceMail, y => y.Phone.PhoneNumber())
                 .RuleFor(x => x.ListOfficePhone, y => y.Phone.PhoneNumber())
                 .RuleFor(x => x.ListOfficeFax, y => y.Phone.PhoneNumber())
                 .RuleFor(x => x.CoListAgentVoiceMailExt, y => y.Random.Number(1, 9).ToString())
                 .RuleFor(x => x.CoListOfficePhoneExt, y => y.Random.Number(1, 9).ToString())
                 .RuleFor(x => x.CoListAgentOfficePhoneExt, y => y.Random.Number(1, 9).ToString())
                 .RuleFor(x => x.CoListAgentPreferredPhoneExt, y => y.Random.Number(1, 9).ToString())
                 .RuleFor(x => x.ListOfficePhoneExt, y => y.Random.Number(1, 9).ToString())
                 .RuleFor(x => x.CoListOfficeEmail, y => y.Internet.ExampleEmail())
                 .RuleFor(x => x.CoListAgentEmail, y => y.Internet.ExampleEmail())
                 .RuleFor(x => x.ListOfficeEmail, y => y.Internet.ExampleEmail())
                 .RuleFor(x => x.CoListAgentURL, y => y.Internet.Url())
                 .RuleFor(x => x.ListOfficeURL, y => y.Internet.Url())
                 .RuleFor(x => x.CoListAgentFirstName, y => y.Name.FirstName())
                 .RuleFor(x => x.CoListAgentMiddleName, y => y.Name.FirstName())
                 .RuleFor(x => x.CoListAgentLastName, y => y.Name.LastName())
                 .RuleFor(x => x.ListAgentStateLicense, y => y.Random.AlphaNumeric(10))
                 .RuleFor(x => x.ListAgentDesignation, y => y.Random.AlphaNumeric(10))
                 .RuleFor(x => x.CoListAgentStateLicense, y => y.Random.AlphaNumeric(10))
                 .RuleFor(x => x.CoListAgentDesignation, y => y.Random.AlphaNumeric(10))
                 .RuleFor(x => x.ListOfficeName, y => y.Name.LastName() + " Realty")
                 .RuleFor(x => x.CoListOfficeName, y => y.Name.LastName() + " Realty")
                 .RuleFor(x => x.VirtualTourURLBranded, y => y.Internet.Url())
                 .RuleFor(x => x.VirtualTourURLUnbranded, y => y.Internet.Url())
                 .RuleFor(x => x.Supplement, y => y.Random.Word())
                 .RuleFor(x => x.ModificationTimestamp, y => y.Date.Recent())
                 .RuleFor(x => x.Photos, y => GetPhotosFaker(y.Random.Number(1, 5)))
                 .RuleFor(x => x.OpenHouses, y => GetOpenHousesFaker(y.Random.Number(1, 5)))
                 .RuleFor(x => x.Documents, y => GetDocumentsFaker(y.Random.Number(1, 5)))
                 .RuleFor(x => x.VirtualTours, y => GetVirtualToursFaker(y.Random.Number(1, 5)))
                 .RuleFor(x => x.Videos, y => GetVideosFaker(y.Random.Number(1, 5)))
                 .RuleFor(x => x.Rooms, y => GetRoomsFaker(y.Random.Number(1, 5)));
        }
        public static List<Video> GetVideosFaker(int num)
        {
            var results = new List<Video>();
            for (int i = 0; i < num; i++)
            {
                var result = new Faker<Video>()
                  .StrictMode(false)
                  .RuleFor(x => x.Id, y => y.Random.Guid().ToString())
                  .RuleFor(x => x.Type, y => "mp4")
                  .RuleFor(x => x.Caption, y => y.Lorem.Paragraph())
                  .RuleFor(x => x.ObjectHtml, y => "")
                  .RuleFor(x => x.Name, y => y.Random.Word() + ".mp4")
                  .RuleFor(x => x.ResourceUri, y => y.Internet.Url());
                results.Add(result);
            }
            return results;
        }
        public static List<Room> GetRoomsFaker(int num)
        {
            var results = new List<Room>();
            for (int i = 0; i < num; i++)
            {
                var result = new Faker<Room>()
                  .StrictMode(false)
                  .RuleFor(x => x.Id, y => y.Random.Guid().ToString())
                  .RuleFor(x => x.Fields, y => GetFieldsFaker(y.Random.Number(1, 5)))
                  .RuleFor(x => x.ResourceUri, y => y.Internet.Url());
                results.Add(result);
            }
            return results;
        }
        public static List<VirtualTour> GetVirtualToursFaker(int num)
        {

            var results = new List<VirtualTour>();
            for (int i = 0; i < num; i++)
            {
                var result = new Faker<VirtualTour>()
                  .StrictMode(false)
                  .RuleFor(x => x.ResourceUri, y => y.Internet.Url())
                  .RuleFor(x => x.Uri, y => y.Internet.Url())
                  .RuleFor(x => x.Id, y => y.Random.Guid().ToString())
                  .RuleFor(x => x.Type, y => "mp4")
                  .RuleFor(x => x.Name, y => y.Random.Word() + ".mp4");
                results.Add(result);
            }
            return results;
        }
        public static List<Field> GetFieldsFaker(int num)
        {
            var results = new List<Field>();
            for (int i = 0; i < num; i++)
            {
                var result = new Faker<Field>()
                  .StrictMode(false)
                  .RuleFor(x => x.Width, y => y.Random.Number(50, 1000))
                  .RuleFor(x => x.Length, y => y.Random.Number(50, 1000))
                  .RuleFor(x => x.Width, y => y.Random.Number(100, 500))
                  .RuleFor(x => x.RoomLevel, y => y.Random.Number(1, 2).ToString())
                  .RuleFor(x => x.NoofRooms, y => y.Random.Number(1, 3).ToString())
                  .RuleFor(x => x.RoomRemarks, y => y.Lorem.Paragraph())
                  .RuleFor(x => x.RoomName, y => y.Random.Word() + " Room")
                  ;
                results.Add(result);
            }
            return results;
        }
        public static List<Document> GetDocumentsFaker(int num)
        {
            var results = new List<Document>();
            for (int i = 0; i < num; i++)
            {
                var result = new Faker<Document>()
                  .StrictMode(false)
                  .RuleFor(x => x.ResourceUri, y => y.Internet.Url())
                  .RuleFor(x => x.Uri, y => y.Internet.Url())
                  .RuleFor(x => x.Id, y => y.Random.Guid().ToString())
                  .RuleFor(x => x.Name, y => y.Random.Word() + ".txt");
                results.Add(result);
            }
            return results;
        }
        public static List<Photo> GetPhotosFaker(int num)
        {
            var results = new List<Photo>();
            for (int i = 0; i < num; i++)
            {
                var result = new Faker<Photo>()
                  .StrictMode(false)
                   .RuleFor(x => x.Name, y => y.Random.Word() + ".jpg")
                  .RuleFor(x => x.ResourceUri, y => y.Internet.Url())
                  .RuleFor(x => x.Caption, y => y.Lorem.Paragraph())
                  .RuleFor(x => x.Id, y => y.Random.Guid().ToString())
                  .RuleFor(x => x.UriThumb, y => y.Internet.Url())
                  .RuleFor(x => x.Uri300, y => y.Internet.Url())
                  .RuleFor(x => x.Uri640, y => y.Internet.Url())
                  .RuleFor(x => x.Uri800, y => y.Internet.Url())
                  .RuleFor(x => x.Uri1024, y => y.Internet.Url())
                  .RuleFor(x => x.Uri1280, y => y.Internet.Url())
                  .RuleFor(x => x.Uri1600, y => y.Internet.Url())
                  .RuleFor(x => x.Uri2048, y => y.Internet.Url())
                  .RuleFor(x => x.UriLarge, y => y.Internet.Url())
                  .RuleFor(x => x.Primary, y => i == 1);
                results.Add(result);
            }
            return results;
        }
        public static List<OpenHouse> GetOpenHousesFaker(int num)
        {
            var results = new List<OpenHouse>();
            for (int i = 0; i < num; i++)
            {
                var result = new Faker<OpenHouse>()
                  .StrictMode(false)
                  .RuleFor(x => x.Id, y => y.Random.Guid().ToString())

                  .RuleFor(x => x.Date, y => y.Date.RecentDateOnly().ToString())
                  .RuleFor(x => x.StartTime, y => y.Date.Recent().ToString())
                  .RuleFor(x => x.EndTime, y => y.Date.Recent().ToString())
                  .RuleFor(x => x.ResourceUri, y => y.Internet.Url());
                results.Add(result);
            }
            return results;
        }
        public static List<Result> GetListingResultsFaker(int num)
        {
            var results = new List<Result>();
            for (int i = 0; i < num; i++)
            {
                var result = new Faker<Result>()
                  .StrictMode(false)
                  .RuleFor(x => x.ResourceUri, y => y.Internet.Url())
                  .RuleFor(x => x.StandardFields, y => GetStandardFieldsFaker())
                  .RuleFor(x => x.Id, y => y.Random.Guid().ToString());
                results.Add(result);
            }
            return results;
        }
        public static Faker<ListingResponse> GetListingFaker()
        {
            return new Faker<ListingResponse>()
              .StrictMode(false)
              .RuleFor(x => x.Results, y => GetListingResultsFaker(20))
              .RuleFor(x => x.Success, y => true);

        }
    }
}
