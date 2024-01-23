const express = require('express');
const prometheus = require('prom-client');

const app = express();
const register = new prometheus.Registry()


// Define a counter metric to track the number of requests to the server
const counter = new prometheus.Counter({
    name: 'myapp_requests_total',
    help: 'Total number of requests to my app'
});

// Define a histogram metric to track the duration of requests
const histogram = new prometheus.Histogram({
    name: 'myapp_request_duration_seconds',
    help: 'Duration of requests to my app',
    buckets: [0.1, 0.5, 1, 2, 5, 10]
});

register.registerMetric(histogram)

// Define a route that increments the counter and records the duration of the request
app.get('/', (req, res) => {
    const end = histogram.startTimer();
    counter.inc();
    res.send('Hello World!');
    end();
});

// Expose the metrics for scraping by Prometheus
app.get('/metrics', (req, res) => {
    res.setHeader('Content-Type', register.contentType)
    register.metrics().then(data => res.send(data));
});

// Start the server
app.listen(3000, () => {
    console.log('Example app listening on port 3000!');
});