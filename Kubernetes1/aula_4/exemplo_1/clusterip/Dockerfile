# Use a base image
FROM nginx:alpine

# Copy the HTML file to the container
COPY index.html /usr/share/nginx/html/

# Expose port 80
EXPOSE 80

# Start the Nginx server
CMD ["nginx", "-g", "daemon off;"]
