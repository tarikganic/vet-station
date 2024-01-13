namespace VetStat.Endpoints.VetStationSearch
{
    public interface IVetStationSearchRequest
    {
        public string? name { get; set; }

        public bool? isInOffice { get; set; }

        public bool? isOnField { get; set; } 

        //public bool? locationFilter { get; set; } = null;

        public bool? wifi { get; set; } 

        public bool? parking { get; set; } 

        public bool? wheelchair { get; set; } 
    }
    public class VetStationSearchRequest
    {
        public string? name { get; set; }

        public bool? isInOffice { get; set; } = false;

        public bool? isOnField { get; set; } = false;

        //public bool? locationFilter { get; set; } = null;

        public bool? wifi { get; set; } = false;

        public bool? parking { get; set; } = false;

        public bool? wheelchair { get; set; } = false;

     

        public bool hasFilter()
        {
            //if ((isInOffice == null) || (isOnField == null) || (wifi == null) || (parking == null) || (wheelchair) == null)
            //    return false;
             if ((isInOffice == false) && (isOnField == false) && (wifi == false) &&
                     (parking == false) && (wheelchair) == null)
                return false;

            else return true;
        }

    }
}
