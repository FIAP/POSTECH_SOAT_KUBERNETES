// See https://aka.ms/new-console-template for more information
// Set the Kubernetes API server URL
using k8s;

string apiServerUrl = "http://127.0.0.1:8001";


// Create a Kubernetes client configuration with the host URL
var config = new KubernetesClientConfiguration { Host = apiServerUrl };

// Create a Kubernetes client using the configuration
var client = new Kubernetes(config);

// Set the namespace to retrieve events from=≠≠≠
string ns = "default";

// List all services in the specified namespace
var services = client.ListNamespacedService(ns).Items;

foreach (var service in services)
{
    Console.WriteLine($"Service name: {service.Metadata.Name}");
}


Console.ReadLine();
