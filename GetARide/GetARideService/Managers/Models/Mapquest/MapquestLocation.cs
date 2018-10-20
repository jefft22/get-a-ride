namespace GetARideService.Managers.Models.Mapquest
{
    using System;
    using Newtonsoft.Json;

    [Serializable]
    public sealed class MapquestLocation
    {
        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("adminArea6")]
        public string AdminArea6 { get; set; }

        [JsonProperty("adminArea6Type")]
        public string AdminArea6Type { get; set; }

        [JsonProperty("adminArea5")]
        public string AdminArea5 { get; set; }

        [JsonProperty("adminArea5Type")]
        public string AdminArea5Type { get; set; }

        [JsonProperty("adminArea4")]
        public string AdminArea4 { get; set; }

        [JsonProperty("adminArea4Type")]
        public string AdminArea4Type { get; set; }

        [JsonProperty("adminArea3")]
        public string AdminArea3 { get; set; }

        [JsonProperty("adminArea3Type")]
        public string AdminArea3Type { get; set; }

        [JsonProperty("adminArea1")]
        public string AdminArea1 { get; set; }

        [JsonProperty("adminArea1Type")]
        public string AdminArea1Type { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("geocodeQualityCode")]
        public string GeocodeQualityCode { get; set; }

        [JsonProperty("geocodeQuality")]
        public string GeocodeQuality { get; set; }

        [JsonProperty("dragPoint")]
        public bool DragPoint { get; set; }

        [JsonProperty("sideOfStreet")]
        public string SideOfStreet { get; set; }

        [JsonProperty("linkId")]
        public string LinkId { get; set; }

        [JsonProperty("unknownInput")]
        public string UnknownInput { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("latLng")]
        public MapquestLatitudeLongitude LatitudeLongitude { get; set; }

        [JsonProperty("displayLatLng")]
        public MapquestDisplayLatitudeLongitude DisplayLatitudeLongitude { get; set; }

        [JsonProperty("mapUrl")]
        public string MapUrl { get; set; }
    }
}