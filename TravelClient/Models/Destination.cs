namespace TravelClient.Models
{
    public Destination
    {
        public int DestinationId {get; set;}
        public string CityName { get; set;}
        public string Country { get; set;}
        public string Review { get; set;}
        public int Rating { get; set;}
    

        public static List<Destination> GetDestinations()
        {
            var apiCallTask = ApiHelper.GetAll();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Destination> destinationList = JsonConvert.DeserializeObject<destinationList<Destination>>(jsonResponse.ToString());
            return destinationList;
        }
    }
}