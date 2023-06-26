const k8s = require('@kubernetes/client-node');
const fs = require('fs');

// Carregando a configuração do Kubernetes
const kc = new k8s.KubeConfig();
kc.loadFromDefault();

// Criando um objeto de configuração do cliente
const k8sApi = kc.makeApiClient(k8s.CoreV1Api);

// Definindo o manifesto YAML para o pod
const podManifest = `
apiVersion: v1
kind: Pod
metadata:
 name: c-shima
spec:
 containers:
 - name: pod-shima
   image: tadrianonet/shima-image:v1
`;

// Carregando o manifesto YAML para um objeto JSON
const podManifestJson = JSON.parse(JSON.stringify(k8s.loadYaml(podManifest)));

// Criando o objeto do pod
k8sApi.createNamespacedPod('default', podManifestJson)
 .then((response) => {
   console.log('Pod criado com sucesso:', response.body.metadata.name);
 })
 .catch((error) => {
   console.error('Erro ao criar o pod:', error);
 });
