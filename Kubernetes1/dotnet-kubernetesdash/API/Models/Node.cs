using System;
using k8s.Models;

namespace API.Models
{

    public class KubernetesInfo
    {
        public KubernetesInfo()
        {
            Nodes = new List<Nodes>();
            KubernetesNamespaces = new List<KubernetesNamespaces>();

        }

        public IList<Nodes> Nodes { get; set; }

        public IList<KubernetesNamespaces>  KubernetesNamespaces { get; set; }
    }


    public class Nodes
    {
        public MetaData MetaData { get; set; }

        public NodeInfo NodeInfo { get; set; }

        public Status Status { get; set; }
    }

    public class Status
    {
        public IDictionary<string, ResourceQuantity> Capacity { get; set; }
    }

    public class MetaData
    {
        public string Name { get; set; }

        public int LabelsTotal { get; set; }

        public DateTime? CreateAt { get; set; }
    }

    public class NodeInfo
    {
        public NodeInfo(string architecture, string bootID, string containerRuntimeVersion, string kernelVersion, string kubeProxyVersion, string kubeletVersion, string machineID, string operatingSystem, string osImage, string systemUUID)
        {
            Architecture = architecture;
            BootID = bootID;
            ContainerRuntimeVersion = containerRuntimeVersion;
            KernelVersion = kernelVersion;
            KubeProxyVersion = kubeProxyVersion;
            KubeletVersion = kubeletVersion;
            MachineID = machineID;
            OperatingSystem = operatingSystem;
            OsImage = osImage;
            SystemUUID = systemUUID;
        }

        public string Architecture { get; set; }

        public string BootID { get; set; }

        public string ContainerRuntimeVersion { get; set; }

        public string KernelVersion { get; set; }

        public string KubeProxyVersion { get; set; }

        public string KubeletVersion { get; set; }
        public string MachineID { get; set; }

        public string OperatingSystem { get; set; }

        public string OsImage { get; set; }

        public string SystemUUID { get; set; }



    }

    public class KubernetesNamespaces
    {
        public string Name { get; set; }

        public string Phase { get; set; }

    }
}

