namespace TrustEze.Models
{
    public class PropertyDto
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public Dictionary<string, string> Demographics { get; set; }

        public PropertyDto()
        {
            Demographics = new Dictionary<string, string>();
        }
    }
}
