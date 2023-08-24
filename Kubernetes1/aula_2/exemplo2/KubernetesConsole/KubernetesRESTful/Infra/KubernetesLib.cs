using k8s;
using KubernetesRESTful.Models;
using System.Text;

namespace KubernetesRESTful.Infra
{
    public class KubernetesLib
    {
        private readonly string apiServerUrl = "http://127.0.0.1:8001";
        public IList<string> GetPods()
        {
            var result = new List<string>();

            var config = KubernetesClientConfiguration.BuildDefaultConfig();
            var client = new Kubernetes(config);

            var pods = client.ListNamespacedPod("default");

            foreach (var pod in pods.Items)
            {
                result.Add(pod.Metadata.Name);
            }

            return result;
        }

        public IList<string> GetServices()
        {
            var result = new List<string>();

            string ns = "default";
           
            var config = new KubernetesClientConfiguration { Host = apiServerUrl };

            var client = new Kubernetes(config);

            var services = client.ListNamespacedService(ns).Items;

            foreach (var service in services)
            {
                result.Add(service.Metadata.Name);
            }

            return result;
        }

        public IList<string> GetContainerName(string podName)
        {
            var result = new List<string>();

            string ns = "default";

            var config = new KubernetesClientConfiguration { Host = apiServerUrl };

            var client = new Kubernetes(config);

            var pod = client.ReadNamespacedPod(podName, ns);

            foreach (var container in pod.Spec.Containers)
            {
                result.Add(container.Name);
            }

            return result;
        }

        public IList<Events> GetEvents()
        {
            var eventsLits = new List<Events>();

            string ns = "default";

            var config = new KubernetesClientConfiguration { Host = apiServerUrl };


            var client = new Kubernetes(config);


            var events = client.ListNamespacedEvent(ns).Items;


            foreach (var ev in events)
            {
                var eventK8S = new Events();
                eventK8S.PodName = ev.Metadata.Name;
                eventK8S.Namespace = ev.Metadata.NamespaceProperty;
                eventK8S.Type = ev.Type;
                eventK8S.Reason = ev.Reason;
                eventK8S.Message = ev.Message;
                eventK8S.LastTimestamp = ev.LastTimestamp;

                eventsLits.Add(eventK8S);
            }

            return eventsLits;
        }

        public Describe GetPodDescription(string podName)
        {
            string ns = "default";

            var config = new KubernetesClientConfiguration { Host = apiServerUrl };

            var client = new Kubernetes(config);

            var pod = client.ReadNamespacedPod(podName, ns);

            return new Describe(pod.Metadata.Name, pod.Metadata.NamespaceProperty, pod.Metadata.CreationTimestamp,
                pod.Status.Phase, pod.Status.ContainerStatuses[0].State.ToString());

        }


        public ServiceDetails GetPodServiceDetails(string serviceName)
        {
            var serviceDetail = new ServiceDetails();

            string ns = "default";

            var config = new KubernetesClientConfiguration { Host = apiServerUrl };

            var client = new Kubernetes(config);

            var service = client.ReadNamespacedService(serviceName, ns);

            serviceDetail.ServiceType = service.Spec.Type;
            serviceDetail.ClusterIp = service.Spec.ClusterIP;

            // Get the service ports
            var ports = service.Spec.Ports.FirstOrDefault();

            serviceDetail.Name = service.Metadata.Name;
            serviceDetail.PortNumber = ports.Port;
            serviceDetail.TargetPort = ports.TargetPort;
            serviceDetail.Protocol = ports.Protocol;


            // Get the service selector labels
            var selector = service.Spec.Selector.FirstOrDefault();
            serviceDetail.ServiceLabel = new ServiceLabel(selector.Key, selector.Value);

            return serviceDetail;
        }
    }
}
