namespace KubernetesRESTful.Models
{
    public class Events
    {
        public string PodName { get; set; }
        public string Namespace { get; set; }
        public string Type { get; set; }
        public string Reason { get; set; }
        public string Message { get; set; }
        public DateTime? LastTimestamp { get; set; }
    }
}
