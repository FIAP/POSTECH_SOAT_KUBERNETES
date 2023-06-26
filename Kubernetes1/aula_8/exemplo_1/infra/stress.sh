#!/bin/bash
for i in {1..10000}; do
  curl localhost:31200
  sleep $1
done
