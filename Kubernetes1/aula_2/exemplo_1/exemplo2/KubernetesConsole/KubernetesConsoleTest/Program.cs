using IdentityModel.OidcClient;
using k8s;
using k8s.Models;
using System;
using System.IO;
using System.Text;


// Set the Kubernetes API server URL
string apiServerUrl = "http://127.0.0.1:8001";

// Set the namespace to retrieve events from
string ns = "default";


// Create a Kubernetes client configuration with the host URL
// Create a Kubernetes client configuration with the host URL
var config = new KubernetesClientConfiguration { Host = apiServerUrl };

// Create a Kubernetes client using the configuration
var client = new Kubernetes(config);

// List all services in the specified namespace
var services = client.ListNamespacedService(ns).Items;

foreach (var service in services)
{
    Console.WriteLine($"Service name: {service.Metadata.Name}");
}


Console.ReadLine();


