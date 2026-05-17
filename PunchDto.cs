namespace PontoFunction
{
    public class PunchDto
    {
        public string Type { get; set; }

        public DateTime TimePunched { get; set; }

        public String? ImageBase64 { get; set; }

        public string ShiftType { get; set; }

        public Double Latitude { get; set; }

        public Double Longitude { get; set; }
    }
}
