const k8s = require('@kubernetes/client-node');
const kc = new k8s.KubeConfig();
kc.loadFromDefault();

const k8sApi = kc.makeApiClient(k8s.CoreV1Api);

k8sApi.readNamespacedPod('apicontador-node', 'default').then((res) => {
    console.log(res.body);
}).catch((err) => {
    console.log(err);
});