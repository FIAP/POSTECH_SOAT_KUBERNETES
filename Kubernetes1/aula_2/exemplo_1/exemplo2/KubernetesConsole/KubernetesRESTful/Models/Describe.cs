namespace KubernetesRESTful.Models
{
    public class Describe
    {
        public Describe(string podName, string @namespace, DateTime? creationTimestamp, string status, string containerStatus)
        {
            PodName = podName;
            Namespace = @namespace;
            CreationTimestamp = creationTimestamp;
            Status = status;
            ContainerStatus = containerStatus;
        }

        public string PodName { get; set; }
        public string Namespace { get; set; }
        public DateTime? CreationTimestamp { get; set; }
        public string Status { get; set; }
        public string ContainerStatus { get; set; }
    }
}
