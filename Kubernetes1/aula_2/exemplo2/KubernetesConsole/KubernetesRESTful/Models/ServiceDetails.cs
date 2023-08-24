namespace KubernetesRESTful.Models
{
    public class ServiceDetails
    {
        public string Name { get; set; }
        public string ServiceType { get; set; }
        public string ClusterIp { get; set; }
        public int PortNumber { get; set; }
        public string TargetPort { get; set; }
        public string Protocol { get; set; }
        public ServiceLabel ServiceLabel { get; set; }
    }

    public class ServiceLabel
    {
        public ServiceLabel(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }
        public string Value { get; set; }
    }
}
