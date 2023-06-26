const { exec } = require('child_process');

// Function to execute the kubectl command
function executeCommand(command) {
  exec(command, (error, stdout, stderr) => {
    if (error) {
      console.error(`Error executing command: ${error.message}`);
      return;
    }
    if (stderr) {
      console.error(`Command stderr: ${stderr}`);
      return;
    }
    console.log(`Command stdout: ${stdout}`);
  });
}

executeCommand('kubectl delete pods --all --all-namespaces');
executeCommand('kubectl delete --all services --all-namespaces  ');
executeCommand('kubectl delete --all deployments --all-namespaces ');
executeCommand('kubectl delete --all cm --all-namespaces  ');
executeCommand('kubectl delete --all rs --all-namespaces ');

executeCommand('kubectl delete --all pv s');
executeCommand('kubectl delete --all pvc ');
executeCommand('kubectl delete --all sc ');
executeCommand('kubectl delete --all cm');
executeCommand('kubectl delete --all hpa');
executeCommand('kubectl delete --all jobs ');
executeCommand('kubectl delete --all cronjobs');
//  executeCommand('docker stop $(docker ps -a -q)');
//  executeCommand('docker rm $(docker ps -a -q)');