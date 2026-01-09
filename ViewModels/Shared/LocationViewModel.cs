namespace AvicennaDispensing.ViewModels.Shared
{
    public class LocationViewModel
    {
        public string? ActionRoute { get; set; }
        public List<LocationsDetail>? LocationList { get; set; }
        public string? SelectedLocationID { get; set; }
        public string? SelectedLocationName { get; set; }
        public class LocationsDetail
        {
            public string? LocationID { get; set; }
            public string? LocationName { get; set; }
        }
    }
}
