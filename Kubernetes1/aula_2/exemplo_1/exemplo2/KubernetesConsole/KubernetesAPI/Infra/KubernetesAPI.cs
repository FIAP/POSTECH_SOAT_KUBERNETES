using k8s;

namespace KubernetesAPI.Infra
{
    public class Monitoring
    {
        public string PodName { get; set; }
        public string Log { get; set; }
    }


    public class KubernetesAPI
    {
        public async Task<List<Monitoring>> GetPodsAsync()
        {

            var config = KubernetesClientConfiguration.BuildDefaultConfig();
            var client = new Kubernetes(config);
            var result = new List<Monitoring>();
            string ns = "default";

            //buscar pods
            var pods = client.ListNamespacedPod(ns);

            foreach (var pod in pods.Items)
            {
                var monitoring = new Monitoring();
                // Define the namespace and pod name to retrieve logs from
                monitoring.PodName = pod.Metadata.Name;

                // Create a Kubernetes client using the default configuration


                // Define the container name to retrieve logs from (optional, defaults to first container)
                string containerName = null;

                // Define the number of lines of logs to retrieve (optional, defaults to all)
                int? tailLines = 100;

                // Create a stream to store the logs
                Stream logsStream = null;

                try
                {
                    // Retrieve the logs from the Kubernetes API
                    logsStream = await client.ReadNamespacedPodLogAsync(monitoring.PodName, ns, containerName, tailLines: tailLines);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                // Convert the stream to a string and print it out
                using (var reader = new StreamReader(logsStream))
                {
                    monitoring.Log = await reader.ReadToEndAsync();
                    result.Add(monitoring);
                }
            }      
            

            return result;
        }
    }

}
